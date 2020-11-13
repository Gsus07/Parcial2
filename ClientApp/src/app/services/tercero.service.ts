
import { Tercero } from '../Ayuda/models/tercero';
import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import { tap, catchError } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { DecimalPipe } from '@angular/common';

@Injectable({
  providedIn: 'root'
})
export class TerceroService {

  baseUrl: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string, private handleErrorService: HandleHttpErrorService) {
    this.baseUrl = baseUrl;
  }
  //deliveredVale: number = 0;
  //maxAids: number = 600000000;

  getTercero(tercero: Tercero): Observable<Tercero> {

    return this.http.get<Tercero>(this.baseUrl + 'api/Tercero' + '/' + tercero.identificacion)
      .pipe(tap(_ => this.handleErrorService.log('datos verificados con exito')),
        catchError(this.handleErrorService.handleError<Tercero>('buscado con exito', new Tercero()))
      );
  }

  post(tercero: Tercero): Observable<Tercero> {
    return this.http.post<Tercero>(this.baseUrl + 'api/Tercero', tercero)
      .pipe(tap(_ => this.handleErrorService.log('datos guardados de manera correcta')),
        catchError(this.handleErrorService.handleError<Tercero>('Registro de terceros', null))
      );
  }

  get(): Observable<Tercero[]> {
    return this.http.get<Tercero[]>(this.baseUrl + 'api/Tercero').
      pipe(tap(_ => this.handleErrorService.log('datos consultados de manera correcta')),
        catchError(this.handleErrorService.handleError<Tercero[]>('Consulta de terceros', null))
      );
  }
  getSumaPago(): Observable<number> {
    return this.http.get<number>(this.baseUrl + 'api/Pago')
      .pipe(tap(_ => this.handleErrorService.log('Pagos consultados')),
        catchError(this.handleErrorService.handleError<number>('Suma', 0))
      );
  }
 
}
