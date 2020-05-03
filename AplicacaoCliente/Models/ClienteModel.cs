﻿using AplicacaoCliente.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace AplicacaoCliente.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Data_Cadastro { get; set; }
        public string Cpf_Cnpj { get; set; }
        public string Data_Nascimento { get; set; }
        public string Tipo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }

        public List<ClienteModel> ListarTodosOsClientes()
        {
            List<ClienteModel> clienteModels = new List<ClienteModel>();

            string jsonRetorno = WebAPI.RequestGet("listagem",string.Empty);

            clienteModels = JsonConvert.DeserializeObject<List<ClienteModel>>(jsonRetorno);

            return clienteModels;
        }
    }
}
