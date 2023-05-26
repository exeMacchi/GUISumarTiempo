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
        // ================================================================== //
        // ---------------------------- Atributos --------------------------- //
        // ================================================================== //
        private int horas;
        private int minutos;
        private int segundos;
        private int tiempos;
        private bool arrastre;
        private Point mouseOffset;


        // ================================================================== //
        // ---------------------------- Constructor ------------------------- //
        // ================================================================== //
        public frmPrincipal()
        {
            InitializeComponent();

            // Establecer el ícono de la aplicación.
            this.Icon = Properties.Resources.clock;

            // Resetear el tamaño del formulario al predeterminado.
            this.ClientSize = new System.Drawing.Size(175, 350);

            ResetearFormulario();
        }
    }
}
