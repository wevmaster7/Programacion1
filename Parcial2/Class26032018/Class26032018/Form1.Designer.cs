namespace Class26032018
{
    partial class formOperaciones
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
            this.textvalA = new System.Windows.Forms.TextBox();
            this.textvalB = new System.Windows.Forms.TextBox();
            this.lblValA = new System.Windows.Forms.Label();
            this.lblValB = new System.Windows.Forms.Label();
            this.lblResul = new System.Windows.Forms.Label();
            this.grbGrupoA = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.grbGrupoA.SuspendLayout();
            this.SuspendLayout();
            // 
            // textvalA
            // 
            this.textvalA.Location = new System.Drawing.Point(161, 55);
            this.textvalA.Name = "textvalA";
            this.textvalA.Size = new System.Drawing.Size(100, 20);
            this.textvalA.TabIndex = 0;
            // 
            // textvalB
            // 
            this.textvalB.Location = new System.Drawing.Point(161, 90);
            this.textvalB.Name = "textvalB";
            this.textvalB.Size = new System.Drawing.Size(100, 20);
            this.textvalB.TabIndex = 1;
            // 
            // lblValA
            // 
            this.lblValA.AutoSize = true;
            this.lblValA.Location = new System.Drawing.Point(78, 62);
            this.lblValA.Name = "lblValA";
            this.lblValA.Size = new System.Drawing.Size(41, 13);
            this.lblValA.TabIndex = 2;
            this.lblValA.Text = "Valor A";
            this.lblValA.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblValB
            // 
            this.lblValB.AutoSize = true;
            this.lblValB.Location = new System.Drawing.Point(78, 97);
            this.lblValB.Name = "lblValB";
            this.lblValB.Size = new System.Drawing.Size(41, 13);
            this.lblValB.TabIndex = 3;
            this.lblValB.Text = "Valor B";
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResul.Location = new System.Drawing.Point(60, 117);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(165, 30);
            this.lblResul.TabIndex = 4;
            this.lblResul.Text = "RESULTADO";
            // 
            // grbGrupoA
            // 
            this.grbGrupoA.Controls.Add(this.lblResul);
            this.grbGrupoA.Controls.Add(this.button4);
            this.grbGrupoA.Controls.Add(this.button3);
            this.grbGrupoA.Controls.Add(this.button2);
            this.grbGrupoA.Controls.Add(this.button1);
            this.grbGrupoA.Location = new System.Drawing.Point(53, 36);
            this.grbGrupoA.Name = "grbGrupoA";
            this.grbGrupoA.Size = new System.Drawing.Size(296, 231);
            this.grbGrupoA.TabIndex = 5;
            this.grbGrupoA.TabStop = false;
            this.grbGrupoA.Text = "Operaciones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Suma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Resta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(126, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "&Producto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(194, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "&División";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // formOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 317);
            this.Controls.Add(this.lblValB);
            this.Controls.Add(this.lblValA);
            this.Controls.Add(this.textvalB);
            this.Controls.Add(this.textvalA);
            this.Controls.Add(this.grbGrupoA);
            this.Name = "formOperaciones";
            this.Text = "Form1";
            this.grbGrupoA.ResumeLayout(false);
            this.grbGrupoA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textvalA;
        private System.Windows.Forms.TextBox textvalB;
        private System.Windows.Forms.Label lblValA;
        private System.Windows.Forms.Label lblValB;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.GroupBox grbGrupoA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

