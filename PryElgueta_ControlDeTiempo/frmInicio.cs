using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryElgueta_ControlDeTiempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int tiempo = 0;
        private void btnTrabajo_Click(object sender, EventArgs e)
        {
            if (btnTrabajo.Text == "Trabajo")
            {
                tiempoSesion.Enabled = true;
                btnTrabajo.Text = "Finalizar";
            }
            else
            {
                tiempoSesion.Enabled = false;
                tiempo = 0;
                btnTrabajo.Text = "Trabajo";
            }
            cambiarColorBoton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            cambiarColorBoton();
        }

        private void tiempoSesion_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = (tiempo++).ToString();
        }

        public void cambiarColorBoton()
        {
            if (btnTrabajo.Text == "Trabajo")
                btnTrabajo.BackColor = Color.Green;
            else
                btnTrabajo.BackColor = Color.Red;
        }
    }
}
