using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Adicionar namespace
using Projeto_BancoDados_TurmaB_1Sem.Model_DTO;
using Projeto_BancoDados_TurmaB_1Sem.Controller_DAO;
using Projeto_BancoDados_TurmaB_1Sem.View;

namespace Projeto_BancoDados_TurmaB_1Sem
{
    public partial class frmLogin : Form
    {
        public Boolean retorno = false;
        public DTO_Usuario UsuRetorno = new DTO_Usuario();


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Finalizar sistema?","Finaliza",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrar.Checked)
            {
                // txtSenha.PasswordChar = default;
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                //txtSenha.PasswordChar = '*';
                txtSenha.UseSystemPasswordChar = true;
            }

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Usuario usu = new DTO_Usuario();
                usu.Email_usu = txtEmail.Text;
                usu.Senha_usu = txtSenha.Text;

                DAO_Usuario daousuario = new DAO_Usuario();
                UsuRetorno = daousuario.Login(usu);

                if (UsuRetorno.Nome_usu != null)
                {
                    MessageBox.Show("Seja bem vindo - Sr(a)" + UsuRetorno.Nome_usu);
                    retorno = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário não cadastrado! Cadastre-se!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LnkCadastre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro frmcadastro = new frmCadastro();
            frmcadastro.ShowDialog();
        }
    }
}
