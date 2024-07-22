using Data.Entity.Enums;
using Data.Entity;
using Service.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.Controllers.Abstract;

namespace View.Crud
{
    public partial class vwPessoa : UserControl
    {
        private FormStatusEnum.FormStatus formStatus;
        private IList<Pessoa> sourceList;
        private ControllerPessoa baseController;
        private ControllerBairro controllerBairro;
        private ControllerCidade controllerCidade;

        public vwPessoa()
        {
            InitializeComponent();
            FormStatusChange(FormStatusEnum.FormStatus.SEARCHING);
            baseController = new ControllerPessoa();
            controllerBairro = new ControllerBairro();
            controllerCidade = new ControllerCidade();
            sourceList = new List<Pessoa>();
            bds.DataMember = nameof(Pessoa);
            bds.DataSource = sourceList;
            componentBinding();
        }

        private void FormStatusChange(FormStatusEnum.FormStatus newStatus)
        {
            switch (newStatus)
            {
                case FormStatusEnum.FormStatus.SEARCHING:
                    toolStripButtonAdd.Enabled = false;
                    toolStripButtonDelete.Enabled = false;
                    toolStripButtonFirst.Enabled = false;
                    toolStripButtonPrevious.Enabled = false;
                    toolStripButtonLast.Enabled = false;
                    toolStripButtonNext.Enabled = false;
                    toolStripButtonNewSearch.Enabled = false;
                    toolStripButtonRefresh.Enabled = false;
                    toolStripButtonSave.Enabled = false;

                    toolStripButtonSearch.Enabled = true;

                    textBoxNome.Enabled = false;
                    textBoxCPF.Enabled = false;
                    textBoxEndereco.Enabled = false;
                    textBoxNumero.Enabled = false;
                    textBoxCEP.Enabled = false;
                    textBoxTelefonePrincipal.Enabled = false;
                    textBoxTelefoneSecundario.Enabled = false;


                    break;
                case FormStatusEnum.FormStatus.EDITING:
                    toolStripButtonAdd.Enabled = false;
                    toolStripButtonDelete.Enabled = false;
                    toolStripButtonFirst.Enabled = false;
                    toolStripButtonPrevious.Enabled = false;
                    toolStripButtonLast.Enabled = false;
                    toolStripButtonNext.Enabled = false;
                    toolStripButtonNewSearch.Enabled = false;
                    toolStripButtonSearch.Enabled = false;

                    toolStripButtonRefresh.Enabled = true;
                    toolStripButtonSave.Enabled = true;

                    textBoxNome.Enabled = true;
                    textBoxCPF.Enabled = true;
                    textBoxEndereco.Enabled = true;
                    textBoxNumero.Enabled = true;
                    textBoxCEP.Enabled = true;
                    textBoxTelefonePrincipal.Enabled = true;
                    textBoxTelefoneSecundario.Enabled = true;

                    break;
                case FormStatusEnum.FormStatus.NAVIGATING:
                    toolStripButtonAdd.Enabled = true;
                    toolStripButtonDelete.Enabled = true;
                    toolStripButtonFirst.Enabled = true;
                    toolStripButtonPrevious.Enabled = true;
                    toolStripButtonLast.Enabled = true;
                    toolStripButtonNext.Enabled = true;
                    toolStripButtonNewSearch.Enabled = true;
                    toolStripButtonSearch.Enabled = true;
                    toolStripButtonRefresh.Enabled = true;
                    toolStripButtonSave.Enabled = true;

                    textBoxNome.Enabled = true;
                    textBoxCPF.Enabled = true;
                    textBoxEndereco.Enabled = true;
                    textBoxNumero.Enabled = true;
                    textBoxCEP.Enabled = true;
                    textBoxTelefonePrincipal.Enabled = true;
                    textBoxTelefoneSecundario.Enabled = true;

                    break;
            }
            formStatus = newStatus;
        }

        private void Pesquisar()
        {
            bds.DataSource = baseController.SearchFilter("Pessoa");
            bds.ResetCurrentItem();
            FormStatusChange(FormStatusEnum.FormStatus.NAVIGATING);
        }

        private void componentBinding()
        {
            textBoxCodigo.DataBindings.Add("Text", bds, "Id");
            textBoxNome.DataBindings.Add("Text", bds, "Nome", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxCPF.DataBindings.Add("Text", bds, "CPF", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxEndereco.DataBindings.Add("Text", bds, "Endereco", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxNumero.DataBindings.Add("Text", bds, "NumeroEndereco", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxCEP.DataBindings.Add("Text", bds, "CEP", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxTelefonePrincipal.DataBindings.Add("Text", bds, "TelefonePrincipal", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxTelefoneSecundario.DataBindings.Add("Text", bds, "TelefoneSecundario", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void toolStripButtonNewSearch_Click(object sender, EventArgs e)
        {
            bds.Clear();
            FormStatusChange(FormStatusEnum.FormStatus.SEARCHING);
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            bds.AddNew();
            FormStatusChange(FormStatusEnum.FormStatus.EDITING);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            Pessoa pessoaSave = bds.Current as Pessoa;
            int parseNumero;
            if (pessoaSave.NumeroEndereco != null && !int.TryParse(pessoaSave.NumeroEndereco.Trim(), out parseNumero))
            {
                MessageBox.Show("O campo 'Número' não foi preenchido corretamente. Verifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            baseController.Save(pessoaSave);
            Pesquisar();
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            baseController.Delete(bds.Current as Pessoa);
            Pesquisar();
        }

        private void toolStripButtonFirst_Click(object sender, EventArgs e)
        {
            bds.MoveFirst();
        }

        private void toolStripButtonPrevious_Click(object sender, EventArgs e)
        {
            bds.MovePrevious();
        }

        private void toolStripButtonNext_Click(object sender, EventArgs e)
        {
            bds.MoveNext();
        }

        private void toolStripButtonLast_Click(object sender, EventArgs e)
        {
            bds.MoveLast();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            bds.ResetCurrentItem();
        }

        private void bds_PositionChanged(object sender, EventArgs e)
        {
            Pessoa entity = bds.Current as Pessoa;
            if (entity != null)
                toolStripLabelIndex.Text = entity.Id.ToString();
            else
                toolStripLabelIndex.Text = "0";
        }
    }
}
