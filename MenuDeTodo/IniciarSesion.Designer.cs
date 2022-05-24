namespace MenuDeTodo
{
    partial class IniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOlvidasteCorreoOContra = new System.Windows.Forms.Button();
            this.textBoxNuevoCorreo = new System.Windows.Forms.TextBox();
            this.textBoxNuevaContraseña = new System.Windows.Forms.TextBox();
            this.labelNuevoCorreo = new System.Windows.Forms.Label();
            this.labelNuevaContraseña = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnIngresar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(40, 109);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(158, 20);
            this.textBoxCorreo.TabIndex = 1;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(40, 154);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(158, 20);
            this.textBoxContraseña.TabIndex = 2;
            this.textBoxContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxContraseña_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Correo";
            // 
            // btnOlvidasteCorreoOContra
            // 
            this.btnOlvidasteCorreoOContra.BackColor = System.Drawing.Color.DimGray;
            this.btnOlvidasteCorreoOContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlvidasteCorreoOContra.ForeColor = System.Drawing.Color.White;
            this.btnOlvidasteCorreoOContra.Location = new System.Drawing.Point(12, 209);
            this.btnOlvidasteCorreoOContra.Name = "btnOlvidasteCorreoOContra";
            this.btnOlvidasteCorreoOContra.Size = new System.Drawing.Size(211, 23);
            this.btnOlvidasteCorreoOContra.TabIndex = 6;
            this.btnOlvidasteCorreoOContra.Text = "¿Olvidaste contraseña o correo?";
            this.btnOlvidasteCorreoOContra.UseVisualStyleBackColor = false;
            this.btnOlvidasteCorreoOContra.Click += new System.EventHandler(this.btnOlvidasteCorreoOContra_Click);
            // 
            // textBoxNuevoCorreo
            // 
            this.textBoxNuevoCorreo.Location = new System.Drawing.Point(40, 269);
            this.textBoxNuevoCorreo.Name = "textBoxNuevoCorreo";
            this.textBoxNuevoCorreo.Size = new System.Drawing.Size(158, 20);
            this.textBoxNuevoCorreo.TabIndex = 7;
            this.textBoxNuevoCorreo.Visible = false;
            this.textBoxNuevoCorreo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxNuevaContraseña
            // 
            this.textBoxNuevaContraseña.Location = new System.Drawing.Point(40, 308);
            this.textBoxNuevaContraseña.Name = "textBoxNuevaContraseña";
            this.textBoxNuevaContraseña.Size = new System.Drawing.Size(158, 20);
            this.textBoxNuevaContraseña.TabIndex = 8;
            this.textBoxNuevaContraseña.Visible = false;
            this.textBoxNuevaContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNuevaContraseña_KeyPress);
            // 
            // labelNuevoCorreo
            // 
            this.labelNuevoCorreo.AutoSize = true;
            this.labelNuevoCorreo.Location = new System.Drawing.Point(37, 254);
            this.labelNuevoCorreo.Name = "labelNuevoCorreo";
            this.labelNuevoCorreo.Size = new System.Drawing.Size(73, 13);
            this.labelNuevoCorreo.TabIndex = 9;
            this.labelNuevoCorreo.Text = "Nuevo Correo";
            this.labelNuevoCorreo.Visible = false;
            // 
            // labelNuevaContraseña
            // 
            this.labelNuevaContraseña.AutoSize = true;
            this.labelNuevaContraseña.Location = new System.Drawing.Point(37, 292);
            this.labelNuevaContraseña.Name = "labelNuevaContraseña";
            this.labelNuevaContraseña.Size = new System.Drawing.Size(96, 13);
            this.labelNuevaContraseña.TabIndex = 10;
            this.labelNuevaContraseña.Text = "Nueva Contraseña";
            this.labelNuevaContraseña.Visible = false;
            this.labelNuevaContraseña.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.DimGray;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(84, 180);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(64, 23);
            this.btnIngresar.TabIndex = 11;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnIngresar2
            // 
            this.btnIngresar2.BackColor = System.Drawing.Color.DimGray;
            this.btnIngresar2.FlatAppearance.BorderSize = 0;
            this.btnIngresar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar2.ForeColor = System.Drawing.Color.White;
            this.btnIngresar2.Location = new System.Drawing.Point(84, 343);
            this.btnIngresar2.Name = "btnIngresar2";
            this.btnIngresar2.Size = new System.Drawing.Size(64, 23);
            this.btnIngresar2.TabIndex = 12;
            this.btnIngresar2.Text = "Ingresar";
            this.btnIngresar2.UseVisualStyleBackColor = false;
            this.btnIngresar2.Visible = false;
            this.btnIngresar2.Click += new System.EventHandler(this.btnIngresar2_Click);
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(252, 402);
            this.Controls.Add(this.btnIngresar2);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.labelNuevaContraseña);
            this.Controls.Add(this.labelNuevoCorreo);
            this.Controls.Add(this.textBoxNuevaContraseña);
            this.Controls.Add(this.textBoxNuevoCorreo);
            this.Controls.Add(this.btnOlvidasteCorreoOContra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "IniciarSesion";
            this.Text = "IniciarSesion";
            this.Load += new System.EventHandler(this.IniciarSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOlvidasteCorreoOContra;
        private System.Windows.Forms.TextBox textBoxNuevoCorreo;
        private System.Windows.Forms.TextBox textBoxNuevaContraseña;
        private System.Windows.Forms.Label labelNuevoCorreo;
        private System.Windows.Forms.Label labelNuevaContraseña;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnIngresar2;
    }
}