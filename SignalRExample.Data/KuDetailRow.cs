using System;
using System.Collections.Generic;

#nullable disable

namespace SignalRExample.Data
{
    public partial class KuDetailRow
    {
        public long Id { get; set; }
        public DateTime? SysChangeDate { get; set; }
        public long? Generation { get; set; }
        public long DocId { get; set; }
        public long? ParentId { get; set; }
        public decimal SmBa1 { get; set; }
        public decimal SmBa2 { get; set; }
        public decimal SmBa3 { get; set; }
        public decimal SmLbo1 { get; set; }
        public decimal SmLbo2 { get; set; }
        public decimal SmLbo3 { get; set; }
        public decimal SmPof { get; set; }
        public string FullSprKey { get; set; }
        public long? StructRowId { get; set; }
        public long? SprId { get; set; }
        public long? Sid { get; set; }

        public virtual KuDetail Doc { get; set; }
    }
}
