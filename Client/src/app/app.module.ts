import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { WeatherForecastListComponent } from './weatherForecast/weather-forecast-list/weather-forecast-list.component';
import { HomeComponent } from './home/home.component';

@NgModule({
  declarations: [AppComponent, WeatherForecastListComponent, HomeComponent],
  imports: [BrowserModule, AppRoutingModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
