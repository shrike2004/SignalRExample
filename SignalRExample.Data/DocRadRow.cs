using System;
using System.Collections.Generic;

#nullable disable

namespace SignalRExample.Data
{
    public partial class DocRadRow
    {
        public long Id { get; set; }
        public long? RadId { get; set; }
        public string KbkCode { get; set; }
        public DateTime? OndateKbk { get; set; }
        public DateTime? TodateKbk { get; set; }
        public string AdbName { get; set; }
        public string AdbInn { get; set; }
        public string AdbKpp { get; set; }
        public string LawLegalName { get; set; }
        public string LawNumber { get; set; }
        public DateTime? LawDate { get; set; }
        public long DocRadId { get; set; }

        public virtual DocRad DocRad { get; set; }
    }
}
