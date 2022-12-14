import { Injectable } from '@angular/core';
import { catchError, Observable, throwError } from 'rxjs';
import { environment } from 'src/environments/environment';
import { WeatherForecast } from './weather-forecast';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class WeatherForecastService {
  private weatherForecastUrl = environment.baseUrl + 'WeatherForecast';

  constructor(private http: HttpClient) {}

  getWeatherForecasts(): Observable<WeatherForecast[]> {
    return this.http
      .get<WeatherForecast[]>(this.weatherForecastUrl)
      .pipe(catchError(this.handleError));
  }

  createWeatherForecast(connectionId: string): Observable<WeatherForecast> {
    const headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'x-signalr-connection': connectionId,
    });
    return this.http
      .post<WeatherForecast>(this.weatherForecastUrl, null, {
        headers: headers,
      })
      .pipe(catchError(this.handleError));
  }

  private handleError(err: any) {
    let errorMessage: string;
    if (err.error instanceof ErrorEvent) {
      errorMessage = `An error occurred: ${err.error.message}`;
    } else {
      errorMessage = `Backend returned code ${err.status}: ${err.body.error}`;
    }
    console.error(err);
    return throwError(errorMessage);
  }
}
