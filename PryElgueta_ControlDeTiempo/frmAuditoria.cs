using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryElgueta_ControlDeTiempo
{
    public partial class frmAuditoria : Form
    {
        public frmAuditoria()
        {
            InitializeComponent();
        }

        int tiempoTrabajo = 0;
        clsConexionBBDD conexion = new clsConexionBBDD();

        private void frmAuditoria_Load(object sender, EventArgs e)
        {

        }

        private void timerTiempoTrabajo_Tick(object sender, EventArgs e)
        {
            tiempoTrabajo++;
            lblTiempo.Text = tiempoTrabajo.ToString();
        }

        private void btnAuditar_Click(object sender, EventArgs e)
        {
            if (btnAuditar.Text == "Auditar")
            {
                lstCoordenadas.Visible = true; btnAuditar.Text = "Volver a Trabajo";
                panelTrabajo.Enabled = false;

                lstCoordenadas.Items.Clear();
                lstCoordenadas.Items.Add("20 COORDENADAS MÁS REGISTRADAS:");
                lstCoordenadas.Items.Add("-------------------------------------------------------------------------------");

                conexion.mostrarCoordenadas(lstCoordenadas);
            } 
            else
            {
                lstCoordenadas.Visible = false; btnAuditar.Text = "Auditar";
                panelTrabajo.Enabled = true;
            }
        }

        private void panelTrabajo_MouseLeave(object sender, EventArgs e)
        {
            timerTiempoTrabajo.Enabled = false;
        }

        private void panelTrabajo_MouseMove(object sender, MouseEventArgs e)
        {
            timerTiempoTrabajo.Enabled = true;
            
            string coordenadasXY = e.Location.ToString();
            
            lblCoordenadas.Text = coordenadasXY;

            conexion.guardarCoordenadas(coordenadasXY);
        }
    }
}
