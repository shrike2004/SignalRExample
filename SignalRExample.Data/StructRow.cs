using System;
using System.Collections.Generic;

#nullable disable

namespace SignalRExample.Data
{
    public partial class StructRow
    {
        public StructRow()
        {
            BrSumRows = new HashSet<BrSumRow>();
            InverseParentRow = new HashSet<StructRow>();
        }

        public long Id { get; set; }
        public long BrId { get; set; }
        public long? ParentRowId { get; set; }
        public long SprId { get; set; }
        public DateTime? OnDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? SysChangeDate { get; set; }
        public string XmlInfo { get; set; }
        public string FullSprKey { get; set; }

        public virtual Br Br { get; set; }
        public virtual StructRow ParentRow { get; set; }
        public virtual ICollection<BrSumRow> BrSumRows { get; set; }
        public virtual ICollection<StructRow> InverseParentRow { get; set; }
    }
}
