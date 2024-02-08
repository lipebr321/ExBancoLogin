using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Definir Namespace
using MySql.Data.MySqlClient;

namespace Projeto_BancoDados_TurmaB_1Sem.Controller_DAO
{
    class ConexaoMySQL
    {
        public MySqlConnection String_Conexao()
        {
            return new MySqlConnection("user id=root;password=root;server=localhost;database=bcologin_b;SslMode=none");
            //user id - nome usuário
            //password - senha usuário logado
            //server - servidor BD
            //database - Banco de dados
            //SSlMode - Tipo segurança
        }

    }
}
