using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhaWebAPI.Util;
using System.Data;
using MinhaWebAPI.Models;

namespace MinhaWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        // GET api/values
        [HttpGet]
        [Route("listagem")]
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
        [Route("registrarcliente")]
        public ReturnAllServices RegistrarCliente([FromBody]ClienteModel dados)
        {
            ReturnAllServices retorno = new ReturnAllServices();

            try
            {
                dados.RegistrarCliente();
                retorno.Result = true;
                retorno.ErrorMessage = string.Empty;
            }
            catch(Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = "Erro ao tentar registrar um cliente: " + ex.Message;
            }

            return retorno;
        }

        // PUT api/values/5
        [HttpPut]
        [Route("atualizar/{id}")]
        public ReturnAllServices Atualizar(int id, [FromBody]ClienteModel dados)
        {
            ReturnAllServices retorno = new ReturnAllServices();

            try
            {
                dados.Id = id;
                dados.AtualizarCliente();
                retorno.Result = true;
                retorno.ErrorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                retorno.Result = false;
                retorno.ErrorMessage = "Erro ao tentar atualizar um cliente: " + ex.Message;
            }

            return retorno;
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("excluir/{id}")]
        public void Excluir(int id)
        {
            new ClienteModel().Excluir(id);
        }
    }
}
