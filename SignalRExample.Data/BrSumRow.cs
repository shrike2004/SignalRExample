using System;
using System.Collections.Generic;

#nullable disable

namespace SignalRExample.Data
{
    public partial class BrSumRow
    {
        public long Id { get; set; }
        public long BrId { get; set; }
        public long StructRowId { get; set; }
        public int? OrderBy { get; set; }
        public long DocumentId { get; set; }
        public string XmlInfo { get; set; }
        public decimal SmBa1 { get; set; }
        public decimal SmBa2 { get; set; }
        public decimal SmBa3 { get; set; }
        public decimal SmLbo1 { get; set; }
        public decimal SmLbo2 { get; set; }
        public decimal SmLbo3 { get; set; }
        public decimal SmPof { get; set; }
        public DateTime SysChangeDate { get; set; }
        public long Generation { get; set; }
        public DateTime? ApproveDate { get; set; }

        public virtual Br Br { get; set; }
        public virtual StructRow StructRow { get; set; }
    }
}
