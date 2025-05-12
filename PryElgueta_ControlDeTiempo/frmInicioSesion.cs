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
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        int tiempo = 0;
        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            cambiarColorBoton();
        }


        public void cambiarColorBoton()
        {
            if (btnTrabajo.Text == "Trabajo")
                btnTrabajo.BackColor = Color.Green;
            else
                btnTrabajo.BackColor = Color.Red;
        }

        private void btnTrabajo_Click(object sender, EventArgs e)
        {
            if (btnTrabajo.Text == "Trabajo")
            {
                tiempoSesion.Enabled = true;
                toolStripStatusLabel1.Visible = true;
                btnTrabajo.Text = "Finalizar";
            }
            else
            {
                tiempoSesion.Enabled = false;
                toolStripStatusLabel1.Visible = false;
                tiempo = 0;
                btnTrabajo.Text = "Trabajo";
            }
            cambiarColorBoton();
        }

        private void tiempoSesion_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = (tiempo++).ToString();
        }
    }
}
