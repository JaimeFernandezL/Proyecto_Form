namespace WinFormsAppPractica.Formularios
{
    partial class frmDialogos
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
            colorDialog1 = new ColorDialog();
            txtColor = new TextBox();
            btnColor = new Button();
            btnColorFondo = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            btnCargarImagen = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtColor
            // 
            txtColor.Location = new Point(72, 34);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(253, 27);
            txtColor.TabIndex = 0;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(331, 34);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(131, 28);
            btnColor.TabIndex = 1;
            btnColor.Text = "Color";
            btnColor.UseMnemonic = false;
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnColorFondo
            // 
            btnColorFondo.Location = new Point(468, 34);
            btnColorFondo.Name = "btnColorFondo";
            btnColorFondo.Size = new Size(131, 28);
            btnColorFondo.TabIndex = 2;
            btnColorFondo.Text = "Color Fondo";
            btnColorFondo.UseMnemonic = false;
            btnColorFondo.UseVisualStyleBackColor = true;
            btnColorFondo.Click += btnColorFondo_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Imagenes | *.jpg; *.png; *.bmp";
            openFileDialog1.Title = "Selecciones Una Imagen";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(72, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.Location = new Point(468, 84);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(131, 29);
            btnCargarImagen.TabIndex = 4;
            btnCargarImagen.Text = "Cargar Imagen";
            btnCargarImagen.UseVisualStyleBackColor = true;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // frmDialogos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(733, 307);
            Controls.Add(btnCargarImagen);
            Controls.Add(pictureBox1);
            Controls.Add(btnColorFondo);
            Controls.Add(btnColor);
            Controls.Add(txtColor);
            Name = "frmDialogos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dialogos";
            Load += frmDialogos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private TextBox txtColor;
        private Button btnColor;
        private Button btnColorFondo;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button btnCargarImagen;
    }
}