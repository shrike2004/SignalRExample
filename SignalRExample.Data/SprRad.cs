using System;
using System.Collections.Generic;

#nullable disable

namespace SignalRExample.Data
{
    public partial class SprRad
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Kbk { get; set; }
        public DateTime OnDate { get; set; }
        public DateTime? ToDate { get; set; }
        public long? SprKbkIncomeId { get; set; }
        public long? OldId { get; set; }

        public virtual SprKbkIncome SprKbkIncome { get; set; }
    }
}
