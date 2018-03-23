using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCal_Click(object sender, EventArgs e)
        {
            double Tiempo, distancia, velo;
            Tiempo = double.Parse(txtTiempo.Text);
            distancia = double.Parse(txtDis.Text);
            velo = distancia / Tiempo;
          MessageBox.Show("La velocidad es de: "+velo);

        }
    }
}
