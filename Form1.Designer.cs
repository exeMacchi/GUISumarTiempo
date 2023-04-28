namespace CalcularTiempo
{
    partial class frmPrincipal
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
            this.tbHoras = new System.Windows.Forms.TextBox();
            this.tbMinutos = new System.Windows.Forms.TextBox();
            this.tbSegundos = new System.Windows.Forms.TextBox();
            this.lbDosPuntos1 = new System.Windows.Forms.Label();
            this.lbDosPuntos2 = new System.Windows.Forms.Label();
            this.lbHoras = new System.Windows.Forms.Label();
            this.lbMinutos = new System.Windows.Forms.Label();
            this.lbSegundos = new System.Windows.Forms.Label();
            this.lbDosPuntos3 = new System.Windows.Forms.Label();
            this.lbDosPuntos4 = new System.Windows.Forms.Label();
            this.btSumar = new System.Windows.Forms.Button();
            this.lbTiempoTotal = new System.Windows.Forms.Label();
            this.lbSumarTiempo = new System.Windows.Forms.Label();
            this.btResetear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbHoras
            // 
            this.tbHoras.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoras.Location = new System.Drawing.Point(16, 37);
            this.tbHoras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbHoras.MaxLength = 2;
            this.tbHoras.Name = "tbHoras";
            this.tbHoras.Size = new System.Drawing.Size(29, 31);
            this.tbHoras.TabIndex = 0;
            this.tbHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHoras_KeyPress);
            // 
            // tbMinutos
            // 
            this.tbMinutos.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinutos.Location = new System.Drawing.Point(65, 37);
            this.tbMinutos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMinutos.MaxLength = 2;
            this.tbMinutos.Name = "tbMinutos";
            this.tbMinutos.Size = new System.Drawing.Size(29, 31);
            this.tbMinutos.TabIndex = 1;
            this.tbMinutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinutos_KeyPress);
            // 
            // tbSegundos
            // 
            this.tbSegundos.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSegundos.Location = new System.Drawing.Point(112, 37);
            this.tbSegundos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSegundos.MaxLength = 2;
            this.tbSegundos.Name = "tbSegundos";
            this.tbSegundos.Size = new System.Drawing.Size(29, 31);
            this.tbSegundos.TabIndex = 2;
            this.tbSegundos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSegundos_KeyPress);
            // 
            // lbDosPuntos1
            // 
            this.lbDosPuntos1.AutoSize = true;
            this.lbDosPuntos1.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDosPuntos1.Location = new System.Drawing.Point(48, 42);
            this.lbDosPuntos1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDosPuntos1.Name = "lbDosPuntos1";
            this.lbDosPuntos1.Size = new System.Drawing.Size(16, 18);
            this.lbDosPuntos1.TabIndex = 3;
            this.lbDosPuntos1.Text = ":";
            // 
            // lbDosPuntos2
            // 
            this.lbDosPuntos2.AutoSize = true;
            this.lbDosPuntos2.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDosPuntos2.Location = new System.Drawing.Point(95, 42);
            this.lbDosPuntos2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDosPuntos2.Name = "lbDosPuntos2";
            this.lbDosPuntos2.Size = new System.Drawing.Size(16, 18);
            this.lbDosPuntos2.TabIndex = 4;
            this.lbDosPuntos2.Text = ":";
            // 
            // lbHoras
            // 
            this.lbHoras.AutoSize = true;
            this.lbHoras.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoras.Location = new System.Drawing.Point(14, 116);
            this.lbHoras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHoras.Name = "lbHoras";
            this.lbHoras.Size = new System.Drawing.Size(39, 29);
            this.lbHoras.TabIndex = 5;
            this.lbHoras.Text = "60";
            // 
            // lbMinutos
            // 
            this.lbMinutos.AutoSize = true;
            this.lbMinutos.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinutos.Location = new System.Drawing.Point(63, 116);
            this.lbMinutos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMinutos.Name = "lbMinutos";
            this.lbMinutos.Size = new System.Drawing.Size(39, 29);
            this.lbMinutos.TabIndex = 6;
            this.lbMinutos.Text = "60";
            // 
            // lbSegundos
            // 
            this.lbSegundos.AutoSize = true;
            this.lbSegundos.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSegundos.Location = new System.Drawing.Point(113, 116);
            this.lbSegundos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSegundos.Name = "lbSegundos";
            this.lbSegundos.Size = new System.Drawing.Size(39, 29);
            this.lbSegundos.TabIndex = 7;
            this.lbSegundos.Text = "60";
            // 
            // lbDosPuntos3
            // 
            this.lbDosPuntos3.AutoSize = true;
            this.lbDosPuntos3.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDosPuntos3.Location = new System.Drawing.Point(45, 116);
            this.lbDosPuntos3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDosPuntos3.Name = "lbDosPuntos3";
            this.lbDosPuntos3.Size = new System.Drawing.Size(24, 27);
            this.lbDosPuntos3.TabIndex = 8;
            this.lbDosPuntos3.Text = ":";
            // 
            // lbDosPuntos4
            // 
            this.lbDosPuntos4.AutoSize = true;
            this.lbDosPuntos4.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDosPuntos4.Location = new System.Drawing.Point(94, 116);
            this.lbDosPuntos4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDosPuntos4.Name = "lbDosPuntos4";
            this.lbDosPuntos4.Size = new System.Drawing.Size(24, 27);
            this.lbDosPuntos4.TabIndex = 9;
            this.lbDosPuntos4.Text = ":";
            // 
            // btSumar
            // 
            this.btSumar.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSumar.Location = new System.Drawing.Point(162, 37);
            this.btSumar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSumar.Name = "btSumar";
            this.btSumar.Size = new System.Drawing.Size(101, 30);
            this.btSumar.TabIndex = 3;
            this.btSumar.Text = "Sumar";
            this.btSumar.UseVisualStyleBackColor = true;
            this.btSumar.Click += new System.EventHandler(this.btSumar_Click);
            // 
            // lbTiempoTotal
            // 
            this.lbTiempoTotal.AutoSize = true;
            this.lbTiempoTotal.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiempoTotal.Location = new System.Drawing.Point(11, 94);
            this.lbTiempoTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTiempoTotal.Name = "lbTiempoTotal";
            this.lbTiempoTotal.Size = new System.Drawing.Size(144, 25);
            this.lbTiempoTotal.TabIndex = 11;
            this.lbTiempoTotal.Text = "Tiempo total";
            // 
            // lbSumarTiempo
            // 
            this.lbSumarTiempo.AutoSize = true;
            this.lbSumarTiempo.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumarTiempo.Location = new System.Drawing.Point(10, 7);
            this.lbSumarTiempo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSumarTiempo.Name = "lbSumarTiempo";
            this.lbSumarTiempo.Size = new System.Drawing.Size(144, 25);
            this.lbSumarTiempo.TabIndex = 12;
            this.lbSumarTiempo.Text = "Sumar tiempo";
            // 
            // btResetear
            // 
            this.btResetear.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetear.Location = new System.Drawing.Point(162, 111);
            this.btResetear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btResetear.Name = "btResetear";
            this.btResetear.Size = new System.Drawing.Size(101, 32);
            this.btResetear.TabIndex = 4;
            this.btResetear.Text = "Reset";
            this.btResetear.UseVisualStyleBackColor = true;
            this.btResetear.Click += new System.EventHandler(this.btResetear_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 170);
            this.Controls.Add(this.btResetear);
            this.Controls.Add(this.lbSumarTiempo);
            this.Controls.Add(this.lbTiempoTotal);
            this.Controls.Add(this.btSumar);
            this.Controls.Add(this.lbDosPuntos4);
            this.Controls.Add(this.lbDosPuntos3);
            this.Controls.Add(this.lbSegundos);
            this.Controls.Add(this.lbMinutos);
            this.Controls.Add(this.lbHoras);
            this.Controls.Add(this.lbDosPuntos2);
            this.Controls.Add(this.lbDosPuntos1);
            this.Controls.Add(this.tbSegundos);
            this.Controls.Add(this.tbMinutos);
            this.Controls.Add(this.tbHoras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular tiempo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHoras;
        private System.Windows.Forms.TextBox tbMinutos;
        private System.Windows.Forms.TextBox tbSegundos;
        private System.Windows.Forms.Label lbDosPuntos1;
        private System.Windows.Forms.Label lbDosPuntos2;
        private System.Windows.Forms.Label lbHoras;
        private System.Windows.Forms.Label lbMinutos;
        private System.Windows.Forms.Label lbSegundos;
        private System.Windows.Forms.Label lbDosPuntos3;
        private System.Windows.Forms.Label lbDosPuntos4;
        private System.Windows.Forms.Button btSumar;
        private System.Windows.Forms.Label lbTiempoTotal;
        private System.Windows.Forms.Label lbSumarTiempo;
        private System.Windows.Forms.Button btResetear;
    }
}

