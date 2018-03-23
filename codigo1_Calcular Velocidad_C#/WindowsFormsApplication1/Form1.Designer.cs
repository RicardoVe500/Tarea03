namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtCal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distancia:";
            // 
            // txtDis
            // 
            this.txtDis.Location = new System.Drawing.Point(73, 42);
            this.txtDis.Name = "txtDis";
            this.txtDis.Size = new System.Drawing.Size(100, 20);
            this.txtDis.TabIndex = 1;
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(13, 92);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(45, 13);
            this.t.TabIndex = 2;
            this.t.Text = "Tiempo:";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(73, 89);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempo.TabIndex = 3;
            // 
            // txtCal
            // 
            this.txtCal.Location = new System.Drawing.Point(16, 127);
            this.txtCal.Name = "txtCal";
            this.txtCal.Size = new System.Drawing.Size(157, 23);
            this.txtCal.TabIndex = 4;
            this.txtCal.Text = "Calcular";
            this.txtCal.UseVisualStyleBackColor = true;
            this.txtCal.Click += new System.EventHandler(this.txtCal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 172);
            this.Controls.Add(this.txtCal);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.t);
            this.Controls.Add(this.txtDis);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Button txtCal;
    }
}

