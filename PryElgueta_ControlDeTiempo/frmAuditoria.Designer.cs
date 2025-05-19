namespace PryElgueta_ControlDeTiempo
{
    partial class frmAuditoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAuditar = new System.Windows.Forms.Button();
            this.panelTrabajo = new System.Windows.Forms.Panel();
            this.lstCoordenadas = new System.Windows.Forms.ListBox();
            this.lblTiempoTrabajo = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblCoordenadas = new System.Windows.Forms.Label();
            this.lblLugares = new System.Windows.Forms.Label();
            this.timerTiempoTrabajo = new System.Windows.Forms.Timer(this.components);
            this.panelTrabajo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAuditar
            // 
            this.btnAuditar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAuditar.Location = new System.Drawing.Point(319, 398);
            this.btnAuditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAuditar.Name = "btnAuditar";
            this.btnAuditar.Size = new System.Drawing.Size(107, 28);
            this.btnAuditar.TabIndex = 0;
            this.btnAuditar.Text = "Auditar";
            this.btnAuditar.UseVisualStyleBackColor = false;
            this.btnAuditar.Click += new System.EventHandler(this.btnAuditar_Click);
            // 
            // panelTrabajo
            // 
            this.panelTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTrabajo.Controls.Add(this.lstCoordenadas);
            this.panelTrabajo.Location = new System.Drawing.Point(74, 24);
            this.panelTrabajo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTrabajo.Name = "panelTrabajo";
            this.panelTrabajo.Size = new System.Drawing.Size(353, 298);
            this.panelTrabajo.TabIndex = 1;
            this.panelTrabajo.MouseLeave += new System.EventHandler(this.panelTrabajo_MouseLeave);
            this.panelTrabajo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTrabajo_MouseMove);
            // 
            // lstCoordenadas
            // 
            this.lstCoordenadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCoordenadas.FormattingEnabled = true;
            this.lstCoordenadas.Location = new System.Drawing.Point(0, 0);
            this.lstCoordenadas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCoordenadas.MultiColumn = true;
            this.lstCoordenadas.Name = "lstCoordenadas";
            this.lstCoordenadas.Size = new System.Drawing.Size(351, 296);
            this.lstCoordenadas.TabIndex = 0;
            this.lstCoordenadas.Visible = false;
            // 
            // lblTiempoTrabajo
            // 
            this.lblTiempoTrabajo.AutoSize = true;
            this.lblTiempoTrabajo.Location = new System.Drawing.Point(71, 342);
            this.lblTiempoTrabajo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiempoTrabajo.Name = "lblTiempoTrabajo";
            this.lblTiempoTrabajo.Size = new System.Drawing.Size(80, 13);
            this.lblTiempoTrabajo.TabIndex = 2;
            this.lblTiempoTrabajo.Text = "Tiempo trabajo:";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(162, 342);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(10, 13);
            this.lblTiempo.TabIndex = 3;
            this.lblTiempo.Text = "-";
            // 
            // lblCoordenadas
            // 
            this.lblCoordenadas.AutoSize = true;
            this.lblCoordenadas.Location = new System.Drawing.Point(162, 376);
            this.lblCoordenadas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoordenadas.Name = "lblCoordenadas";
            this.lblCoordenadas.Size = new System.Drawing.Size(10, 13);
            this.lblCoordenadas.TabIndex = 5;
            this.lblCoordenadas.Text = "-";
            // 
            // lblLugares
            // 
            this.lblLugares.AutoSize = true;
            this.lblLugares.Location = new System.Drawing.Point(71, 376);
            this.lblLugares.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLugares.Name = "lblLugares";
            this.lblLugares.Size = new System.Drawing.Size(48, 13);
            this.lblLugares.TabIndex = 4;
            this.lblLugares.Text = "Lugares:";
            // 
            // timerTiempoTrabajo
            // 
            this.timerTiempoTrabajo.Tick += new System.EventHandler(this.timerTiempoTrabajo_Tick);
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 436);
            this.Controls.Add(this.lblCoordenadas);
            this.Controls.Add(this.lblLugares);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblTiempoTrabajo);
            this.Controls.Add(this.panelTrabajo);
            this.Controls.Add(this.btnAuditar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAuditoria";
            this.Load += new System.EventHandler(this.frmAuditoria_Load);
            this.panelTrabajo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuditar;
        private System.Windows.Forms.Panel panelTrabajo;
        private System.Windows.Forms.Label lblTiempoTrabajo;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblCoordenadas;
        private System.Windows.Forms.Label lblLugares;
        private System.Windows.Forms.Timer timerTiempoTrabajo;
        private System.Windows.Forms.ListBox lstCoordenadas;
    }
}