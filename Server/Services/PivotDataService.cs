using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SignalRExample.Data;
using SignalRExample.Data.Data;
using SignalRExample.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SignalRExample.Services
{
    public class PivotDataService
    {
        Random random = new Random();
        PostgresContext _context;
        private InMemoryContext _inMemoryContext;
        private readonly ILogger<PivotDataService> _logger;

        public PivotDataService(
            PostgresContext context,
            InMemoryContext inMemoryContext,
            ILogger<PivotDataService> logger
            )
        {
            _context = context;
            _inMemoryContext = inMemoryContext;
            _logger = logger;
        }

        public void GenerateData()
        {
            var items = new List<PresentorPivotRow>();
            for (int i = 0; i < 2000000; i++)
            {
                var presentor = new PresentorPivotRow
                {
                    DocSid = i + 1000,
                    PbsName = "ПБС номер " + GetRandomNumberString(1, 100),
                    RzPrz = GetRandomNumberString(),
                    Csr = GetRandomNumberString(),
                    Vr = GetRandomNumberString(),
                    Ou = GetRandomNumberString(),
                    Nr = GetRandomNumberString(),
                    Kosgu = GetRandomNumberString(),
                    NrTo = GetRandomNumberString(),
                    PbsSort = i.ToString(),
                    SumPartType = new List<string> { "БА", "ЛБО", "ПОФ" }[random.Next(0, 3)],
                    SumMesureName = new List<string> { "Распределено", "Доведено" }[random.Next(0, 2)],
                    YearNum = DateTime.Today.Year + random.Next(0, 3),
                    SumDate = DateTime.Today.AddDays(-random.Next(0, 100)),
                    Value = random.Next(100000, 1000000),
                };
                items.Add(presentor);
            }
            _inMemoryContext.PresentorPivotRows.AddRange(items);
            var saved = _inMemoryContext.SaveChanges();
            _logger.LogInformation($"Saved: {saved}");
        }

        public IQueryable<PresentorPivotRow> List()
        {
            return _inMemoryContext.PresentorPivotRows.AsNoTracking();
        }

        private long GetRandomNumber(int? start = null, int? end = null)
        {
            return random.Next(start ?? 1, end ?? 9);
        }

        private string GetRandomNumberString(int? start = null, int? end = null)
        {
            return GetRandomNumber(start, end).ToString();
        }
    }
}
