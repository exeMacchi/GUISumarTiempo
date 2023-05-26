using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularTiempo
{
    public partial class frmPrincipal
    {
        // ================================================================== //
        // ----------------------------- Métodos ---------------------------- //
        // ================================================================== //
        /// <summary>
        /// Actualizar las etiquetas del tiempo total utilizando los valores almacenados
        /// en los atributos privados <see cref="horas"/>, <see cref="minutos"/> y 
        /// <see cref="segundos"/>
        /// </summary>
        private void Actualizar()
        {
            lbHoras.Text = horas.ToString("00");
            lbMinutos.Text = minutos.ToString("00");
            lbSegundos.Text = segundos.ToString("00");
        }


        /// <summary>
        /// Resetear el formulario a su configuración básica.
        /// </summary>
        private void ResetearFormulario()
        {
            ResetearTemporal();
            horas = 0;
            minutos = 0;
            segundos = 0;
            tiempos = 1;
            Actualizar();
            tbHoras.Focus();
            lviewHistorial.Items.Clear();
            btnSumar.Enabled = false;
        }


        /// <summary>
        /// Resetear los TextBoxes <see cref="tbHoras"/>, <see cref="tbMinutos"/> y 
        /// <see cref="tbSegundos"/> a su valor por defecto.
        /// </summary>
        private void ResetearTemporal()
        {
            tbHoras.Text = "";
            tbMinutos.Text = "";
            tbSegundos.Text = "";
        }


        /// <summary>
        /// Validación de los TextBox para poder utilizar el <see cref="btnSumar"/>
        /// </summary>
        private void VerificarSuma()
        {
            if (tbHoras.Text != "" && tbMinutos.Text != "" && tbSegundos.Text != "")
            {
                btnSumar.Enabled = true;
            }
            else
            {
                btnSumar.Enabled = false;
            }
        }

    }
}
