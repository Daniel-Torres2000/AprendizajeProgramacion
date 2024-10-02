using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poo_OperacionesBasicas
{
    public partial class Aplicacion : Form
    {
        static Ccompuestas instancia = new Ccompuestas();
        public Aplicacion()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            Txtn1.Clear();
            Txtn2.Clear();
            TxtResultado.Clear();
        }
        private void Suma_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = Convert.ToString(Convert.ToDouble(instancia.Suma(Convert.ToDouble(Txtn1.Text), Convert.ToDouble(Txtn2.Text))));
        }

        private void Resta_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = Convert.ToString(Convert.ToDouble(instancia.Resta(Convert.ToDouble(Txtn1.Text), Convert.ToDouble(Txtn2.Text))));
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = Convert.ToString(Convert.ToInt32(instancia.Multiplicacion(Convert.ToInt32(Txtn1.Text), Convert.ToInt32(Txtn2.Text))));
        }

        private void Divi_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = Convert.ToString(Convert.ToDouble(instancia.Division(Convert.ToDouble(Txtn1.Text), Convert.ToDouble(Txtn2.Text))));
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
