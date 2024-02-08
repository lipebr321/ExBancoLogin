namespace Projeto_BancoDados_TurmaB_1Sem.View
{
    partial class frmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.grpControle = new System.Windows.Forms.GroupBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.grpControle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSenha.Location = new System.Drawing.Point(139, 141);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(338, 26);
            this.txtSenha.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsReturn = true;
            this.txtEmail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtEmail.Location = new System.Drawing.Point(137, 75);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 26);
            this.txtEmail.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNome.Location = new System.Drawing.Point(137, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(340, 26);
            this.txtNome.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(37, 75);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(37, 141);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(56, 20);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(37, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // grpControle
            // 
            this.grpControle.Controls.Add(this.btnFinalizar);
            this.grpControle.Controls.Add(this.btnInserir);
            this.grpControle.Location = new System.Drawing.Point(41, 192);
            this.grpControle.Name = "grpControle";
            this.grpControle.Size = new System.Drawing.Size(436, 100);
            this.grpControle.TabIndex = 6;
            this.grpControle.TabStop = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(231, 25);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(114, 52);
            this.btnFinalizar.TabIndex = 1;
            this.btnFinalizar.Text = "Fi&nalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(96, 25);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(116, 52);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "In&serir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 304);
            this.Controls.Add(this.grpControle);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Name = "frmCadastro";
            this.Text = "Cadastro usuario";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.grpControle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox grpControle;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnInserir;
    }
}