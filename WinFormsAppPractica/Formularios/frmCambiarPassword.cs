using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsAppPractica.Formularios
{
    public partial class frmCambiarPassword : Form
    {
        public frmCambiarPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                DialogResult = DialogResult.OK;
                Close();

            }
        }

        private bool ValidarCampos()
        {
            if (txtConstranaActual.Text.Trim().Length == 0)
            {
                MessageBox.Show("La contraseña actual no puede estar vacia.", "ADvertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConstranaActual.Focus();
                return false;
            }
            if (txtConfirmarContrasenaNueva.Text.Trim().Length == 0)
            {
                MessageBox.Show("La contraseña nueva no puede estar vacia.", "ADvertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmarContrasenaNueva.Focus();
                return false;
            }
            if (txtConfirmarContrasenaNueva.Text != txtConstrsenaActual.Text)
            {
                MessageBox.Show("Las contraseñas nuevas no coinciden.", "ADvertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmarContrasenaNueva.Focus();
                return false;
            }
            if(!txtConfirmarContrasenaNueva.Text.Equals(txtConfirmarContrasenaNueva.Text))
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmarContrasenaNueva.Focus();
                return false;
            }
            return true;
        }
        private void labelPasswordNuevo_Click(object sender, EventArgs e)
        {


        }

        private void buttonPasswordCancelar_Click(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir ", "Advertencia",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
        }

        private void chkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMostrarContrasena.Checked)
            {
                txtConstranaActual.UseSystemPasswordChar = false;
                txtConstrsenaActual.UseSystemPasswordChar = false;
                txtConfirmarContrasenaNueva.UseSystemPasswordChar = false;
            }
            else
            {
                txtConstranaActual.UseSystemPasswordChar = true;
                txtConstrsenaActual.UseSystemPasswordChar = true;
                txtConfirmarContrasenaNueva.UseSystemPasswordChar = true;

            }
        }
    }
}
