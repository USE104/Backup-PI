using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalgadosApp
{
    public partial class frmCalculaPreco : Form
    {
        public frmCalculaPreco()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei em Limpar");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
