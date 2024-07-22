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

namespace View.Misc
{
    public partial class vwRelatorioPessoa : UserControl
    {
        private IList<Pessoa> sourceList;
        private ControllerPessoa baseController;

        public vwRelatorioPessoa()
        {
            InitializeComponent();
            baseController = new ControllerPessoa();
            sourceList = new List<Pessoa>();
            bds.DataMember = nameof(Pessoa);
            bds.DataSource = sourceList;
            dataGridViewPessoa.DataSource = bds;
            dataGridViewPessoa.DataMember = bds.DataMember;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bds.DataSource = baseController.SearchFilter("Pessoa");
            bds.ResetCurrentItem();
        }
    }
}
