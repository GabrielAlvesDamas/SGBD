namespace View.Misc
{
    partial class vwRelatorioPessoa
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewPessoa = new DataGridView();
            button1 = new Button();
            bds = new BindingSource(components);
            panel1 = new Panel();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            Endereco = new DataGridViewTextBoxColumn();
            NumeroEndereco = new DataGridViewTextBoxColumn();
            CEP = new DataGridViewTextBoxColumn();
            TelefonePrincipal = new DataGridViewTextBoxColumn();
            TelefoneSecundario = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPessoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bds).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPessoa
            // 
            dataGridViewPessoa.AllowUserToAddRows = false;
            dataGridViewPessoa.AllowUserToDeleteRows = false;
            dataGridViewPessoa.AllowUserToOrderColumns = true;
            dataGridViewPessoa.BackgroundColor = Color.White;
            dataGridViewPessoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPessoa.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, CPF, Endereco, NumeroEndereco, CEP, TelefonePrincipal, TelefoneSecundario });
            dataGridViewPessoa.Location = new Point(3, 66);
            dataGridViewPessoa.Name = "dataGridViewPessoa";
            dataGridViewPessoa.ReadOnly = true;
            dataGridViewPessoa.Size = new Size(792, 354);
            dataGridViewPessoa.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.icons8_pesquisar_50;
            button1.Location = new Point(734, 3);
            button1.Name = "button1";
            button1.Size = new Size(55, 54);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 60);
            panel1.TabIndex = 2;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Código";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 50;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 200;
            // 
            // CPF
            // 
            CPF.DataPropertyName = "CPF";
            CPF.HeaderText = "CPF";
            CPF.Name = "CPF";
            CPF.ReadOnly = true;
            // 
            // Endereco
            // 
            Endereco.DataPropertyName = "Endereco";
            Endereco.HeaderText = "Endereço";
            Endereco.Name = "Endereco";
            Endereco.ReadOnly = true;
            Endereco.Width = 300;
            // 
            // NumeroEndereco
            // 
            NumeroEndereco.DataPropertyName = "NumeroEndereco";
            NumeroEndereco.HeaderText = "Número";
            NumeroEndereco.Name = "NumeroEndereco";
            NumeroEndereco.ReadOnly = true;
            NumeroEndereco.Width = 70;
            // 
            // CEP
            // 
            CEP.DataPropertyName = "CEP";
            CEP.HeaderText = "CEP";
            CEP.Name = "CEP";
            CEP.ReadOnly = true;
            CEP.Width = 70;
            // 
            // TelefonePrincipal
            // 
            TelefonePrincipal.DataPropertyName = "TelefonePrincipal";
            TelefonePrincipal.HeaderText = "Telefone Principal";
            TelefonePrincipal.Name = "TelefonePrincipal";
            TelefonePrincipal.ReadOnly = true;
            TelefonePrincipal.Width = 150;
            // 
            // TelefoneSecundario
            // 
            TelefoneSecundario.DataPropertyName = "TelefoneSecundario";
            TelefoneSecundario.HeaderText = "Telefone Secundário";
            TelefoneSecundario.Name = "TelefoneSecundario";
            TelefoneSecundario.ReadOnly = true;
            TelefoneSecundario.Width = 150;
            // 
            // vwRelatorioPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dataGridViewPessoa);
            Name = "vwRelatorioPessoa";
            Size = new Size(798, 423);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPessoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)bds).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPessoa;
        private Button button1;
        private BindingSource bds;
        private Panel panel1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn Endereco;
        private DataGridViewTextBoxColumn NumeroEndereco;
        private DataGridViewTextBoxColumn CEP;
        private DataGridViewTextBoxColumn TelefonePrincipal;
        private DataGridViewTextBoxColumn TelefoneSecundario;
    }
}
