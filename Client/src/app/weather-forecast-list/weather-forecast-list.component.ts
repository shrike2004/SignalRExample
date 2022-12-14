import { Component, OnInit } from '@angular/core';
import { WeatherForecastService } from './weather-forecast.service';
import * as signalR from '@microsoft/signalr';
import { environment } from 'src/environments/environment';
import { WeatherForecast } from './weather-forecast';

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
  progress = 0;
  connectionId: string | null = null;

  constructor(private weatherForecastService: WeatherForecastService) {}

  ngOnInit(): void {
    const self = this;
    this.getWeatherForecastData();

    const connection = new signalR.HubConnectionBuilder()
      .configureLogging(signalR.LogLevel.Information)
      .withUrl(environment.baseUrl + 'notify')
      .build();

    connection
      .start()
      .then(function () {
        console.log(
          'SignalR Connected! ConnectionId is: ' + connection.connectionId
        );
        self.connectionId = connection.connectionId;
      })
      .catch(function (err) {
        return console.error(err.toString());
      });

    connection.on('SendMessage', (x) => {
      this.loading = x.loading;
      this.progress = x.progress;
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
      .createWeatherForecast(this.connectionId!)
      .subscribe((error: any) => (this.errorMessage = <any>error));
  }
}
