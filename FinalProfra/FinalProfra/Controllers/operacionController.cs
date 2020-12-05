using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProfra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class operacionController : ControllerBase
    {
        [HttpGet]
        public string funcion (int numero) {
            string texto="";
            if (numero > 0) {
                texto= "Usted ingresó el número  "+ numero;
            }
            if (numero < 0)
            {
                texto = "ERROOOR";
            }
            if (numero == 0)
            {
                texto = "Realizado por Paul Aguilar";
            }
            return texto;
        }
    }
}
