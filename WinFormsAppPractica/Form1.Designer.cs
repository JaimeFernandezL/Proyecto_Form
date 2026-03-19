namespace WinFormsAppPractica
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            menuPrincipal = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            toolStripMenuItem6 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            cambiarContraseñaToolStripMenuItem = new ToolStripMenuItem();
            PreferenciaStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            cambiarContraseñaToolStripMenuItem1 = new ToolStripMenuItem();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            personaToolStripMenuItem = new ToolStripMenuItem();
            estudianteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            inscripcionToolStripMenuItem = new ToolStripMenuItem();
            facturacionToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            generarReporteToolStripMenuItem = new ToolStripMenuItem();
            utilitariosToolStripMenuItem = new ToolStripMenuItem();
            backupToolStripMenuItem = new ToolStripMenuItem();
            localToolStripMenuItem = new ToolStripMenuItem();
            servidorToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            cadenaDeConexionToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            verLaAyudaToolStripMenuItem = new ToolStripMenuItem();
            btnSalir = new Button();
            dialogosToolStripMenuItem = new ToolStripMenuItem();
            menuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.BackColor = SystemColors.ControlDark;
            menuPrincipal.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuPrincipal.ImageScalingSize = new Size(20, 20);
            menuPrincipal.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, sistemaToolStripMenuItem, mantenimientoToolStripMenuItem, consultasToolStripMenuItem, reportesToolStripMenuItem, utilitariosToolStripMenuItem, ayudaToolStripMenuItem });
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Padding = new Padding(7, 2, 0, 2);
            menuPrincipal.Size = new Size(1315, 28);
            menuPrincipal.TabIndex = 0;
            menuPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, guardarToolStripMenuItem, guardarComoToolStripMenuItem, toolStripMenuItem4, toolStripMenuItem6, salirToolStripMenuItem });
            archivoToolStripMenuItem.Image = (Image)resources.GetObject("archivoToolStripMenuItem.Image");
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(107, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(213, 26);
            nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(213, 26);
            abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(213, 26);
            guardarToolStripMenuItem.Text = "Guardar";
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(213, 26);
            guardarComoToolStripMenuItem.Text = "Guardar Como";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(210, 6);
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(210, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            salirToolStripMenuItem.Size = new Size(213, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cambiarContraseñaToolStripMenuItem, PreferenciaStripMenuItem, toolStripMenuItem2, cambiarContraseñaToolStripMenuItem1 });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(87, 24);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            cambiarContraseñaToolStripMenuItem.Size = new Size(258, 26);
            cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            cambiarContraseñaToolStripMenuItem.Click += cambiarContraseñaToolStripMenuItem_Click;
            // 
            // PreferenciaStripMenuItem
            // 
            PreferenciaStripMenuItem.Name = "PreferenciaStripMenuItem";
            PreferenciaStripMenuItem.Size = new Size(258, 26);
            PreferenciaStripMenuItem.Text = "Preferencia";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(255, 6);
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // cambiarContraseñaToolStripMenuItem1
            // 
            cambiarContraseñaToolStripMenuItem1.Name = "cambiarContraseñaToolStripMenuItem1";
            cambiarContraseñaToolStripMenuItem1.Size = new Size(258, 26);
            cambiarContraseñaToolStripMenuItem1.Text = "Cambiar contraseña";
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personaToolStripMenuItem, estudianteToolStripMenuItem, toolStripMenuItem1, inscripcionToolStripMenuItem, facturacionToolStripMenuItem });
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(151, 24);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // personaToolStripMenuItem
            // 
            personaToolStripMenuItem.Name = "personaToolStripMenuItem";
            personaToolStripMenuItem.Size = new Size(190, 26);
            personaToolStripMenuItem.Text = "Persona";
            // 
            // estudianteToolStripMenuItem
            // 
            estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            estudianteToolStripMenuItem.Size = new Size(190, 26);
            estudianteToolStripMenuItem.Text = "Estudiante";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(187, 6);
            // 
            // inscripcionToolStripMenuItem
            // 
            inscripcionToolStripMenuItem.Name = "inscripcionToolStripMenuItem";
            inscripcionToolStripMenuItem.Size = new Size(190, 26);
            inscripcionToolStripMenuItem.Text = "Inscripcion";
            // 
            // facturacionToolStripMenuItem
            // 
            facturacionToolStripMenuItem.Image = (Image)resources.GetObject("facturacionToolStripMenuItem.Image");
            facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            facturacionToolStripMenuItem.Size = new Size(190, 26);
            facturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buscarToolStripMenuItem });
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(107, 24);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(147, 26);
            buscarToolStripMenuItem.Text = "Buscar";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generarReporteToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(96, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // generarReporteToolStripMenuItem
            // 
            generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            generarReporteToolStripMenuItem.Size = new Size(225, 26);
            generarReporteToolStripMenuItem.Text = "Generar Reporte";
            generarReporteToolStripMenuItem.Click += generarReporteToolStripMenuItem_Click;
            // 
            // utilitariosToolStripMenuItem
            // 
            utilitariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { backupToolStripMenuItem, dialogosToolStripMenuItem });
            utilitariosToolStripMenuItem.Name = "utilitariosToolStripMenuItem";
            utilitariosToolStripMenuItem.Size = new Size(108, 24);
            utilitariosToolStripMenuItem.Text = "Utilitarios";
            // 
            // backupToolStripMenuItem
            // 
            backupToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localToolStripMenuItem, servidorToolStripMenuItem, toolStripMenuItem3, cadenaDeConexionToolStripMenuItem });
            backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            backupToolStripMenuItem.Size = new Size(224, 26);
            backupToolStripMenuItem.Text = "Backup";
            // 
            // localToolStripMenuItem
            // 
            localToolStripMenuItem.Name = "localToolStripMenuItem";
            localToolStripMenuItem.Size = new Size(264, 26);
            localToolStripMenuItem.Text = "Local";
            // 
            // servidorToolStripMenuItem
            // 
            servidorToolStripMenuItem.Name = "servidorToolStripMenuItem";
            servidorToolStripMenuItem.Size = new Size(264, 26);
            servidorToolStripMenuItem.Text = "Servidor";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(261, 6);
            // 
            // cadenaDeConexionToolStripMenuItem
            // 
            cadenaDeConexionToolStripMenuItem.Name = "cadenaDeConexionToolStripMenuItem";
            cadenaDeConexionToolStripMenuItem.Size = new Size(264, 26);
            cadenaDeConexionToolStripMenuItem.Text = "Cadena de Conexion";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verLaAyudaToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(74, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // verLaAyudaToolStripMenuItem
            // 
            verLaAyudaToolStripMenuItem.Name = "verLaAyudaToolStripMenuItem";
            verLaAyudaToolStripMenuItem.Size = new Size(193, 26);
            verLaAyudaToolStripMenuItem.Text = "Ver la ayuda";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Red;
            btnSalir.Location = new Point(1082, 417);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(198, 52);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button1_Click;
            // 
            // dialogosToolStripMenuItem
            // 
            dialogosToolStripMenuItem.Name = "dialogosToolStripMenuItem";
            dialogosToolStripMenuItem.Size = new Size(224, 26);
            dialogosToolStripMenuItem.Text = "Dialogos";
            dialogosToolStripMenuItem.Click += dialogosToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1315, 497);
            Controls.Add(btnSalir);
            Controls.Add(menuPrincipal);
            Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuPrincipal;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "P4 Soft";
            FormClosing += FrmPrincipal_FormClosing;
            Load += FrmPrincipal_Load;
            menuPrincipal.ResumeLayout(false);
            menuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem personaToolStripMenuItem;
        private ToolStripMenuItem estudianteToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem utilitariosToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem generarReporteToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem verLaAyudaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem inscripcionToolStripMenuItem;
        private ToolStripMenuItem facturacionToolStripMenuItem;
        private ToolStripMenuItem sstemaToolStripMenuItem;
        private ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem4;

        public ToolStripMenuItem PropiedadesStripMenuItem { get; private set; }

        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripMenuItem PreferenciaStripMenuItem;
        private ToolStripMenuItem backupToolStripMenuItem;
        private ToolStripMenuItem localToolStripMenuItem;
        private ToolStripMenuItem servidorToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem cadenaDeConexionToolStripMenuItem;
        private ToolStripMenuItem cambiarContraseñaToolStripMenuItem1;
        private Button btnSalir;
        private ToolStripMenuItem dialogosToolStripMenuItem;
    }
}
