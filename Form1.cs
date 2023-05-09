using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularTiempo
{
    public partial class frmPrincipal : Form
    {
        private int horas;
        private int minutos;
        private int segundos;
        private int tiempos;
        private bool arrastre;
        private Point mouseOffset;

        public frmPrincipal()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.clock;
            this.ClientSize = new System.Drawing.Size(175, 350);
            ResetearFormulario();
        }

        private void btSumar_Click(object sender, EventArgs e)
        {
            if (!(tbHoras.Text != "00" || tbMinutos.Text != "00" || tbSegundos.Text != "00"))
            {
                ResetearTemporal();
                tbHoras.Focus();
                return;
            }

            horas += Convert.ToInt32(tbHoras.Text);
            minutos += Convert.ToInt32(tbMinutos.Text);
            segundos += Convert.ToInt32(tbSegundos.Text);

            while (segundos >= 60)
            {
                minutos++;
                segundos -= 60;
            }

            while (minutos >= 60)
            {
                horas++;
                minutos -= 60;
            }

            lviewHistorial.Items.Add($"{tiempos}. {tbHoras.Text}:{tbMinutos.Text}:{tbSegundos.Text}");
            tiempos++;
            actualizar();
            ResetearTemporal();
            tbHoras.Focus();
        }

        private void tbHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tbMinutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tbSegundos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void actualizar()
        {
            lbHoras.Text = horas.ToString("00");
            lbMinutos.Text = minutos.ToString("00");
            lbSegundos.Text = segundos.ToString("00");
        }

        private void ResetearFormulario()
        {
            ResetearTemporal();
            horas = 0;
            minutos = 0;
            segundos = 0;
            tiempos = 1;
            actualizar();
            tbHoras.Focus();
            lviewHistorial.Items.Clear();
            btSumar.Enabled = false;
        }

        private void ResetearTemporal()
        {
            tbHoras.Text = "";
            tbMinutos.Text = "";
            tbSegundos.Text = "";
        }

        private void btResetear_Click(object sender, EventArgs e)
        {
            ResetearFormulario();
        }

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

            btSumar.Enabled = true;
            btSumar.Focus();
        }

        private void VerificarSuma()
        {
            if (tbHoras.Text != "" && tbMinutos.Text != "" && tbSegundos.Text != "")
            {
                btSumar.Enabled = true;
            }
            else
            {
                btSumar.Enabled = false;
            }
        }

        private void tbHoras_TextChanged(object sender, EventArgs e)
        {
            VerificarSuma();
        }

        private void tbMinutos_TextChanged(object sender, EventArgs e)
        {
            VerificarSuma();
        }

        private void tbSegundos_TextChanged(object sender, EventArgs e)
        {
            VerificarSuma();
        }
    }
}
