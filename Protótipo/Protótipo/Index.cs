using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protótipo
{
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastro frmcadastro = new frmCadastro();
          
            frmcadastro.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmConsulta frmconsulta = new frmConsulta();

            frmconsulta.Show();
        }
    }
}
