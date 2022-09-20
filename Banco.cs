using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Academia
{
    internal class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data source = D:\\C#\\Parte 2\\Academia\\Academia\\banco\\bd_academia");
            conexao.Open();

            return conexao;
        }

        
    }
}
