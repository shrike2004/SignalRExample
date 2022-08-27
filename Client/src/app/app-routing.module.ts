import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { WeatherForecastListComponent } from './weatherForecast/weather-forecast-list/weather-forecast-list.component';

const routes: Routes = [
  {
    path: 'weatherForecasts',
    component: WeatherForecastListComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
