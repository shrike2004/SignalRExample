import { Injectable } from '@angular/core';
import PivotGridDataSource from 'devextreme/ui/pivot_grid/data_source';

const dataSource = new PivotGridDataSource({
  store: {
    type: 'xmla',
    url: 'https://demos.devexpress.com/Services/OLAP/msmdpump.dll',
    catalog: 'Adventure Works DW Standard Edition',
    cube: 'Adventure Works',
  },
  fields: [
    {
      caption: 'Category',
      dataField: 'ProductCategoryName',
      width: 250,
      expanded: true,
      sortBySummaryField: 'SalesAmount',
      sortBySummaryPath: [],
      sortOrder: 'desc',
      area: 'row',
    },
    {
      caption: 'Subcategory',
      dataField: 'ProductSubcategoryName',
      width: 250,
      sortBySummaryField: 'SalesAmount',
      sortBySummaryPath: [],
      sortOrder: 'desc',
      area: 'row',
    },
    {
      caption: 'Product',
      dataField: 'ProductName',
      area: 'row',
      sortBySummaryField: 'SalesAmount',
      sortBySummaryPath: [],
      sortOrder: 'desc',
      width: 250,
    },
    {
      caption: 'Date',
      dataField: 'DateKey',
      dataType: 'date',
      area: 'column',
    },
    {
      caption: 'Amount',
      dataField: 'SalesAmount',
      summaryType: 'sum',
      format: 'currency',
      area: 'data',
    },
    {
      caption: 'Store',
      dataField: 'StoreName',
    },
    {
      caption: 'Quantity',
      dataField: 'SalesQuantity',
      summaryType: 'sum',
    },
    {
      caption: 'Unit Price',
      dataField: 'UnitPrice',
      format: 'currency',
      summaryType: 'sum',
    },
    {
      dataField: 'Id',
      visible: false,
    },
  ],
});

@Injectable({
  providedIn: 'root',
})
export class ReportService {
  constructor() {}

  getPivotGridDataSource(): PivotGridDataSource {
    return dataSource;
  }
}
export { PivotGridDataSource };
