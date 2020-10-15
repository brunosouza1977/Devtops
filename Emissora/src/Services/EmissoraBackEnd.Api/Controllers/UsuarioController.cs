using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emissora.Aplication.AppEmissora.Input;
using Emissora.Aplication.AppEmissora.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmissoraBackEnd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioAppService _usuarioAppService;
        public UsuarioController(IUsuarioAppService usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), 201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]

        public IActionResult Post([FromBody] UsuarioInput input)
        {
            try
            {
                var item = _usuarioAppService.Insert(input);
                return Created("", item);
            }
            catch (ArgumentException ex)
            {
                return BadRequest($"Erro => {ex.Message}");
            }
        }

        [HttpGet] //api/hero
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
        public IActionResult Get([FromRoute] Guid id)
        {
            return Ok(_usuarioAppService.Get());
        }

    }
}
