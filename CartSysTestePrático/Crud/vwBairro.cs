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

namespace View.Crud
{
    public partial class vwBairro : UserControl
    {
        private FormStatusEnum.FormStatus formStatus;
        private IList<Bairro> sourceList;
        private ControllerBairro baseController;

        public vwBairro()
        {
            InitializeComponent();
            FormStatusChange(FormStatusEnum.FormStatus.SEARCHING);
            baseController = new ControllerBairro();
            sourceList = new List<Bairro>();
            bds.DataMember = nameof(Bairro);
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
                    break;
            }
            formStatus = newStatus;
        }

        private void Pesquisar()
        {
            bds.DataSource = baseController.SearchFilter("Bairro");
            bds.ResetCurrentItem();
            FormStatusChange(FormStatusEnum.FormStatus.NAVIGATING);
        }

        private void componentBinding()
        {
            maskedTextBoxCodigo.DataBindings.Add("Text", bds, "Id");
            textBoxDescricao.DataBindings.Add("Text", bds, "Descricao", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void toolStripButtonNewSearch_Click(object sender, EventArgs e)
        {
            bds.Clear();
            FormStatusChange(FormStatusEnum.FormStatus.SEARCHING);
        }

        private void bds_PositionChanged(object sender, EventArgs e)
        {
            Bairro entity = bds.Current as Bairro;
            if (entity != null)
                toolStripLabelIndex.Text = entity.Id.ToString();
            else
                toolStripLabelIndex.Text = "0";
        }

        private void toolStripButtonNext_Click(object sender, EventArgs e)
        {
            bds.MoveNext();
        }

        private void toolStripButtonPrevious_Click(object sender, EventArgs e)
        {
            bds.MovePrevious();
        }

        private void toolStripButtonFirst_Click(object sender, EventArgs e)
        {
            bds.MoveFirst();
        }

        private void toolStripButtonLast_Click(object sender, EventArgs e)
        {
            bds.MoveLast();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            bds.ResetCurrentItem();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            bds.AddNew();
            FormStatusChange(FormStatusEnum.FormStatus.EDITING);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            baseController.Save(bds.Current as Bairro);
            Pesquisar();
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            baseController.Delete(bds.Current as Bairro);
            Pesquisar();
        }

    }
}
