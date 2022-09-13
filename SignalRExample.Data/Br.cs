using System;
using System.Collections.Generic;

#nullable disable

namespace SignalRExample.Data
{
    public partial class Br
    {
        public Br()
        {
            BrSumRows = new HashSet<BrSumRow>();
            StructRows = new HashSet<StructRow>();
        }

        public long Id { get; set; }
        public int? BrType { get; set; }
        public long OrgSid { get; set; }
        public int Year { get; set; }

        public virtual ICollection<BrSumRow> BrSumRows { get; set; }
        public virtual ICollection<StructRow> StructRows { get; set; }
    }
}
