import { Injectable } from '@angular/core';
import PivotGridDataSource from 'devextreme/ui/pivot_grid/data_source';
import * as AspNetData from 'devextreme-aspnet-data-nojquery';

const dataSource = new PivotGridDataSource({
  store: AspNetData.createStore({
    key: 'OrderID',
    loadUrl: 'http://localhost:5010/PivotReport',
  }),
  fields: [
    {
      caption: 'RzPrz',
      dataField: 'rzPrz',
      expanded: true,
      sortBySummaryField: 'PbsSort',
      sortBySummaryPath: [],
      area: 'row',
    },
    {
      caption: 'Csr',
      dataField: 'csr',
      sortBySummaryField: 'PbsSort',
      sortBySummaryPath: [],
      area: 'row',
    },
    {
      caption: 'Vr',
      dataField: 'vr',
      sortBySummaryField: 'PbsSort',
      sortBySummaryPath: [],
      area: 'row',
    },
    {
      caption: 'Ou',
      dataField: 'ou',
      sortBySummaryField: 'PbsSort',
      sortBySummaryPath: [],
      area: 'row',
    },
    {
      caption: 'Nr',
      dataField: 'nr',
      sortBySummaryField: 'PbsSort',
      sortBySummaryPath: [],
      area: 'row',
    },
    {
      caption: 'YearNum',
      dataField: 'yearNum',
      sortBySummaryField: 'PbsSort',
      sortBySummaryPath: [],
      area: 'column',
    },
    {
      caption: 'Value',
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
