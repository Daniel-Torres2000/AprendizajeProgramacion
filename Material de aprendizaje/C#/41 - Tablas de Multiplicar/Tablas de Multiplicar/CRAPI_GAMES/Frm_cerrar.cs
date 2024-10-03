using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRAPI_GAMES
{
    public partial class Frm_cerrar : Form
    {
        public Frm_cerrar()
        {
            InitializeComponent();
        }

        private void Btm_si_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btm_no_Click(object sender, EventArgs e)
        {
            Frm_principal ventana = new Frm_principal();
            this.Hide();
            ventana.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
