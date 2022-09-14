import { Component, OnInit } from '@angular/core';
import { exportPivotGrid } from 'devextreme/excel_exporter';
import { PivotGridDataSource, ReportService } from '../report.service';

@Component({
  selector: 'app-report',
  templateUrl: './report.component.html',
  styleUrls: ['./report.component.scss'],
})
export class ReportComponent {
  title = 'Getting Started with DevExtreme PivotGrid';
  dataSource: PivotGridDataSource;

  constructor(service: ReportService) {
    this.dataSource = service.getPivotGridDataSource();
  }
}
