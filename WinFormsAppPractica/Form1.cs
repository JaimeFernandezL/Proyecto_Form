using Microsoft.VisualBasic;
using WinFormsAppPractica.Formularios;

namespace WinFormsAppPractica
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir del sistema", "Advertencia",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }

        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCambiarPassword frmCambiarContraseña = new frmCambiarPassword();
            //frmCambiarContraseña.MdiParent = this; //para que se muestre adentro del frm principal
            frmCambiarContraseña.StartPosition = FormStartPosition.CenterParent;//Sale centralizada
            if (frmCambiarContraseña.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(frmCambiarContraseña.txtConfirmarContrasenaNueva.Text);

            }
            if (frmCambiarContraseña.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Cambio de contraseña cancelado", "Información", MessageBoxButtons.OK);
            }
            frmCambiarContraseña.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir del sistema?", "Advertencia", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void dialogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDialogos dialogo = new frmDialogos();
            dialogo.MdiParent = this;  
            dialogo.StartPosition = FormStartPosition.CenterParent;
            dialogo.Show();
            
        }
    }
}
