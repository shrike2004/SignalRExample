using System;
using System.ComponentModel;

namespace SignalRExample.Data.Entity
{
    public class PresentorExpenseKbkPivotPresentorBase
    {
        public long DocSid { get; set; }

        [Description("Рз, Прз")]
        public string RzPrz { get; set; }

        [Description("ЦСР")]
        public string Csr { get; set; }

        [Description("ВР")]
        public string Vr { get; set; }

        [Description("КОСГУ")]
        public string Kosgu { get; set; }


        // ПБС
        public string PbsCode { get; set; }
        public string PbsName { get; set; }
        public string PbsSort { get; set; }

        /// <summary>  БА-ЛБО-ПОФ </summary>
        public string SumPartType { get; set; }
        /// <summary> Распределено/Доведено </summary>
        public string SumMesureName { get; set; }
        public string SumMesureSort { get; set; }

        // Год
        public int YearNum { get; set; }

        // Дата суммы (для Распределено - дата документа, для РР - дата вступления в дейтсвие?)
        public DateTime SumDate { get; set; }

        // Собственно сумма
        public decimal Value { get; set; }


        public override string ToString()
        {
            return String.Format("КБК: {0}.{1}.{2}.{3} Тип:{5} {6}{7} Знач:{8} Дт:{9} ПБС:{4} ", RzPrz, Csr, Vr, Kosgu, PbsName, SumMesureName, SumPartType, YearNum, Value, SumDate);
        }
    }
}