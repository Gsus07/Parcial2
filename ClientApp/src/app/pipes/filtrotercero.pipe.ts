import { Pipe, PipeTransform } from '@angular/core';
import { Tercero } from '../Models/tercero';

@Pipe({
  name: 'filtrotercero'
})
export class FiltropersonaPipe implements PipeTransform {

  transform(Tercero: Tercero[], searchText: string): any {
    if (searchText == null) return Tercero;
    return Tercero.filter(p =>
      p.documento.indexOf(searchText) !== -1);
  }

}
