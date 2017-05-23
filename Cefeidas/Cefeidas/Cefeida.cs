using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cefeidas
{
    public partial class Cefeida : Form
    {

        // --------------------------------------------------
        // Constantes
        // --------------------------------------------------


        // --------------------------------------------------
        // Atributos y propiedades
        // --------------------------------------------------

        /// <summary>
        /// Tiempo en segundos.
        /// </summary>
        private double Tiempo { get; set; }

        /// <summary>
        /// Masa en kg.
        /// </summary>
        private double MasaEstrella { get; set; }

        /// <summary>
        /// Masa en m
        /// </summary>
        private double Radio { get; set; }

        /// <summary>
        /// Velocidad en m/s.
        /// </summary>
        private double Velocidad { get; set; }

        /// <summary>
        /// Masa en kg.
        /// </summary>
        private double MasaCascaron { get; set; }


        // --------------------------------------------------
        // Constructores
        // --------------------------------------------------

        public Cefeida()
        {
            InitializeComponent();

            MasaInicialInput.Coeficiente = 1M;
            MasaInicialInput.Exponente = 31M;

            RadioInicialInput.Coeficiente = 1.7M;
            RadioInicialInput.Exponente = 10M;

            MasaCascaronInput.Coeficiente = 1M;
            MasaCascaronInput.Exponente = 26M;

            PresionInicialInput.Coeficiente = 5.6M;
            PresionInicialInput.Exponente = 4M;
        }


        // --------------------------------------------------
        // Métodos
        // --------------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = ""+PresionInicialInput.darValor();
        }

        private void ponerValoresIniciales()
        {
            // TODO
        }

        private double calcularVelocidad(double velocidadInicial, double radioInicial, double presionInicial, double masaCascaron, double masaEstrella, double deltaTiempo)
        {

            return 0.0;
        }
    }
}
