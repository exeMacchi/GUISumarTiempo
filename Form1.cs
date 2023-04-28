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

        public frmPrincipal()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.clock;
            horas = 0;
            minutos = 0;
            segundos = 0;
            actualizar();
        }

        private void btSumar_Click(object sender, EventArgs e)
        {
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

            actualizar();
            resetearTemporal();
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

        private void resetearTemporal()
        {
            tbHoras.Text = "";
            tbMinutos.Text = "";
            tbSegundos.Text = "";
        }

        private void btResetear_Click(object sender, EventArgs e)
        {
            resetearTemporal();
            horas = 0;
            minutos = 0;
            segundos = 0;
            actualizar();
            tbHoras.Focus();
        }
    }
}
