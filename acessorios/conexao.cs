using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleDeChamados
{
    public class conexao
    {
        public static OleDbConnection comunicaBanco;
        //public static SqlConnection conexaoMeuBD = new SqlConnection(refConexao.ToString());

        public static void RegistrarBanco()
        {
            comunicaBanco = new OleDbConnection(controleDeChamados.Properties.Settings.Default.conexao);
        }
    }
}
