using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularTiempo
{
    public partial class frmPrincipal
    {
        /// <summary>
        /// Sumar un tiempo al tiempo total.
        /// </summary>
        private void btSumar_Click(object sender, EventArgs e)
        {
            // Verificar si mínimo un TextBox es diferente a 00. Si hay un TextBox diferente
            // de 0, se suma el tiempo; si no lo hay, no se permite sumar el tiempo.
            if (!(tbHoras.Text != "00" || tbMinutos.Text != "00" || tbSegundos.Text != "00"))
            {
                ResetearTemporal();
                tbHoras.Focus();
                return;
            }
            
            // Verificar si el TextBox segundos es mayor o igual a 60. Si lo es, no se
            // permite sumar.
            int seg = int.Parse(tbSegundos.Text);
            if (seg >= 60)
            {
                MessageBox.Show("Los segundos no pueden ser mayores o iguales a 60.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSegundos.Focus();
                return;
            }

            // Verificar si el TextBox minutos es mayor o igual a 60. Si lo es, no se
            // permite sumar.
            int min = int.Parse(tbMinutos.Text);
            if (min >= 60)
            {
                MessageBox.Show("Los minutos no pueden ser mayores o iguales a 60.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMinutos.Focus();
                return;
            }

            // Convertir y sumar los tiempos al total.
            this.horas += int.Parse(tbHoras.Text);
            this.minutos += min;
            this.segundos += seg;

            // Se suma un minuto por cada 60 o más segundos acumulados.
            while (segundos >= 60)
            {
                minutos++;
                segundos -= 60;
            }

            // Se suma una hora por cada 60 o más minutos acumulados.
            while (minutos >= 60)
            {
                horas++;
                minutos -= 60;
            }

            // Estilización del historial
            if (tiempos < 10)
            {
                lviewHistorial.Items.Add($"0{tiempos}. {tbHoras.Text}:{tbMinutos.Text}:{tbSegundos.Text}");
            }
            else
            {
                lviewHistorial.Items.Add($"{tiempos}. {tbHoras.Text}:{tbMinutos.Text}:{tbSegundos.Text}");
            }

            tiempos++;
            Actualizar();
            ResetearTemporal();
            tbHoras.Focus();
        }


        /// <summary>
        /// Resetear el formulario a su configuración básica.
        /// </summary>
        private void btResetear_Click(object sender, EventArgs e)

        {
            ResetearFormulario();
        }


        /// <summary>
        /// Mostrar u ocultar el historial de tiempos sumados.
        /// </summary>
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            if (this.ClientSize.Width == 175)
            {
                this.ClientSize = new System.Drawing.Size(490, 350);
                this.Text = "Calcular tiempo";
            }
            else
            {
                this.ClientSize = new System.Drawing.Size(175, 350);
                this.Text = "";
            }
        }


        // ================================================================== //
        // ---------------------------- Validaciones ------------------------ //
        // ================================================================== //
        /// <summary>
        /// Permitir solo escribir y borrar números.
        /// </summary>
        private void tbHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Permitir solo escribir y borrar números.
        /// </summary>
        private void tbMinutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Permitir solo escribir y borrar números.
        /// </summary>
        private void tbSegundos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


        /// <summary>
        /// Validar TextBox para poder sumar.
        /// </summary>
        private void tbHoras_TextChanged(object sender, EventArgs e)
        {
            VerificarSuma();
        }
        /// <summary>
        /// Validar TextBox para poder sumar.
        /// </summary>
        private void tbMinutos_TextChanged(object sender, EventArgs e)
        {
            VerificarSuma();
        }
        /// <summary>
        /// Validar TextBox para poder sumar.
        /// </summary>
        private void tbSegundos_TextChanged(object sender, EventArgs e)
        {
            VerificarSuma();
        }


        /// <summary>
        /// Validación del <see cref="tbHoras"/> para saber si hace falta agregar uno, dos
        /// o ningún cero después de abandonar el control.
        /// </summary>
        private void tbHoras_Leave(object sender, EventArgs e)
        {
            if (tbHoras.Text == "" || tbHoras.Text == "0")
            {
                tbHoras.Text = "00";
            }
            else if (int.Parse(tbHoras.Text) < 10 && !(tbHoras.Text.Contains("0")))
            {
                tbHoras.Text = "0" + tbHoras.Text;
            }
        }
        /// <summary>
        /// Validación del <see cref="tbMinutos"/> para saber si hace falta agregar uno, dos
        /// o ningún cero después de abandonar el control.
        /// </summary>
        private void tbMinutos_Leave(object sender, EventArgs e)
        {
            if (tbMinutos.Text == "" || tbMinutos.Text == "0")
            {
                tbMinutos.Text = "00";
            }
            else if (int.Parse(tbMinutos.Text) < 10 && !(tbMinutos.Text.Contains("0")))
            {
                tbMinutos.Text = "0" + tbMinutos.Text;
            }
        }
        /// <summary>
        /// Validación del <see cref="tbSegundos"/> para saber si hace falta agregar uno, dos
        /// o ningún cero después de abandonar el control.
        /// </summary>
        private void tbSegundos_Leave(object sender, EventArgs e)
        {
            if (tbSegundos.Text == "" || tbSegundos.Text == "0")
            {
                tbSegundos.Text = "00";
            }
            else if (int.Parse(tbSegundos.Text) < 10 && !(tbSegundos.Text.Contains("0")))
            {
                tbSegundos.Text = "0" + tbSegundos.Text;
            }

            btnSumar.Enabled = true;
            btnSumar.Focus();
        }


        // ================================================================== //
        // ------- Eventos para poder mover el formulario a voluntad -------- //
        // ================================================================== //
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                arrastre = true;
                Capture = true;
                mouseOffset = new Point(e.X, e.Y);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            arrastre = false;
            Capture = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (arrastre)
            {
                Location = new Point(e.X - mouseOffset.X + Location.X, 
                                     e.Y - mouseOffset.Y + Location.Y);
            }
        }

        private void frmPrincipal_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.SizeAll;
        }

        private void frmPrincipal_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

    }
}
