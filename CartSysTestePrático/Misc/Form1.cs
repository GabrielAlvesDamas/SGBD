using Data;
using Data.Entity;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using Service.Controllers;
using Service.Controllers.Abstract;
using System.Transactions;
using System.Windows.Forms;
using View.Crud;
using View.Misc;

namespace CartSysTestePrático
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void LoadScreen(UserControl uC)
        {
            UserControl uCScreen = uC;

            panelUc.Controls.Clear();
            panelUc.Controls.Add(uCScreen);
            uCScreen.Dock = DockStyle.Fill;
        }
        private void toolStripMenuItemBairro_Click(object sender, EventArgs e)
        {
            LoadScreen(new vwBairro());
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadScreen(new vwCidade());
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadScreen(new vwPessoa());
        }

        private void reltórioPesssoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadScreen(new vwRelatorioPessoa());
        }
    }
}
