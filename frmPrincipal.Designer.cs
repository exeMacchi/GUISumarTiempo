﻿namespace CalcularTiempo
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
            this.btnSumar = new System.Windows.Forms.Button();
            this.lbTiempoTotal = new System.Windows.Forms.Label();
            this.lbSumarTiempo = new System.Windows.Forms.Label();
            this.btResetear = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.lviewHistorial = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // tbHoras
            // 
            this.tbHoras.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoras.Location = new System.Drawing.Point(32, 50);
            this.tbHoras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHoras.MaxLength = 2;
            this.tbHoras.Name = "tbHoras";
            this.tbHoras.Size = new System.Drawing.Size(37, 37);
            this.tbHoras.TabIndex = 0;
            this.tbHoras.TextChanged += new System.EventHandler(this.tbHoras_TextChanged);
            this.tbHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHoras_KeyPress);
            this.tbHoras.Leave += new System.EventHandler(this.tbHoras_Leave);
            // 
            // tbMinutos
            // 
            this.tbMinutos.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinutos.Location = new System.Drawing.Point(97, 50);
            this.tbMinutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMinutos.MaxLength = 2;
            this.tbMinutos.Name = "tbMinutos";
            this.tbMinutos.Size = new System.Drawing.Size(37, 37);
            this.tbMinutos.TabIndex = 1;
            this.tbMinutos.TextChanged += new System.EventHandler(this.tbMinutos_TextChanged);
            this.tbMinutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinutos_KeyPress);
            this.tbMinutos.Leave += new System.EventHandler(this.tbMinutos_Leave);
            // 
            // tbSegundos
            // 
            this.tbSegundos.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSegundos.Location = new System.Drawing.Point(160, 50);
            this.tbSegundos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSegundos.MaxLength = 2;
            this.tbSegundos.Name = "tbSegundos";
            this.tbSegundos.Size = new System.Drawing.Size(37, 37);
            this.tbSegundos.TabIndex = 2;
            this.tbSegundos.TextChanged += new System.EventHandler(this.tbSegundos_TextChanged);
            this.tbSegundos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSegundos_KeyPress);
            this.tbSegundos.Leave += new System.EventHandler(this.tbSegundos_Leave);
            // 
            // lbDosPuntos1
            // 
            this.lbDosPuntos1.AutoSize = true;
            this.lbDosPuntos1.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDosPuntos1.Location = new System.Drawing.Point(75, 57);
            this.lbDosPuntos1.Name = "lbDosPuntos1";
            this.lbDosPuntos1.Size = new System.Drawing.Size(20, 22);
            this.lbDosPuntos1.TabIndex = 3;
            this.lbDosPuntos1.Text = ":";
            // 
            // lbDosPuntos2
            // 
            this.lbDosPuntos2.AutoSize = true;
            this.lbDosPuntos2.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDosPuntos2.Location = new System.Drawing.Point(137, 57);
            this.lbDosPuntos2.Name = "lbDosPuntos2";
            this.lbDosPuntos2.Size = new System.Drawing.Size(20, 22);
            this.lbDosPuntos2.TabIndex = 4;
            this.lbDosPuntos2.Text = ":";
            // 
            // lbHoras
            // 
            this.lbHoras.AutoSize = true;
            this.lbHoras.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoras.Location = new System.Drawing.Point(27, 222);
            this.lbHoras.Name = "lbHoras";
            this.lbHoras.Size = new System.Drawing.Size(49, 37);
            this.lbHoras.TabIndex = 5;
            this.lbHoras.Text = "60";
            // 
            // lbMinutos
            // 
            this.lbMinutos.AutoSize = true;
            this.lbMinutos.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinutos.Location = new System.Drawing.Point(92, 222);
            this.lbMinutos.Name = "lbMinutos";
            this.lbMinutos.Size = new System.Drawing.Size(49, 37);
            this.lbMinutos.TabIndex = 6;
            this.lbMinutos.Text = "60";
            // 
            // lbSegundos
            // 
            this.lbSegundos.AutoSize = true;
            this.lbSegundos.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSegundos.Location = new System.Drawing.Point(159, 222);
            this.lbSegundos.Name = "lbSegundos";
            this.lbSegundos.Size = new System.Drawing.Size(49, 37);
            this.lbSegundos.TabIndex = 7;
            this.lbSegundos.Text = "60";
            // 
            // lbDosPuntos3
            // 
            this.lbDosPuntos3.AutoSize = true;
            this.lbDosPuntos3.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDosPuntos3.Location = new System.Drawing.Point(68, 222);
            this.lbDosPuntos3.Name = "lbDosPuntos3";
            this.lbDosPuntos3.Size = new System.Drawing.Size(30, 33);
            this.lbDosPuntos3.TabIndex = 8;
            this.lbDosPuntos3.Text = ":";
            // 
            // lbDosPuntos4
            // 
            this.lbDosPuntos4.AutoSize = true;
            this.lbDosPuntos4.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDosPuntos4.Location = new System.Drawing.Point(133, 222);
            this.lbDosPuntos4.Name = "lbDosPuntos4";
            this.lbDosPuntos4.Size = new System.Drawing.Size(30, 33);
            this.lbDosPuntos4.TabIndex = 9;
            this.lbDosPuntos4.Text = ":";
            // 
            // btnSumar
            // 
            this.btnSumar.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.Location = new System.Drawing.Point(31, 91);
            this.btnSumar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(167, 37);
            this.btnSumar.TabIndex = 3;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btSumar_Click);
            // 
            // lbTiempoTotal
            // 
            this.lbTiempoTotal.AutoSize = true;
            this.lbTiempoTotal.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiempoTotal.Location = new System.Drawing.Point(23, 194);
            this.lbTiempoTotal.Name = "lbTiempoTotal";
            this.lbTiempoTotal.Size = new System.Drawing.Size(182, 32);
            this.lbTiempoTotal.TabIndex = 11;
            this.lbTiempoTotal.Text = "Tiempo total";
            // 
            // lbSumarTiempo
            // 
            this.lbSumarTiempo.AutoSize = true;
            this.lbSumarTiempo.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumarTiempo.Location = new System.Drawing.Point(24, 14);
            this.lbSumarTiempo.Name = "lbSumarTiempo";
            this.lbSumarTiempo.Size = new System.Drawing.Size(182, 32);
            this.lbSumarTiempo.TabIndex = 12;
            this.lbSumarTiempo.Text = "Sumar tiempo";
            // 
            // btResetear
            // 
            this.btResetear.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetear.Location = new System.Drawing.Point(49, 260);
            this.btResetear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btResetear.Name = "btResetear";
            this.btResetear.Size = new System.Drawing.Size(135, 39);
            this.btResetear.TabIndex = 5;
            this.btResetear.Text = "Reset";
            this.btResetear.UseVisualStyleBackColor = true;
            this.btResetear.Click += new System.EventHandler(this.btResetear_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.Location = new System.Drawing.Point(32, 133);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(165, 37);
            this.btnHistorial.TabIndex = 4;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // lviewHistorial
            // 
            this.lviewHistorial.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lviewHistorial.HideSelection = false;
            this.lviewHistorial.Location = new System.Drawing.Point(239, 18);
            this.lviewHistorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lviewHistorial.Name = "lviewHistorial";
            this.lviewHistorial.Size = new System.Drawing.Size(371, 272);
            this.lviewHistorial.TabIndex = 6;
            this.lviewHistorial.UseCompatibleStateImageBehavior = false;
            this.lviewHistorial.View = System.Windows.Forms.View.List;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 302);
            this.Controls.Add(this.lviewHistorial);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btResetear);
            this.Controls.Add(this.lbSumarTiempo);
            this.Controls.Add(this.lbTiempoTotal);
            this.Controls.Add(this.btnSumar);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(647, 349);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseEnter += new System.EventHandler(this.frmPrincipal_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.frmPrincipal_MouseLeave);
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
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Label lbTiempoTotal;
        private System.Windows.Forms.Label lbSumarTiempo;
        private System.Windows.Forms.Button btResetear;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.ListView lviewHistorial;
    }
}

