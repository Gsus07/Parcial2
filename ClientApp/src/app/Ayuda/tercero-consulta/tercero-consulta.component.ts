
import { TerceroService } from 'src/app/services/tercero.service';
import { Tercero } from '../models/tercero';
import { OnInit, Component } from '@angular/core';

@Component({
  selector: 'app-tercero-consulta',
  templateUrl: './tercero-consulta.component.html',
  styleUrls: ['./tercero-consulta.component.css']
})
export class TerceroConsultaComponent implements OnInit {
  terceros: Tercero[];
  //CantidadEntregada: number = 0;
  constructor(private terceroService: TerceroService) { }
  ngOnInit() {
  }

  get(): void {
    this.terceroService.get().subscribe(result => {
      if (result != null) {
        this.terceros = result;
        //this.ApoyoEntregado();
      }

    });
  }
  /*PagoEntregado() {
    this.personaService.getSumaPago().subscribe(s => {
      this.CantidadEntregada = s;
    });
  }*/

}
