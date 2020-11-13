using Logica;
using Entidad;
using Microsoft.AspNetCore.Mvc;
using presentacion.Models;
using System.Collections.Generic;
using System.Linq;
using Datos;

namespace ParcialDotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagoController: ControllerBase
    {
        private readonly TerceroService terceroService;
        public PagoController(ParcialContext context)
        {
            terceroService = new TerceroService(context);
        }

        /*[HttpGet]
        public ActionResult<decimal> Get()
        {
             PagoResponse response = personaService.GetSumaApoyo();
            if(response.Error) {
                BadRequest(response.Message);
            }
            return Ok(response.SumaApoyo);
        }*/
    }
}