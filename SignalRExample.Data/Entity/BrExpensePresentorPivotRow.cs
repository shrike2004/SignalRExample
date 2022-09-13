using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRExample.Data.Entity
{
    public class BrExpensePresentorPivotRow
    {
        public string PbsCode { get; set; }
        public string PbsName { get; set; }
        public string PbsSort { get; set; }

        public string RzPrz { get; set; }
        public string Csr { get; set; }
        public string Vr { get; set; }
        public string Kosgu { get; set; }

        public string YearNum { get; set; }

        public string NrCode { get; set; }
        public string NrName { get; set; }

        public long DocSid { get; set; }
        public string DocNum { get; set; }
        public DateTime? DocDate { get; set; }
        public string DocType { get; set; }
        public string DocStatus { get; set; }

        public string SumMesureName { get; set; }
        public string SubSumMesureName { get; set; }
        public string SubSubSumMesureName { get; set; }
        public decimal Value { get; set; }
    }
}
