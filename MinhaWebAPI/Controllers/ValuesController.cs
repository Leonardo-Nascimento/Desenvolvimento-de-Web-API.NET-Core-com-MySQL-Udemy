using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhaWebAPI.Util;
using System.Data;

namespace MinhaWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            DAL objDAL = new DAL();

            //string sql = "insert into cliente(nome,data_cadastro, cpf_cnpj, data_nascimento, tipo, telefone, email,cep, logradouro, numero,bairro, complemento, cidade, uf) " +
            //             "values('Filipe', '2018/05/22', '07099999999', '1987/05/22', 'F', '3199999999', 'filipenhimi@gmail.com', '33333333', 'Rua Teste', '123', 'Teste', '', 'Belo Horizonte', 'MG')";
            //objDAL.ExecutarComandoSQL(sql);

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            DAL objDAL = new DAL();

            string sql = $"SELECT * from Cliente where id = {id}";
            DataTable dados = objDAL.RetornarDataTable(sql);

            return dados.Rows[0]["Nome"].ToString();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
