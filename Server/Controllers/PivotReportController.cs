using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SignalRExample.Data.Entity;
using SignalRExample.Services;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public IEnumerable<PresentorPivotRow> Get()
        {
            return _service.List();
        }
    }
}
