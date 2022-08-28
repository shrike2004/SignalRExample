import { Component, OnInit } from '@angular/core';
import { WeatherForecast } from '../weatherForecast/weather-forecast';
import { WeatherForecastService } from '../weatherForecast/weather-forecast.service';
import * as signalR from '@microsoft/signalr';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-weather-forecast-list',
  templateUrl: './weather-forecast-list.component.html',
  styleUrls: ['./weather-forecast-list.component.scss'],
})
export class WeatherForecastListComponent implements OnInit {
  pageTitle = 'WeatherForecast List';
  filteredWeatherForecast: WeatherForecast[] = [];
  weatherForecasts: WeatherForecast[] = [];
  errorMessage = '';
  loading = false;

  constructor(private weatherForecastService: WeatherForecastService) {}

  ngOnInit(): void {
    this.getWeatherForecastData();

    const connection = new signalR.HubConnectionBuilder()
      .configureLogging(signalR.LogLevel.Information)
      .withUrl(environment.baseUrl + 'notify')
      .build();

    connection
      .start()
      .then(function () {
        console.log('SignalR Connected!');
      })
      .catch(function (err) {
        return console.error(err.toString());
      });

    connection.on('SendMessage', (x) => {
      this.loading = x.type === 'Start';
      if (x.result) {
        this.weatherForecasts.push(x.result);
      }
      console.log(x);
    });
  }

  getWeatherForecastData() {
    this.weatherForecastService.getWeatherForecasts().subscribe(
      (weatherForecasts) => {
        this.weatherForecasts = weatherForecasts;
        this.filteredWeatherForecast = this.weatherForecasts;
      },
      (error) => (this.errorMessage = <any>error)
    );
  }

  create(): void {
    this.weatherForecastService
      .createWeatherForecast()
      .subscribe((error: any) => (this.errorMessage = <any>error));
  }

  onSaveComplete(): void {
    this.weatherForecastService.getWeatherForecasts().subscribe(
      (weatherForecasts) => {
        this.weatherForecasts = weatherForecasts;
        this.filteredWeatherForecast = this.weatherForecasts;
      },
      (error) => (this.errorMessage = <any>error)
    );
  }
}
