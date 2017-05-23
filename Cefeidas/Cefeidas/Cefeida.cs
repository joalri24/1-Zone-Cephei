using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

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

        /// <summary>
        /// Número de iteraciones
        /// </summary>
        private const int NUMERO_ITERACIONES = 150;

        /// <summary>
        /// Tasa de calor específico de un gas monoatómico ideal. 5/3.
        /// </summary>
        private const double CALOR_ESPECIFICO = 1.6666666666666666666666666666667;

        /// <summary>
        /// El nombre de la serie de la gráfica del radio vs tiempo.
        /// </summary>
        private const string NOMBRE_SERIE_RADIO = "Radio";

        /// <summary>
        /// El nombre de la serie de la gráfica de la presión vs tiempo.
        /// </summary>
        private const string NOMBRE_SERIE_PRESION = "Presión";

        /// <summary>
        /// El nombre de la serie de la gráfica de la velocidad vs tiempo.
        /// </summary>
        private const string NOMBRE_SERIE_VELOCIDAD = "Velocidad";


        // --------------------------------------------------
        // Atributos y propiedades

        // --------------------------------------------------
        /// <summary>
        /// Constante de gravitación universal
        /// </summary>
        private double G;

        /// <summary>
        /// Arreglo donde se van a guardar los resultados de los radios.
        /// </summary>
        public double[] Radios { get; set; }

        /// <summary>
        /// Arreglo donde se van a guardar los resultados de las presiones.
        /// </summary>
        public double[] Presiones { get; set; }

        /// <summary>
        /// Arreglo donde se van a guardar los resultados de las velocidades.
        /// </summary>
        public double[] Velocidades { get; set; }

        /// <summary>
        /// Arreglo donde se van a guardar los valores del tiempo.
        /// </summary>
        public double[] Tiempos { get; set; }

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

            // Valores por defecto --------
            MasaInicialInput.Coeficiente = 1M;
            MasaInicialInput.Exponente = 31M;

            RadioInicialInput.Coeficiente = 1.7M;
            RadioInicialInput.Exponente = 10M;

            MasaCascaronInput.Coeficiente = 1M;
            MasaCascaronInput.Exponente = 26M;

            PresionInicialInput.Coeficiente = 5.6M;
            PresionInicialInput.Exponente = 4M;
            // --------------
        }


        // --------------------------------------------------
        // Métodos
        // --------------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            SimularCefeida();
        }

        /// <summary>
        /// Realiza la simulación de la cefeida. 
        /// Dentro de este método se llevan a cabo las iteraciones.
        /// </summary>
        private void SimularCefeida()
        {

            AsignarValoresIniciales();

            for (int i = 0; i < NUMERO_ITERACIONES; i++)
            {
                double radioInicial = Radio;

                Tiempo += DELTA_TIEMPO;
                Velocidad = calcularVelocidad(Velocidad, Radio, Presion, MasaCascaron, MasaEstrella, DELTA_TIEMPO);
                Radio = calcularRadio(Radio, Velocidad, DELTA_TIEMPO);
                Presion = calcularPresion(Presion, radioInicial, Radio, CALOR_ESPECIFICO);

                Tiempos[i] = Tiempo / 86400; // para convertirlo a días.
                Radios[i] = Radio;
                Presiones[i] = Presion;
                Velocidades[i] = Velocidad;
                Debug.WriteLine("V: " + Velocidad.ToString("E5"));
                //Debug.WriteLine("R: " + Radio.ToString("E5"));
                //Debug.WriteLine("P: " + Presion);
                //Debug.WriteLine("---T: "+ i +" ---------------------");
            }

            graficarResultados(chartRadio, NOMBRE_SERIE_RADIO, Tiempos, Radios);
            graficarResultados(chartPresion, NOMBRE_SERIE_PRESION, Tiempos, Presiones);
            graficarResultados(chartVelocidad, NOMBRE_SERIE_VELOCIDAD, Tiempos, Velocidades);

        }

        /// <summary>
        /// Grafica los resultados en la gráfica correspondiente.
        /// Ambos arreglos deben tener el mismo número de elementos.
        /// </summary>
        private void graficarResultados(Chart grafico, string nombreSerie,  double[] datosEjeX, double[] datosEjeY)
        {
            for (int i = 0; i < datosEjeX.Length; i++)
                grafico.Series[nombreSerie].Points.AddXY(datosEjeX[i], datosEjeY[i]);      
        }

        /// <summary>
        /// Se utiliza cuando comienza la simulación.
        /// Asigna los valores de la interfaz a loas variables correspondientes
        /// </summary>
        private void AsignarValoresIniciales()
        {
            MasaEstrella = MasaInicialInput.darValor();
            MasaCascaron = MasaCascaronInput.darValor();
            Presion = PresionInicialInput.darValor();
            Radio = RadioInicialInput.darValor();
            Tiempo = 0;
            Velocidad = 0;
            Tiempos = new double[NUMERO_ITERACIONES];
            Radios = new double[NUMERO_ITERACIONES];
            Presiones = new double[NUMERO_ITERACIONES];
            Velocidades = new double[NUMERO_ITERACIONES];

            // Limpiar las gráficas
            foreach (var series in chartRadio.Series)
                series.Points.Clear();
            foreach (var series in chartPresion.Series)
                series.Points.Clear();
            foreach (var series in chartVelocidad.Series)
                series.Points.Clear();

        }

        /// <summary>
        /// Calcula la velocidad actual del cascarón. 
        /// Ecuación 14.24
        /// </summary>
        /// <param name="velocidadInicial"></param>
        /// <param name="radioInicial"></param>
        /// <param name="presionInicial"></param>
        /// <param name="masaCascaron"></param>
        /// <param name="masaEstrella"></param>
        /// <param name="deltaTiempo"></param>
        /// <returns></returns>
        private double calcularVelocidad(double velocidadInicial, double radioInicial, double presionInicial, 
            double masaCascaron, double masaEstrella, double deltaTiempo)
        {

            double respuesta = velocidadInicial;
            double rCuadrado = Math.Pow(radioInicial, 2);

            respuesta += (((4 * Math.PI * presionInicial * rCuadrado) / masaCascaron) 
                - ((G * masaEstrella) / rCuadrado)) * deltaTiempo;
              
            return respuesta;
        }

        /// <summary>
        /// Calcula el radio actual de la estrella. Ecuación 14.25
        /// </summary>
        /// <param name="radioInicial"></param>
        /// <param name="velocidad"></param>
        /// <param name="deltaTiempo"></param>
        /// <returns></returns>
        private double calcularRadio(double radioInicial, double velocidad, double deltaTiempo)
        {
            double respuesta = radioInicial;
            respuesta += velocidad * deltaTiempo; 
            return respuesta;
        }

        /// <summary>
        /// Calcula la presión actual. Ecuación 14.23
        /// </summary>
        /// <param name="presionInicial"></param>
        /// <param name="radioInicial"></param>
        /// <param name="radioFinal"></param>
        /// <param name="calorEspecifco"></param>
        /// <returns></returns>
        private double calcularPresion(double presionInicial, double radioInicial, double radioFinal, double calorEspecifco)
        {
            double respuesta = presionInicial;
            respuesta *= Math.Pow( radioInicial / radioFinal, 3 * calorEspecifco);
            return respuesta;
        }
    }
}
