using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MinhaWebAPI.Util
{
    public class DAL
    {
        private static string Server = "localhost";
        private static string Database = "dbcliente";
        private static string User = "root";
        private static string Password = "";
        private MySqlConnection Connection;

        private static string ConnectionString = $"server={Server};Database={Database};Uid={User};Pwd={Password}";
        

        public DAL()
        {
            Connection = new MySqlConnection(ConnectionString);            
            Connection.Open();
        }

        // Executa: INSERT, UPDATE, DELETE
        public void ExecutarComandoSQL(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, Connection);
            command.ExecuteNonQuery();
        }

        //Retorna Dados do Banco
        public DataTable RetornaDataTable(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, Connection);
            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(command);

            DataTable Dados = new DataTable();
            DataAdapter.Fill(Dados);
            return Dados;
        }

    }
}
