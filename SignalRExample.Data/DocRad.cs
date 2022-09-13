using System;
using System.Collections.Generic;

#nullable disable

namespace SignalRExample.Data
{
    public partial class DocRad
    {
        public DocRad()
        {
            DocRadRows = new HashSet<DocRadRow>();
        }

        public long Id { get; set; }
        public string DocNum { get; set; }
        public DateTime? DocDt { get; set; }
        public int? Status { get; set; }
        public string LawNumber { get; set; }
        public DateTime? LawDate { get; set; }
        public string BossFio { get; set; }
        public string BossStat { get; set; }
        public string ExecuterFio { get; set; }
        public string ExecuterStat { get; set; }
        public string ExecuterPhone { get; set; }
        public string Descr { get; set; }
        public long? UserSid { get; set; }
        public long? Generation { get; set; }
        public long? Orgid { get; set; }
        public DateTime? SysChangeDate { get; set; }

        public virtual ICollection<DocRadRow> DocRadRows { get; set; }
    }
}
