using Entidad;
using System;
using System.Collections.Generic;

namespace presentacion.Models
{
    
    public class TerceroInputModel
    {
        public string Identificacion { get; set; }
        public string TipoIdentificacion { get; set; }        
        public string Nombre { get; set; }        
        public string TipoTercero { get; set; }        
        public string Direccion { get; set; }        
        public string Telefono { get; set; }       
        public string Pais { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public List<Pago> Pagos { get; set; }

    }

    public class TerceroViewModel : TerceroInputModel
    {
        public TerceroViewModel() { }

        public TerceroViewModel(Tercero tercero)
        {
            Identificacion = tercero.Identificacion;
            TipoIdentificacion = tercero.TipoIdentificacion;
            Nombre = tercero.Nombre;
            TipoTercero = tercero.TipoTercero;
            Direccion = tercero.Direccion;
            Telefono = tercero.Telefono;
            Pais = tercero.Pais;
            Departamento = tercero.Departamento;
            Ciudad = tercero.Ciudad;
            Pagos = tercero.Pagos;
        }

    }
}