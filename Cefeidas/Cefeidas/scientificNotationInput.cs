using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cefeidas
{
    public partial class scientificNotationInput : UserControl
    {
        // -----------------------------------------------------
        // Constructor
        // -----------------------------------------------------

        public scientificNotationInput()
        {
            InitializeComponent();
        }


        // -----------------------------------------------------
        // Métodos
        // -----------------------------------------------------

        public decimal Exponente
        {
            set
            {
                numericUpDownExp.Value = value;
            }
        }

        public decimal Coeficiente
        {
            set
            {
                numericUpDownCoeficiente.Value = value;
            }
        }

        public double darValor()
        {
            double exponente = Convert.ToDouble(numericUpDownExp.Value);
            double coeficiente = Convert.ToDouble(numericUpDownCoeficiente.Value);
            return coeficiente * Math.Pow(10, exponente);
        }

    }
}
