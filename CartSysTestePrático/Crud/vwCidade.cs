using Data.Entity;
using Data.Entity.Enums;
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
using Data.Entity.Enums;

namespace View.Crud
{
    public partial class vwCidade : UserControl
    {
        private FormStatusEnum.FormStatus formStatus;
        private IList<Cidade> sourceList;
        private ControllerCidade baseController;

        public vwCidade()
        {
            InitializeComponent();
            FormStatusChange(FormStatusEnum.FormStatus.SEARCHING);
            baseController = new ControllerCidade();
            sourceList = new List<Cidade>();
            bds.DataMember = nameof(Cidade);
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

                    textBoxDescricao.Enabled = false;
                    textBoxUF.Enabled = false;
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

                    textBoxDescricao.Enabled = true;
                    textBoxUF.Enabled = true;
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

                    textBoxDescricao.Enabled = true;
                    textBoxUF.Enabled = true;
                    break;
            }
            formStatus = newStatus;
        }

        private void Pesquisar()
        {
            bds.DataSource = baseController.SearchFilter("Cidade");
            bds.ResetCurrentItem();
            FormStatusChange(FormStatusEnum.FormStatus.NAVIGATING);
        }

        private void componentBinding()
        {
            maskedTextBoxCodigo.DataBindings.Add("Text", bds, "Id");
            textBoxDescricao.DataBindings.Add("Text", bds, "Descricao", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxUF.DataBindings.Add("Text", bds, "UF", true, DataSourceUpdateMode.OnPropertyChanged);
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
            baseController.Save(bds.Current as Cidade);
            Pesquisar();
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            baseController.Delete(bds.Current as Cidade);
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
            Cidade entity = bds.Current as Cidade;
            if (entity != null)
                toolStripLabelIndex.Text = entity.Id.ToString();
            else
                toolStripLabelIndex.Text = "0";
        }
    }
}