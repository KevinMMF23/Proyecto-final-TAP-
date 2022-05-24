namespace MenuDeTodo
{
    partial class MenuDeTodo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.internasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDomicilioDistintoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarTiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(287, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "KM";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.internasToolStripMenuItem,
            this.internasToolStripMenuItem1,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // internasToolStripMenuItem
            // 
            this.internasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.presentacionToolStripMenuItem,
            this.tablaToolStripMenuItem,
            this.graficaToolStripMenuItem});
            this.internasToolStripMenuItem.Name = "internasToolStripMenuItem";
            this.internasToolStripMenuItem.Size = new System.Drawing.Size(169, 20);
            this.internasToolStripMenuItem.Text = "Menu de proyectos externos";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.registroToolStripMenuItem.Text = "Registro";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // presentacionToolStripMenuItem
            // 
            this.presentacionToolStripMenuItem.Name = "presentacionToolStripMenuItem";
            this.presentacionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.presentacionToolStripMenuItem.Text = "Presentacion";
            this.presentacionToolStripMenuItem.Click += new System.EventHandler(this.presentacionToolStripMenuItem_Click);
            // 
            // tablaToolStripMenuItem
            // 
            this.tablaToolStripMenuItem.Name = "tablaToolStripMenuItem";
            this.tablaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.tablaToolStripMenuItem.Text = "Tabla";
            this.tablaToolStripMenuItem.Click += new System.EventHandler(this.tablaToolStripMenuItem_Click);
            // 
            // graficaToolStripMenuItem
            // 
            this.graficaToolStripMenuItem.Name = "graficaToolStripMenuItem";
            this.graficaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.graficaToolStripMenuItem.Text = "Grafica";
            this.graficaToolStripMenuItem.Click += new System.EventHandler(this.graficaToolStripMenuItem_Click);
            // 
            // internasToolStripMenuItem1
            // 
            this.internasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevoUsuarioToolStripMenuItem,
            this.registrarDomicilioDistintoToolStripMenuItem});
            this.internasToolStripMenuItem1.Name = "internasToolStripMenuItem1";
            this.internasToolStripMenuItem1.Size = new System.Drawing.Size(167, 20);
            this.internasToolStripMenuItem1.Text = "Menu de proyectos internos";
            this.internasToolStripMenuItem1.Click += new System.EventHandler(this.internasToolStripMenuItem1_Click);
            // 
            // registrarNuevoUsuarioToolStripMenuItem
            // 
            this.registrarNuevoUsuarioToolStripMenuItem.Name = "registrarNuevoUsuarioToolStripMenuItem";
            this.registrarNuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.registrarNuevoUsuarioToolStripMenuItem.Text = "Registrar usuario distinto";
            this.registrarNuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoUsuarioToolStripMenuItem_Click);
            // 
            // registrarDomicilioDistintoToolStripMenuItem
            // 
            this.registrarDomicilioDistintoToolStripMenuItem.Name = "registrarDomicilioDistintoToolStripMenuItem";
            this.registrarDomicilioDistintoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.registrarDomicilioDistintoToolStripMenuItem.Text = "Registrar domicilio distinto";
            this.registrarDomicilioDistintoToolStripMenuItem.Click += new System.EventHandler(this.registrarDomicilioDistintoToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarTiendaToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // cerrarTiendaToolStripMenuItem
            // 
            this.cerrarTiendaToolStripMenuItem.Name = "cerrarTiendaToolStripMenuItem";
            this.cerrarTiendaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerrarTiendaToolStripMenuItem.Text = "Cerrar tienda";
            this.cerrarTiendaToolStripMenuItem.Click += new System.EventHandler(this.cerrarTiendaToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuDeTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MenuDeTodo.Properties.Resources.Imagen_para_menu_de_todo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuDeTodo";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuDeTodo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem internasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presentacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarDomicilioDistintoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarTiendaToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

