namespace WinFormsAppPractica.Formularios
{
    partial class frmCambiarPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarPassword));
            buttonPasswordAceptar = new Button();
            buttonPasswordCancelar = new Button();
            labelPasswordNuevo = new Label();
            labelPasswordConfirmar = new Label();
            txtConstrsenaActual = new TextBox();
            txtConfirmarContrasenaNueva = new TextBox();
            labelContrasenaActual = new Label();
            txtConstranaActual = new TextBox();
            groupBox1 = new GroupBox();
            chkMostrarContrasena = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonPasswordAceptar
            // 
            buttonPasswordAceptar.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPasswordAceptar.ForeColor = Color.Green;
            buttonPasswordAceptar.Location = new Point(70, 277);
            buttonPasswordAceptar.Name = "buttonPasswordAceptar";
            buttonPasswordAceptar.Size = new Size(158, 49);
            buttonPasswordAceptar.TabIndex = 0;
            buttonPasswordAceptar.Text = "Aceptar";
            buttonPasswordAceptar.UseVisualStyleBackColor = true;
            buttonPasswordAceptar.Click += button1_Click;
            // 
            // buttonPasswordCancelar
            // 
            buttonPasswordCancelar.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPasswordCancelar.ForeColor = Color.Red;
            buttonPasswordCancelar.Location = new Point(576, 277);
            buttonPasswordCancelar.Name = "buttonPasswordCancelar";
            buttonPasswordCancelar.Size = new Size(158, 49);
            buttonPasswordCancelar.TabIndex = 1;
            buttonPasswordCancelar.Text = "Cancelar";
            buttonPasswordCancelar.UseVisualStyleBackColor = true;
            buttonPasswordCancelar.Click += buttonPasswordCancelar_Click;
            // 
            // labelPasswordNuevo
            // 
            labelPasswordNuevo.AutoSize = true;
            labelPasswordNuevo.BackColor = SystemColors.ControlDark;
            labelPasswordNuevo.Location = new Point(25, 92);
            labelPasswordNuevo.Name = "labelPasswordNuevo";
            labelPasswordNuevo.Size = new Size(318, 23);
            labelPasswordNuevo.TabIndex = 2;
            labelPasswordNuevo.Text = "Escriba Su Nueva Contraseña";
            labelPasswordNuevo.Click += labelPasswordNuevo_Click;
            // 
            // labelPasswordConfirmar
            // 
            labelPasswordConfirmar.AutoSize = true;
            labelPasswordConfirmar.BackColor = SystemColors.ControlDark;
            labelPasswordConfirmar.Location = new Point(25, 149);
            labelPasswordConfirmar.Name = "labelPasswordConfirmar";
            labelPasswordConfirmar.Size = new Size(337, 23);
            labelPasswordConfirmar.TabIndex = 3;
            labelPasswordConfirmar.Text = "Confirme Su Nueva Contraseña";
            // 
            // txtConstrsenaActual
            // 
            txtConstrsenaActual.BackColor = SystemColors.Info;
            txtConstrsenaActual.Location = new Point(383, 89);
            txtConstrsenaActual.Name = "txtConstrsenaActual";
            txtConstrsenaActual.Size = new Size(351, 31);
            txtConstrsenaActual.TabIndex = 4;
            txtConstrsenaActual.UseSystemPasswordChar = true;
            // 
            // txtConfirmarContrasenaNueva
            // 
            txtConfirmarContrasenaNueva.BackColor = SystemColors.Info;
            txtConfirmarContrasenaNueva.Location = new Point(383, 146);
            txtConfirmarContrasenaNueva.Name = "txtConfirmarContrasenaNueva";
            txtConfirmarContrasenaNueva.Size = new Size(351, 31);
            txtConfirmarContrasenaNueva.TabIndex = 5;
            txtConfirmarContrasenaNueva.UseSystemPasswordChar = true;
            // 
            // labelContrasenaActual
            // 
            labelContrasenaActual.AutoSize = true;
            labelContrasenaActual.BackColor = SystemColors.ControlDark;
            labelContrasenaActual.Location = new Point(25, 41);
            labelContrasenaActual.Name = "labelContrasenaActual";
            labelContrasenaActual.Size = new Size(203, 23);
            labelContrasenaActual.TabIndex = 6;
            labelContrasenaActual.Text = "Contraseña Actual";
            // 
            // txtConstranaActual
            // 
            txtConstranaActual.BackColor = SystemColors.Info;
            txtConstranaActual.Location = new Point(383, 33);
            txtConstranaActual.Name = "txtConstranaActual";
            txtConstranaActual.Size = new Size(351, 31);
            txtConstranaActual.TabIndex = 7;
            txtConstranaActual.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkMostrarContrasena);
            groupBox1.Controls.Add(labelContrasenaActual);
            groupBox1.Controls.Add(txtConstranaActual);
            groupBox1.Controls.Add(buttonPasswordAceptar);
            groupBox1.Controls.Add(buttonPasswordCancelar);
            groupBox1.Controls.Add(txtConfirmarContrasenaNueva);
            groupBox1.Controls.Add(labelPasswordNuevo);
            groupBox1.Controls.Add(txtConstrsenaActual);
            groupBox1.Controls.Add(labelPasswordConfirmar);
            groupBox1.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(762, 371);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cambiar Contraseña";
            // 
            // chkMostrarContrasena
            // 
            chkMostrarContrasena.AutoSize = true;
            chkMostrarContrasena.Location = new Point(383, 194);
            chkMostrarContrasena.Name = "chkMostrarContrasena";
            chkMostrarContrasena.Size = new Size(241, 27);
            chkMostrarContrasena.TabIndex = 8;
            chkMostrarContrasena.Text = "Mostrar Contraseña";
            chkMostrarContrasena.UseVisualStyleBackColor = true;
            chkMostrarContrasena.CheckedChanged += chkMostrarContrasena_CheckedChanged;
            // 
            // frmCambiarPassword
            // 
            AcceptButton = buttonPasswordAceptar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            CancelButton = buttonPasswordCancelar;
            ClientSize = new Size(786, 395);
            ControlBox = false;
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCambiarPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cambiar Contraseña";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private void buttonPasswordCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; //le asigna el dialogo que se presione cancel
            Close(); //cerrar ventana
        }

        #endregion

        private Button buttonPasswordAceptar;
        private Button buttonPasswordCancelar;
        private Label labelPasswordNuevo;
        private Label labelPasswordConfirmar;
        private Label labelContrasenaActual;
        private GroupBox groupBox1;
        public TextBox txtConfirmarContrasenaNueva;
        public TextBox txtConstranaActual;
        private CheckBox chkMostrarContrasena;
        public TextBox txtConstrsenaActual;
    }
}