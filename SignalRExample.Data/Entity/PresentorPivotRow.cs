using System;
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;


namespace SignalRExample.Data.Entity
{
    /// <summary> Строка отображения данных АО по БА/ЛБО </summary>
    public sealed class PresentorPivotRow : PresentorExpenseKbkPivotPresentorBase
    {
        /// <summary> Код ОУ </summary>
        public string Ou { get; set; }

        /// <summary> Заголовок ОУ </summary>
        [MaybeNull]
        public string OuCaption { get; set; }

        /// <summary> Код НР </summary>
        public string Nr { get; set; }

        /// <summary> Заголовок НР </summary>
        [MaybeNull]
        public string NrCaption { get; set; }

        public string FaipCode { get; set; }

        public override string ToString()
        {
            return String.Format("КБК: {0}.{1}.{2}.{3}.{4}.{5} Тип:{6} {7}{8} Знач:{9} Дт:{10} ПБС:{11} ", RzPrz, Csr, Vr, Kosgu, OuCaption, NrCaption, SumMesureName, SumPartType, YearNum, Value, SumDate, PbsName);
        }

        /// <summary> ПодНР </summary>
        public string UnderNr { get; set; }

        /// <summary> НР ТО </summary>
        public string NrTo { get; set; }
    }
}