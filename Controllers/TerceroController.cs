using Datos;
using Entidad;
using Logica;
using Microsoft.AspNetCore.Mvc;
using presentacion.Models;
using System.Collections.Generic;
using System.Linq;
namespace ParcialDotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerceroController : ControllerBase
    {
        private readonly TerceroService terceroService;
        public TerceroController(ParcialContext context)
        {
            terceroService = new TerceroService(context);
        }

        //POST: api/Persona
        [HttpPost]
        public ActionResult<TerceroViewModel> Post(TerceroInputModel terceroInput)
        {
            Tercero Tercero = Mapear(terceroInput);
            ServiceResponse response = terceroService.Guardar(Tercero);
            if (response.Error)
            {
                return BadRequest(response.Message);
            }
            return new TerceroViewModel(response.Tercero);
        }
        private Tercero Mapear(TerceroInputModel terceroInput)
        {
            Tercero tercero = new Tercero
            {
                Identificacion = terceroInput.Identificacion,
                TipoIdentificacion=terceroInput.TipoIdentificacion,
                Nombre = terceroInput.Nombre,
                TipoTercero=terceroInput.TipoTercero,
                Direccion=terceroInput.Direccion,
                Telefono=terceroInput.Telefono,
                Pais=terceroInput.Pais,
                Departamento = terceroInput.Departamento,
                Ciudad = terceroInput.Ciudad,
                Pagos = terceroInput.Pagos
                
            };

            return tercero;
        }

        [HttpGet("{identificacion}")]
        public ActionResult<TerceroViewModel> GetTercero(string identificacion)
        {
            ServiceResponse response = terceroService.GetTercero(identificacion);
            if (response.Tercero == null) return NotFound("La persona no ha sido encontrada");
            TerceroViewModel p = new TerceroViewModel(response.Tercero);

            return Ok(p);
        }

        // GET: api/Persona
        [HttpGet]

        public ActionResult<IEnumerable<TerceroViewModel>> Get()
        {
            ConsultaResponse response = terceroService.GetConsulta();
            if (response.Terceros == null)
            {
                BadRequest(response.Message);
            }
            IEnumerable<TerceroViewModel> terceros = response.Terceros.Select(p => new TerceroViewModel(p));
            return Ok(response.Terceros);
        }
    }
}