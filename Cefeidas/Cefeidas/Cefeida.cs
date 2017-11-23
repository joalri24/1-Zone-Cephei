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
    /// <Author> Jose Riaño - 2017 </Author>
    public partial class Cepheid : Form
    {

        // --------------------------------------------------
        // Constants
        // --------------------------------------------------

        /// <summary>
        /// Specific heat ratio for an ideal monoatomic gas = 5/3.
        /// </summary>
        private const double SPECIFIC_HEAT_RATIO = 1.6666666666666666666666666666667;

        /// <summary>
        /// Series name displayed in the radius vs time chart.
        /// </summary>
        private const string RADIUS_SERIES_NAME = "Radio";

        /// <summary>
        /// Series name displayed in the pressure vs time chart.
        /// </summary>
        private const string PRESSURE_SERIES_NAME = "Presión";

        /// <summary>
        /// Series name displayed in the velocity vs time chart.
        /// </summary>
        private const string VELOCITY_SERIES_NAME = "Velocidad";


        // --------------------------------------------------
        // Attributes and properties
        // --------------------------------------------------

        /// <summary>
        /// Universal Gravitational constant
        /// </summary>
        private double G;

        /// <summary>
        /// The resulting radius are stored in this array.
        /// </summary>
        public double[] Radiuses { get; set; }

        /// <summary>
        /// The resulting pressures are stored in this array.
        /// </summary>
        public double[] Pressures { get; set; }

        /// <summary>
        /// The resulting velocities are stored in this array.
        /// </summary>
        public double[] Velocities { get; set; }

        /// <summary>
        /// The time stamps are stored in this array.
        /// </summary>
        public double[] Times { get; set; }

        /// <summary>
        /// Time in seconds.
        /// </summary>
        private double Time { get; set; }

        /// <summary>
        /// Star mass in Kg.
        /// </summary>
        private double StarMass { get; set; }

        /// <summary>
        /// Star radius in Km.
        /// </summary>
        private double Radius { get; set; }

        /// <summary>
        /// Shell velocity in m/s.
        /// </summary>
        private double Velocity { get; set; }

        /// <summary>
        /// Shell mass in Kg.
        /// </summary>
        private double ShellMass { get; set; }

        /// <summary>
        /// star pressure in Pa.
        /// </summary>
        private double Pressure { get; set; }

        /// <summary>
        /// Time trancurred between iterations.
        /// </summary>
        private double TimeDelta { get; set; }

        /// <summary>
        /// Number of iterations to be executed.
        /// </summary>
        private int Iterations { get; set; }

        /// <summary>
        /// Factor to transform from seconda to days.
        /// </summary>
        private double ToDayFactor;



        // --------------------------------------------------
        // Constructors
        // --------------------------------------------------

        public Cepheid()
        {
            InitializeComponent();

            G = 6.674 * Math.Pow(10, -11);
            ToDayFactor = 1.0 / 86400.0;

            // Default values --------
            InitialMassInput.Coefficient = 1M;
            InitialMassInput.Exponent = 31M;

            InitialRadiusInput.Coefficient = 1.7M;
            InitialRadiusInput.Exponent = 10M;

            ShellMassInput.Coefficient = 1M;
            ShellMassInput.Exponent = 26M;

            InitialPressureInput.Coefficient = 5.6M;
            InitialPressureInput.Exponent = 4M;

            TimeDeltaInput.Coefficient = 1M;
            TimeDeltaInput.Exponent = 4M;

        }


        // --------------------------------------------------
        // Methods
        // --------------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            SimulateCepheid();
        }

        /// <summary> 
        /// Starts the simulation.
        /// </summary>
        private void SimulateCepheid()
        {
            AssignInitialValues();

            for (int i = 0; i < Iterations; i++)
            {
                double initialRadius = Radius;

                Time += TimeDelta;
                Velocity = calculateVelocity(Velocity, Radius, Pressure, ShellMass, StarMass, TimeDelta);
                Radius = calculateRadius(Radius, Velocity, TimeDelta);
                Pressure = calculatePressure(Pressure, initialRadius, Radius, SPECIFIC_HEAT_RATIO);

                Times[i] = Time * ToDayFactor; // para convertirlo a días.
                Radiuses[i] = Radius;
                Pressures[i] = Pressure;
                Velocities[i] = Velocity;
                Debug.WriteLine("Fc: " + ToDayFactor);
            }

            PlotResults(chartRadio, RADIUS_SERIES_NAME, Times, Radiuses);
            PlotResults(chartPresion, PRESSURE_SERIES_NAME, Times, Pressures);
            PlotResults(chartVelocidad, VELOCITY_SERIES_NAME, Times, Velocities);

        }

        /// <summary>
        /// Plots results in the given chart.
        /// Both parameters must have the same size.
        /// </summary>
        private void PlotResults(Chart chart, string seriesName,  double[] xAxisData, double[] yAxisData)
        {
            for (int i = 0; i < xAxisData.Length; i++)
                chart.Series[seriesName].Points.AddXY(xAxisData[i], yAxisData[i]);      
        }

        /// <summary>
        /// Gets the values from the UI, and initializes the necessary variables.
        /// </summary>
        private void AssignInitialValues()
        {
            StarMass = InitialMassInput.getValue();
            ShellMass = ShellMassInput.getValue();
            Pressure = InitialPressureInput.getValue();
            Radius = InitialRadiusInput.getValue();
            TimeDelta = TimeDeltaInput.getValue();
            Time = 0;
            Velocity = 0;
            Iterations = (int) numericUpDownIterations.Value;
            Times = new double[Iterations];
            Radiuses = new double[Iterations];
            Pressures = new double[Iterations];
            Velocities = new double[Iterations];

            // Clear charts.
            foreach (var series in chartRadio.Series)
                series.Points.Clear();
            foreach (var series in chartPresion.Series)
                series.Points.Clear();
            foreach (var series in chartVelocidad.Series)
                series.Points.Clear();

        }

        /// <summary>
        /// Calculates the shell's current speed. 
        /// Equation 14.24
        /// </summary>
        /// <param name="initialVelocity"></param>
        /// <param name="initialRadius"></param>
        /// <param name="initialPressure"></param>
        /// <param name="shellMass"></param>
        /// <param name="starMass"></param>
        /// <param name="timeDelta"></param>
        /// <returns></returns>
        private double calculateVelocity(double initialVelocity, double initialRadius, double initialPressure, 
            double shellMass, double starMass, double timeDelta)
        {

            double answer = initialVelocity;
            double rSquared = Math.Pow(initialRadius, 2);

            answer += (((4 * Math.PI * initialPressure * rSquared) / shellMass) 
                - ((G * starMass) / rSquared)) * timeDelta;
              
            return answer;
        }

        /// <summary>
        /// Calculates the star's current radius.
        /// Equation 14.25
        /// </summary>
        /// <param name="initialRadius"></param>
        /// <param name="velocity"></param>
        /// <param name="timeDelta"></param>
        /// <returns></returns>
        private double calculateRadius(double initialRadius, double velocity, double timeDelta)
        {
            double answer = initialRadius;
            answer += velocity * timeDelta; 
            return answer;
        }

        /// <summary>
        /// Calculates the star's current pressure.
        /// Equation 14.23
        /// </summary>
        /// <param name="initialPressure"></param>
        /// <param name="initialRadius"></param>
        /// <param name="finalRadius"></param>
        /// <param name="specificHeat"></param>
        /// <returns></returns>
        private double calculatePressure(double initialPressure, double initialRadius, double finalRadius, double specificHeat)
        {
            double answer = initialPressure;
            answer *= Math.Pow( initialRadius / finalRadius, 3 * specificHeat);
            return answer;
        }
    }
}
