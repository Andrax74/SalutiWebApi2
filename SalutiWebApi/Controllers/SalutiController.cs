using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalutiWebApi.Models;

namespace SalutiWebApi.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/saluti")]
    public class SalutiController : Controller
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult TestConnex()
        {
            return Ok(new InfoMsg(DateTime.Today, $"Saluti sono la tua prima web api in Azure App Services"));
        }

        [HttpGet("{Nome}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<InfoMsg> getSaluti2(string Nome)  
        {
            return Ok(new InfoMsg(DateTime.Today, $"Saluti {Nome}, sono la tua web api aggiornata con GitHub 2 in Azure App Services"));
        }

        [HttpGet("{Nome}/{version}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<InfoMsg> getSaluti3(string Nome, string version)
        {
            return Ok(new InfoMsg(DateTime.Today, $"Saluti {Nome}, sono la versione {version} della web api"));
        }
    }
}