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
    public partial class Frm_instrrucciones : Form
    {
        public Frm_instrrucciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_principal instancia = new Frm_principal();
            instancia.Show();
            this.Hide();
        }

        private void Btm_comenzar_Click(object sender, EventArgs e)
        {
            Frm_jugar ventana = new Frm_jugar();
            this.Hide();
            ventana.Show();
        }
    }
}
