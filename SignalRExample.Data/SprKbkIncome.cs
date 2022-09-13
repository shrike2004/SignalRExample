using System;
using System.Collections.Generic;

#nullable disable

namespace SignalRExample.Data
{
    public partial class SprKbkIncome
    {
        public SprKbkIncome()
        {
            SprRads = new HashSet<SprRad>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime? OnDate { get; set; }
        public DateTime? ToDate { get; set; }

        public virtual ICollection<SprRad> SprRads { get; set; }
    }
}
