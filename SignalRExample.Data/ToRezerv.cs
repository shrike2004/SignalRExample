using System;
using System.Collections.Generic;

#nullable disable

namespace SignalRExample.Data
{
    public partial class ToRezerv
    {
        public long Id { get; set; }
        public string DocNum { get; set; }
        public DateTime? ApproveDt { get; set; }
        public DateTime? CreateDt { get; set; }
        public string DocStatus { get; set; }
        public string DocStatusName { get; set; }
        public string Descr { get; set; }
        public long? UserSid { get; set; }
        public long? OrgSid { get; set; }
        public long? BrSid { get; set; }
        public long? TopBrRowSid { get; set; }
        public string TopFullSprKey { get; set; }
        public bool? IsFirstDistribution { get; set; }
    }
}
