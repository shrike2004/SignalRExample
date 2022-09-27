import { Injectable } from '@angular/core';
import PivotGridDataSource from 'devextreme/ui/pivot_grid/data_source';
import * as AspNetData from 'devextreme-aspnet-data-nojquery';

const dataSource = new PivotGridDataSource({
  remoteOperations: true,
  store: AspNetData.createStore({
    key: 'OrderID',
    loadUrl: 'http://localhost:5010/PivotReport',
  }),
  fields: [
    {
      caption: 'Рз Прз',
      dataField: 'rzPrz',
      expanded: true,
      sortBySummaryField: 'PbsSort',
      sortBySummaryPath: [],
      area: 'column',
    },
    {
      caption: 'ЦСР',
      dataField: 'csr',
      sortBySummaryField: 'PbsSort',
      sortBySummaryPath: [],
      area: 'column',
    },
    {
      caption: 'ВР',
      dataField: 'vr',
      sortBySummaryField: 'PbsSort',
      sortBySummaryPath: [],
      area: 'column',
    },
    {
      caption: 'Год',
      dataField: 'yearNum',
      sortBySummaryField: 'PbsSort',
      sortBySummaryPath: [],
      area: 'column',
    },
    {
      caption: 'БА/ЛБО',
      dataField: 'SumPartType',
      sortBySummaryField: 'PbsSort',
      sortBySummaryPath: [],
      area: 'column',
    },
    {
      caption: 'Доведено/Распределено',
      dataField: 'sumMesureName',
      sortBySummaryField: 'PbsSort',
      sortBySummaryPath: [],
      area: 'column',
    },
    {
      caption: 'ПБС',
      dataField: 'pbsName',
      sortBySummaryField: 'PbsSort',
      sortBySummaryPath: [],
      area: 'row',
    },
    {
      caption: 'НР',
      dataField: 'nr',
      sortBySummaryField: 'PbsSort',
      sortBySummaryPath: [],
      area: 'filter',
    },
    {
      caption: 'Дата',
      dataField: 'SumDate',
      sortBySummaryField: 'PbsSort',
      sortBySummaryPath: [],
      area: 'filter',
    },
    {
      caption: 'Сумма',
      dataField: 'value',
      summaryType: 'sum',
      format: 'currency',
      area: 'data',
    },
    {
      dataField: 'docSid',
      visible: false,
    },
  ],
});

@Injectable({
  providedIn: 'root',
})
export class ReportService {
  getPivotGridDataSource(): PivotGridDataSource {
    return dataSource;
  }
}
export { PivotGridDataSource };
