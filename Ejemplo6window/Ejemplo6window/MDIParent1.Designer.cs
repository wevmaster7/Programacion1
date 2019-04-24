namespace Ejemplo6window
{
    partial class MDIParent1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejerciciosHechosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem,
            this.ejerciciosHechosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventanaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ventanaToolStripMenuItem.Text = "ventana";
            this.ventanaToolStripMenuItem.Click += new System.EventHandler(this.ventanaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ejerciciosHechosToolStripMenuItem
            // 
            this.ejerciciosHechosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejemplo1ToolStripMenuItem,
            this.ejemplo2ToolStripMenuItem});
            this.ejerciciosHechosToolStripMenuItem.Name = "ejerciciosHechosToolStripMenuItem";
            this.ejerciciosHechosToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.ejerciciosHechosToolStripMenuItem.Text = "Ejercicios Hechos";
            // 
            // ejemplo1ToolStripMenuItem
            // 
            this.ejemplo1ToolStripMenuItem.Name = "ejemplo1ToolStripMenuItem";
            this.ejemplo1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ejemplo1ToolStripMenuItem.Text = "ejemplo1";
            this.ejemplo1ToolStripMenuItem.Click += new System.EventHandler(this.ejemplo1ToolStripMenuItem_Click);
            // 
            // ejemplo2ToolStripMenuItem
            // 
            this.ejemplo2ToolStripMenuItem.Name = "ejemplo2ToolStripMenuItem";
            this.ejemplo2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ejemplo2ToolStripMenuItem.Text = "ejemplo2";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosHechosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplo2ToolStripMenuItem;
    }
}



