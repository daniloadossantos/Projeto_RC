using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RC_System
{
    public partial class FormExcluir : Form
    {
        public FormExcluir()
        {
            InitializeComponent();
        }

        private void FormExcluir_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluirSim_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirNão_Click(object sender, EventArgs e)
        {
            FormExcluir exit = new FormExcluir();
            exit.Close();
        }
    }
}
