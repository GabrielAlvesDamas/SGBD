namespace View.Crud
{
    partial class vwBairro
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
            toolStripNavegacao = new ToolStrip();
            toolStripButtonNewSearch = new ToolStripButton();
            toolStripButtonSearch = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButtonAdd = new ToolStripButton();
            toolStripButtonSave = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButtonDelete = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButtonFirst = new ToolStripButton();
            toolStripButtonPrevious = new ToolStripButton();
            toolStripLabelIndex = new ToolStripLabel();
            toolStripButtonNext = new ToolStripButton();
            toolStripButtonLast = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButtonRefresh = new ToolStripButton();
            maskedTextBoxCodigo = new MaskedTextBox();
            bds = new BindingSource(components);
            textBoxDescricao = new TextBox();
            label1 = new Label();
            label2 = new Label();
            toolStripNavegacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bds).BeginInit();
            SuspendLayout();
            // 
            // toolStripNavegacao
            // 
            toolStripNavegacao.AutoSize = false;
            toolStripNavegacao.CanOverflow = false;
            toolStripNavegacao.GripStyle = ToolStripGripStyle.Hidden;
            toolStripNavegacao.Items.AddRange(new ToolStripItem[] { toolStripButtonNewSearch, toolStripButtonSearch, toolStripSeparator2, toolStripButtonAdd, toolStripButtonSave, toolStripSeparator3, toolStripButtonDelete, toolStripSeparator4, toolStripButtonFirst, toolStripButtonPrevious, toolStripLabelIndex, toolStripButtonNext, toolStripButtonLast, toolStripSeparator5, toolStripButtonRefresh });
            toolStripNavegacao.Location = new Point(0, 0);
            toolStripNavegacao.Name = "toolStripNavegacao";
            toolStripNavegacao.RenderMode = ToolStripRenderMode.Professional;
            toolStripNavegacao.Size = new Size(800, 50);
            toolStripNavegacao.TabIndex = 1;
            toolStripNavegacao.Text = "toolStrip1";
            // 
            // toolStripButtonNewSearch
            // 
            toolStripButtonNewSearch.AutoSize = false;
            toolStripButtonNewSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonNewSearch.Image = Properties.Resources.icons8_pesquisar_mais_50;
            toolStripButtonNewSearch.ImageTransparentColor = Color.Magenta;
            toolStripButtonNewSearch.Margin = new Padding(0);
            toolStripButtonNewSearch.Name = "toolStripButtonNewSearch";
            toolStripButtonNewSearch.Size = new Size(50, 50);
            toolStripButtonNewSearch.Text = "toolStripButtonNewSearch";
            toolStripButtonNewSearch.Click += toolStripButtonNewSearch_Click;
            // 
            // toolStripButtonSearch
            // 
            toolStripButtonSearch.AutoSize = false;
            toolStripButtonSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSearch.Image = Properties.Resources.icons8_pesquisar_mais_50;
            toolStripButtonSearch.ImageTransparentColor = Color.Magenta;
            toolStripButtonSearch.Margin = new Padding(0, 0, 5, 0);
            toolStripButtonSearch.Name = "toolStripButtonSearch";
            toolStripButtonSearch.Size = new Size(50, 50);
            toolStripButtonSearch.Text = "toolStripButtonSearch";
            toolStripButtonSearch.Click += toolStripButtonSearch_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Margin = new Padding(0, 0, 5, 0);
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 50);
            // 
            // toolStripButtonAdd
            // 
            toolStripButtonAdd.AutoSize = false;
            toolStripButtonAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAdd.Image = Properties.Resources.icons8_adicionar_50;
            toolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            toolStripButtonAdd.Margin = new Padding(0, 0, 5, 0);
            toolStripButtonAdd.Name = "toolStripButtonAdd";
            toolStripButtonAdd.Size = new Size(50, 50);
            toolStripButtonAdd.Text = "toolStripButtonAdd";
            toolStripButtonAdd.Click += toolStripButtonAdd_Click;
            // 
            // toolStripButtonSave
            // 
            toolStripButtonSave.AutoSize = false;
            toolStripButtonSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSave.Image = Properties.Resources.icons8_salvar_50;
            toolStripButtonSave.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new Size(50, 50);
            toolStripButtonSave.Text = "toolStripButtonSave";
            toolStripButtonSave.Click += toolStripButtonSave_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Margin = new Padding(0, 0, 5, 0);
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 50);
            // 
            // toolStripButtonDelete
            // 
            toolStripButtonDelete.AutoSize = false;
            toolStripButtonDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDelete.Image = Properties.Resources.icons8_trash_50;
            toolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            toolStripButtonDelete.Margin = new Padding(0, 0, 5, 0);
            toolStripButtonDelete.Name = "toolStripButtonDelete";
            toolStripButtonDelete.Size = new Size(50, 50);
            toolStripButtonDelete.Text = "toolStripButtonDelete";
            toolStripButtonDelete.Click += toolStripButtonDelete_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Margin = new Padding(0, 0, 5, 0);
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 50);
            // 
            // toolStripButtonFirst
            // 
            toolStripButtonFirst.AutoSize = false;
            toolStripButtonFirst.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonFirst.Image = Properties.Resources.icons8_primeiro_50;
            toolStripButtonFirst.ImageTransparentColor = Color.Magenta;
            toolStripButtonFirst.Margin = new Padding(0, 0, 5, 0);
            toolStripButtonFirst.Name = "toolStripButtonFirst";
            toolStripButtonFirst.Size = new Size(50, 50);
            toolStripButtonFirst.Text = "toolStripButtonFirst";
            toolStripButtonFirst.Click += toolStripButtonFirst_Click;
            // 
            // toolStripButtonPrevious
            // 
            toolStripButtonPrevious.AutoSize = false;
            toolStripButtonPrevious.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonPrevious.Image = Properties.Resources.icons8_anterior_50;
            toolStripButtonPrevious.ImageTransparentColor = Color.Magenta;
            toolStripButtonPrevious.Margin = new Padding(0, 0, 5, 0);
            toolStripButtonPrevious.Name = "toolStripButtonPrevious";
            toolStripButtonPrevious.Size = new Size(50, 50);
            toolStripButtonPrevious.Text = "toolStripButtonPrevious";
            toolStripButtonPrevious.Click += toolStripButtonPrevious_Click;
            // 
            // toolStripLabelIndex
            // 
            toolStripLabelIndex.AutoSize = false;
            toolStripLabelIndex.Enabled = false;
            toolStripLabelIndex.Margin = new Padding(0, 0, 5, 0);
            toolStripLabelIndex.Name = "toolStripLabelIndex";
            toolStripLabelIndex.Size = new Size(100, 50);
            toolStripLabelIndex.Text = "0";
            // 
            // toolStripButtonNext
            // 
            toolStripButtonNext.AutoSize = false;
            toolStripButtonNext.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonNext.Image = Properties.Resources.icons8_próximo_50;
            toolStripButtonNext.ImageTransparentColor = Color.Magenta;
            toolStripButtonNext.Margin = new Padding(0, 0, 5, 0);
            toolStripButtonNext.Name = "toolStripButtonNext";
            toolStripButtonNext.Size = new Size(50, 50);
            toolStripButtonNext.Text = "toolStripButtonNext";
            toolStripButtonNext.Click += toolStripButtonNext_Click;
            // 
            // toolStripButtonLast
            // 
            toolStripButtonLast.AutoSize = false;
            toolStripButtonLast.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonLast.Image = Properties.Resources.icons8_último_50;
            toolStripButtonLast.ImageTransparentColor = Color.Magenta;
            toolStripButtonLast.Margin = new Padding(0, 0, 5, 0);
            toolStripButtonLast.Name = "toolStripButtonLast";
            toolStripButtonLast.Size = new Size(50, 50);
            toolStripButtonLast.Text = "toolStripButtonLast";
            toolStripButtonLast.Click += toolStripButtonLast_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Margin = new Padding(0, 0, 5, 0);
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 50);
            // 
            // toolStripButtonRefresh
            // 
            toolStripButtonRefresh.AutoSize = false;
            toolStripButtonRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonRefresh.Image = Properties.Resources.icons8_actualizar_50;
            toolStripButtonRefresh.ImageTransparentColor = Color.Magenta;
            toolStripButtonRefresh.Margin = new Padding(0, 0, 5, 0);
            toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            toolStripButtonRefresh.Size = new Size(50, 50);
            toolStripButtonRefresh.Text = "toolStripButtonRefresh";
            toolStripButtonRefresh.Click += toolStripButtonRefresh_Click;
            // 
            // maskedTextBoxCodigo
            // 
            maskedTextBoxCodigo.Enabled = false;
            maskedTextBoxCodigo.Location = new Point(66, 138);
            maskedTextBoxCodigo.Name = "maskedTextBoxCodigo";
            maskedTextBoxCodigo.Size = new Size(66, 23);
            maskedTextBoxCodigo.TabIndex = 2;
            // 
            // bds
            // 
            bds.PositionChanged += bds_PositionChanged;
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.Location = new Point(66, 249);
            textBoxDescricao.MaxLength = 70;
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(604, 23);
            textBoxDescricao.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 120);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 17;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 231);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 18;
            label2.Text = "Descrição";
            // 
            // vwBairro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDescricao);
            Controls.Add(maskedTextBoxCodigo);
            Controls.Add(toolStripNavegacao);
            Name = "vwBairro";
            Size = new Size(800, 425);
            toolStripNavegacao.ResumeLayout(false);
            toolStripNavegacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStripNavegacao;
        private ToolStripButton toolStripButtonNewSearch;
        private ToolStripButton toolStripButtonSearch;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButtonAdd;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButtonDelete;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButtonFirst;
        private ToolStripButton toolStripButtonPrevious;
        private ToolStripLabel toolStripLabelIndex;
        private ToolStripButton toolStripButtonNext;
        private ToolStripButton toolStripButtonLast;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButtonRefresh;
        private MaskedTextBox maskedTextBoxCodigo;
        private ToolStripButton toolStripButtonSave;
        private BindingSource bds;
        private TextBox textBoxDescricao;
        private Label label1;
        private Label label2;
    }
}
