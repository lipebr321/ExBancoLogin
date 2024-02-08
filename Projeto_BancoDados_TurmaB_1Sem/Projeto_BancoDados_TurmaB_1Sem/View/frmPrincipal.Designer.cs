
namespace Projeto_BancoDados_TurmaB_1Sem
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formuláriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formuláriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formuláriosToolStripMenuItem
            // 
            this.formuláriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmClienteToolStripMenuItem,
            this.frmProdutoToolStripMenuItem});
            this.formuláriosToolStripMenuItem.Name = "formuláriosToolStripMenuItem";
            this.formuláriosToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.formuláriosToolStripMenuItem.Text = "Formulários";
            this.formuláriosToolStripMenuItem.Click += new System.EventHandler(this.formuláriosToolStripMenuItem_Click);
            // 
            // frmClienteToolStripMenuItem
            // 
            this.frmClienteToolStripMenuItem.Name = "frmClienteToolStripMenuItem";
            this.frmClienteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.frmClienteToolStripMenuItem.Text = "frmCliente";
            this.frmClienteToolStripMenuItem.Click += new System.EventHandler(this.frmClienteToolStripMenuItem_Click);
            // 
            // frmProdutoToolStripMenuItem
            // 
            this.frmProdutoToolStripMenuItem.Name = "frmProdutoToolStripMenuItem";
            this.frmProdutoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.frmProdutoToolStripMenuItem.Text = "frmProduto";
            this.frmProdutoToolStripMenuItem.Click += new System.EventHandler(this.frmProdutoToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formuláriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmProdutoToolStripMenuItem;
    }
}

