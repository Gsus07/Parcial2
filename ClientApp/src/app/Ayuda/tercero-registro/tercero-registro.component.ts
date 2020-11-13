import { Component, OnInit } from '@angular/core';
import { Pago } from '../models/Pago';
import { Tercero } from '../models/tercero';

@Component({
  selector: 'app-persona-registro',
  templateUrl: './persona-registro.component.html',
  styleUrls: [ './persona-registro.component.css' ]
})
export class PersonaRegistroComponent implements OnInit {
  tercero: Tercero;
  Pago: Pago;
  CantidadDisponible: number = 0;
  CantidadEntrega: number = 0;

  constructor(private terceroService: TerceroService) {}

  ngOnInit() {
    this.tercero = new Tercero();
    this.Pago = new Pago();
    this.tercero.pago = this.Pago;
    //this.ApoyoDisponible();
  }

 /* ApoyoDisponible() {
    this.personaService.getSumaApoyo().subscribe((s) => {
      this.CantidadEntrega = s;
      this.CantidadDisponible = this.personaService.maxAids - this.CantidadEntrega;
    });
  }*/

  isRegistered() {
    //this.ApoyoDisponible();
    this.tercero.pago = this.Pago;
      console.log('Aprovado');
      this.add();
    
  }

  add(): void {
    console.log('En proceso');
    this.tercero.pago.valorPago = +this.tercero.pago.valorPago;
    this.terceroService.post(this.tercero).subscribe((p) => {
      if (p != null) {
        alert('Tercero guadado');
        console.log(p);
      }
    });
  }
}
