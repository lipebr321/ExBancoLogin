﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_BancoDados_TurmaB_1Sem.Model_DTO
{
    public class DTO_Usuario
    {
        int id_usu;
        string nome_usu;
        string email_usu;
        string senha_usu;

        /*
        public string Nome_Usu
        {
            get { return nome_usu; }

            set { nome_usu = value; }
        }*/

        public int Id_usu { get => id_usu; set => id_usu = value; }
        public string Nome_usu { get => nome_usu; set => nome_usu = value; }
        public string Email_usu { get => email_usu; set => email_usu = value; }
        public string Senha_usu { get => senha_usu; set => senha_usu = value; }
    }
}
