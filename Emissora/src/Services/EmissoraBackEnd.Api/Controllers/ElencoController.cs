using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emissora.Aplication.AppEmissora;
using Emissora.Aplication.AppEmissora.Input;
using Emissora.Aplication.AppEmissora.Interface;
using Marraia.Notifications.Base;
using Marraia.Notifications.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmissoraBackEnd.Api.Controllers
{
    [Route("api/Elenco")]
    [ApiController]
    public class ElencoController : BaseController
    {
        private readonly IElencoAppServices elencoAppService;

        public ElencoController(INotificationHandler<DomainNotification> notification,
            IElencoAppServices ElencoAppService)
            : base(notification)

        {
            IElencoAppServices elencoAppService = null;
            this.elencoAppService = elencoAppService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), 201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]

        public IActionResult Post([FromBody] Elencoinput input)
        {
            var item = elencoAppService.Insert(input);

            return CreatedContent("", item);
        }

        [HttpGet]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult Get()
        {
            return Ok(elencoAppService.Get());
        }

        [HttpGet]
        [Route("{Id}")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok(elencoAppService.Get());
        }

    }
}
