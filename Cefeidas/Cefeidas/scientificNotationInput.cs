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
    /// <summary>
    /// <Author> Jose Riaño - 2017 </Author>
    /// </summary>
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

        public decimal Exponent
        {
            set
            {
                numericUpDownExp.Value = value;
            }
        }

        public decimal Coefficient
        {
            set
            {
                numericUpDownCoeficiente.Value = value;
            }
        }

        public double getValue()
        {
            double exponent = Convert.ToDouble(numericUpDownExp.Value);
            double coefficient = Convert.ToDouble(numericUpDownCoeficiente.Value);
            return coefficient * Math.Pow(10, exponent);
        }

    }
}
