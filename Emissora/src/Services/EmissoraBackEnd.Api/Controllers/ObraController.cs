using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emissora.Aplication.AppEmissora.Input;
using Emissora.Aplication.AppEmissora.Interface;
using Marraia.Notifications.Base;
using Marraia.Notifications.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmissoraBackEnd.Api.Controllers
{
    [Route("api/Obra")]
    [ApiController]
    public class ObraController : BaseController
    {
        private readonly IObraAppService _obraAppService;

        public ObraController(INotificationHandler<DomainNotification> notification,
            IObraAppService obraAppService)
            : base(notification)

        {
            _obraAppService = obraAppService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), 201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]

        public IActionResult Post([FromBody] ObraInput input)
        {
            var item = _obraAppService.Insert(input);
            return CreatedContent("", item);
        }

        [HttpPost]
        [Route("api/Obra/{Id}")]
        [ProducesResponseType(typeof(string), 201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]

        public IActionResult Post([FromBody] int id)
        {
            _obraAppService.Delete(id);
            return Ok("Usuário Excluido com Sucesso!!");
        }

        [HttpGet]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult Get()
        {
            return Ok(_obraAppService.Get());
        }

        [HttpGet]
        [Route("{Id}")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok(_obraAppService.Get());
        }

    }
}
