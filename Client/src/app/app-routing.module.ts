import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { WeatherForecastListComponent } from './weather-forecast-list/weather-forecast-list.component';
import { ReportComponent } from './report/report.component';

const routes: Routes = [
  {
    path: 'weatherForecasts',
    component: WeatherForecastListComponent,
  },
  {
    path: 'report',
    component: ReportComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
