using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using SignalRExample.Data;
using SignalRExample.Data.Entity;
using System;
using System.Collections.Generic;

namespace SignalRExample.Services
{
    public class PivotDataService
    {
        Random random = new Random();
        PostgresContext _context;
        private IMemoryCache _cache;
        public static string PresentorPivotRowKey => "_PresentorPivotRow";

        public PivotDataService(PostgresContext context, IMemoryCache memoryCache)
        {
            _context = context;
            _cache = memoryCache;
        }

        public void GenerateData()
        {
            var items = new List<PresentorPivotRow>();
            for (int i = 0; i <= 2000000; i++)
            {
                var presentor = new PresentorPivotRow
                {
                    RzPrz = GetRandomNumberString(),
                    Csr = GetRandomNumberString(),
                    Vr = GetRandomNumberString(),
                    Ou = GetRandomNumberString(),
                    Nr = GetRandomNumberString(),
                    DocSid = GetRandomNumber(111111111, 222222222),
                    SumPartType = new List<string> { "БА", "ЛБО", "ПОФ" }[random.Next(0, 2)],
                    SumMesureName = "Распределено",
                    Value = random.Next(100000, 1000000),
                };
                items.Add(presentor);
            }
            _cache.Set(PresentorPivotRowKey, items);
        }

        public IEnumerable<PresentorPivotRow> List()
        {
            List<PresentorPivotRow> cacheEntry;
            if (!_cache.TryGetValue(PresentorPivotRowKey, out cacheEntry))
            {
                GenerateData();
                _cache.TryGetValue(PresentorPivotRowKey, out cacheEntry);
            }
            return cacheEntry;
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
