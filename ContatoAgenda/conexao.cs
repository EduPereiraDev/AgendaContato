using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


    
namespace ContatoAgenda
{

            public class Conexao
            {
                private static string conexaoString = "Host=localhost;Port=5432;Database=AgendaDB;Username=postgres;Password=123;Timeout=10;SslMode=Prefer";

                public static NpgsqlConnection ObterConexao()
                {
                    var conexao = new NpgsqlConnection(conexaoString);
                    conexao.Open();
                    return conexao;
                }
            }
}


//conexão logica