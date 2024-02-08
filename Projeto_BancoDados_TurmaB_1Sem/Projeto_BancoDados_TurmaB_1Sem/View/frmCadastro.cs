using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_BancoDados_TurmaB_1Sem.Controller_DAO;
using Projeto_BancoDados_TurmaB_1Sem.Model_DTO;
using Projeto_BancoDados_TurmaB_1Sem;


namespace Projeto_BancoDados_TurmaB_1Sem.View
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Usuario usu = new DTO_Usuario();
                usu.Email_usu = txtEmail.Text;
                usu.Nome_usu = txtNome.Text;
                usu.Senha_usu = txtSenha.Text;

                DAO_Usuario daousu = new DAO_Usuario();
                object retorno = daousu.Inserir(usu);

                if (retorno.ToString() == "1")
                {
                    MessageBox.Show("Usuario cadastrado");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }
    }
}
