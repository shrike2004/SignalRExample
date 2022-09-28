using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SignalRExample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SignalRExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PivotReportController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly PivotDataService _service;

        public PivotReportController(
            ILogger<WeatherForecastController> logger,
            PivotDataService service
            )
        {
            _logger = logger;
            _service = service;
        }

        /// <summary>
        /// Получаем список данных
        /// </summary>
        /// <returns>список pivot данных</returns>
        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions)
        {
            loadOptions.PrimaryKey = new[] { "DocSid" };
            loadOptions.PaginateViaPrimaryKey = true;

            var source = _service.List();

            return Ok(await DataSourceLoader.LoadAsync(source, loadOptions));
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            var source = _service.List().OrderBy(x => x.DocSid).Take(2000);
            return Ok(source);
        }
    }
}
