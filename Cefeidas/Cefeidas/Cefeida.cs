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
        /// <summary>
        /// Intervalo en segundos
        /// </summary>
        private const double DELTA_TIEMPO = 10000;


        // --------------------------------------------------
        // Atributos y propiedades

        // --------------------------------------------------
        /// <summary>
        /// Constante de gravitación universal
        /// </summary>
        private double G;

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

        /// <summary>
        /// Presión en Pa.
        /// </summary>
        private double Presion { get; set; }


        // --------------------------------------------------
        // Constructores
        // --------------------------------------------------

        public Cefeida()
        {
            InitializeComponent();

            G = 6.674 * Math.Pow(10, -11);

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
            MasaEstrella = MasaInicialInput.darValor();
            MasaCascaron = MasaCascaronInput.darValor();
            Presion = PresionInicialInput.darValor();
            Radio = RadioInicialInput.darValor();
            Tiempo = 0;
        }

        private double calcularVelocidad(double velocidadInicial, double radioInicial, double presionInicial, 
            double masaCascaron, double masaEstrella, double deltaTiempo)
        {

            double respuesta = Velocidad;
            double rCuadrado = Math.Pow(radioInicial, 2);

            respuesta += (((4 * Math.PI * presionInicial * rCuadrado) / masaCascaron) 
                - ((G * masaEstrella) / rCuadrado)) * deltaTiempo;
              
            return respuesta;
        }
    }
}
