using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhaWebAPI.Models;
using MinhaWebAPI.Util;

namespace MinhaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [Route ("listagem")]
        public List<ClienteModel> Listagem()
        {
            return new ClienteModel().Listagem();
        }

        // GET api/values/5
        [HttpGet]
        [Route("cliente/{id}")]
        public ClienteModel RetornarCliente(int id)
        {
            return new ClienteModel().RetornarCliente(id);
        }

        // POST api/values
        [HttpPost]
        [Route ("registrarCliente")]
        public ReturnAllServices RegistrarCliente([FromBody] ClienteModel dados)
        {
            ReturnAllServices retorno = new ReturnAllServices();
            try
            {
                dados.RegistrarCliente();
                retorno.Result = true;
                retorno.ErrorMensege = string.Empty;
            }catch(Exception e)
            {
                retorno.Result = false;
                retorno.ErrorMensege = "Erro ao tentar registrar um cliente: " + e.Message;
            }

            return retorno;
            
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
