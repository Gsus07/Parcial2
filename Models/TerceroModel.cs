using Entidad;
using System;

namespace presentacion.Models
{
    public class PagoModel
    {
        public int Id { get; set; }        
        public string TipoPago { get; set; }
        public DateTime Fecha { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorIva { get; set; }
    }
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
        public PagoModel Pago { get; set; }

    }

    public class TerceroViewModel : TerceroInputModel
    {
        public TerceroViewModel() { }

        public TerceroViewModel(Tercero tercero)
        {
            Identificacion = tercero.Identificacion;
            Nombre = tercero.Nombre;
            TipoTercero = tercero.TipoTercero;
            Direccion = tercero.Direccion;
            Telefono = tercero.Telefono;
            Pais = tercero.Pais;
            Departamento = tercero.Departamento;
            Ciudad = tercero.Ciudad;
            Pago = new PagoModel
            {
                Id = tercero.pago.Id,
                TipoPago = tercero.pago.Tipopago,
                Fecha = tercero.pago.Fecha,
                ValorPago = tercero.pago.ValorPago,
                ValorIva = tercero.pago.ValorIva
            };
        }

    }
}