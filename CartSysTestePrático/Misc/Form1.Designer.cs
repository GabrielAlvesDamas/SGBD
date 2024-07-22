namespace CartSysTestePrático
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStripPrincipal = new MenuStrip();
            toolStripMenuItemBairro = new ToolStripMenuItem();
            cidadeToolStripMenuItem = new ToolStripMenuItem();
            pessoaToolStripMenuItem = new ToolStripMenuItem();
            reltórioPesssoaToolStripMenuItem = new ToolStripMenuItem();
            panelUc = new Panel();
            menuStripPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            menuStripPrincipal.Items.AddRange(new ToolStripItem[] { toolStripMenuItemBairro, cidadeToolStripMenuItem, pessoaToolStripMenuItem, reltórioPesssoaToolStripMenuItem });
            menuStripPrincipal.Location = new Point(0, 0);
            menuStripPrincipal.Name = "menuStripPrincipal";
            menuStripPrincipal.Size = new Size(800, 24);
            menuStripPrincipal.TabIndex = 0;
            menuStripPrincipal.Text = "menuStrip1";
            // 
            // toolStripMenuItemBairro
            // 
            toolStripMenuItemBairro.Name = "toolStripMenuItemBairro";
            toolStripMenuItemBairro.Size = new Size(67, 20);
            toolStripMenuItemBairro.Text = "&1 - Bairro";
            toolStripMenuItemBairro.Click += toolStripMenuItemBairro_Click;
            // 
            // cidadeToolStripMenuItem
            // 
            cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            cidadeToolStripMenuItem.Size = new Size(73, 20);
            cidadeToolStripMenuItem.Text = "&2 - Cidade";
            cidadeToolStripMenuItem.Click += cidadeToolStripMenuItem_Click;
            // 
            // pessoaToolStripMenuItem
            // 
            pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            pessoaToolStripMenuItem.Size = new Size(72, 20);
            pessoaToolStripMenuItem.Text = "&3 - Pessoa";
            pessoaToolStripMenuItem.Click += pessoaToolStripMenuItem_Click;
            // 
            // reltórioPesssoaToolStripMenuItem
            // 
            reltórioPesssoaToolStripMenuItem.Name = "reltórioPesssoaToolStripMenuItem";
            reltórioPesssoaToolStripMenuItem.Size = new Size(127, 20);
            reltórioPesssoaToolStripMenuItem.Text = "&4 - Relatório Pesssoa";
            reltórioPesssoaToolStripMenuItem.Click += reltórioPesssoaToolStripMenuItem_Click;
            // 
            // panelUc
            // 
            panelUc.BackColor = SystemColors.AppWorkspace;
            panelUc.Location = new Point(0, 27);
            panelUc.Name = "panelUc";
            panelUc.Size = new Size(800, 425);
            panelUc.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelUc);
            Controls.Add(menuStripPrincipal);
            MainMenuStrip = menuStripPrincipal;
            Name = "Form1";
            Text = "SGBD";
            menuStripPrincipal.ResumeLayout(false);
            menuStripPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripPrincipal;
        private ToolStripMenuItem toolStripMenuItemBairro;
        private Panel panelUc;
        private ToolStripMenuItem cidadeToolStripMenuItem;
        private ToolStripMenuItem pessoaToolStripMenuItem;
        private ToolStripMenuItem reltórioPesssoaToolStripMenuItem;
    }
}
