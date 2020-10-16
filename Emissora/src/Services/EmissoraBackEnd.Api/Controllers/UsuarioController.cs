using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marraia.Notifications.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Emissora.Aplication.AppEmissora.Input;
using Emissora.Aplication.AppEmissora.Interface;
using Marraia.Notifications.Base;



namespace EmissoraBackEnd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : BaseController
    {
        private readonly IUsuarioAppService _usuarioAppService;
        public UsuarioController(INotificationHandler<DomainNotification> notification,
            IUsuarioAppService usuarioAppService)
            : base(notification)

        {
            _usuarioAppService = usuarioAppService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), 201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]

        public IActionResult Post([FromBody] UsuarioInput input)
        {
            var item = _usuarioAppService.Insert(input);
            return CreatedContent("", item);
        }


        [HttpPost]
        [Route("{Id}")]
        [ProducesResponseType(typeof(string), 201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]

        public IActionResult Post([FromBody] int id)
        {
            _usuarioAppService.Delete(id);
            return Ok("Usuário Excluido com Sucesso!!");
        }

        [HttpGet]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult Get()
        {
            return Ok(_usuarioAppService.Get());
        }

        [HttpGet]
        [Route("{Id}")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok(_usuarioAppService.Get());
        }

    }
}
