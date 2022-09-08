import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { WeatherForecastListComponent } from './weather-forecast-list/weather-forecast-list.component';
import { HttpClientModule } from '@angular/common/http';
import { ReportComponent } from './report/report.component';
import { DxButtonModule, DxPivotGridModule } from 'devextreme-angular';

@NgModule({
  declarations: [AppComponent, WeatherForecastListComponent, ReportComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    DxButtonModule,
    DxPivotGridModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
