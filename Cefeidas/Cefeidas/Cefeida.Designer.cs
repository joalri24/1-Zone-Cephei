namespace Cefeidas
{
    partial class Cefeida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cefeida));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chartRadio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPresion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVelocidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownIteraciones = new System.Windows.Forms.NumericUpDown();
            this.DetlaTiempoInput = new Cefeidas.scientificNotationInput();
            this.PresionInicialInput = new Cefeidas.scientificNotationInput();
            this.RadioInicialInput = new Cefeidas.scientificNotationInput();
            this.MasaCascaronInput = new Cefeidas.scientificNotationInput();
            this.MasaInicialInput = new Cefeidas.scientificNotationInput();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRadio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPresion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVelocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIteraciones)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ejecutar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Masa inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "kg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Masa cascarón:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "m";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Radio inicial:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(621, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Presión inicial:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.chartRadio);
            this.flowLayoutPanel1.Controls.Add(this.chartPresion);
            this.flowLayoutPanel1.Controls.Add(this.chartVelocidad);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(104, 135);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(749, 404);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // chartRadio
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.Title = "Tiempo (días)";
            chartArea1.AxisY.LabelStyle.Format = "E1";
            chartArea1.AxisY.Title = "Radio (m)";
            chartArea1.Name = "ChartArea1";
            this.chartRadio.ChartAreas.Add(chartArea1);
            this.chartRadio.Location = new System.Drawing.Point(3, 3);
            this.chartRadio.Name = "chartRadio";
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.SteelBlue;
            series1.Name = "Radio";
            series1.YValuesPerPoint = 4;
            this.chartRadio.Series.Add(series1);
            this.chartRadio.Size = new System.Drawing.Size(724, 250);
            this.chartRadio.TabIndex = 0;
            this.chartRadio.Text = "Radio";
            // 
            // chartPresion
            // 
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.Title = "Tiempo (días)";
            chartArea2.AxisY.LabelStyle.Format = "E1";
            chartArea2.AxisY.Title = "Presión (Pa)";
            chartArea2.Name = "ChartArea1";
            this.chartPresion.ChartAreas.Add(chartArea2);
            this.chartPresion.Location = new System.Drawing.Point(3, 259);
            this.chartPresion.Name = "chartPresion";
            series2.BorderColor = System.Drawing.Color.Black;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Maroon;
            series2.Name = "Presión";
            series2.YValuesPerPoint = 4;
            this.chartPresion.Series.Add(series2);
            this.chartPresion.Size = new System.Drawing.Size(724, 250);
            this.chartPresion.TabIndex = 1;
            this.chartPresion.Text = "Radio";
            // 
            // chartVelocidad
            // 
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.Title = "Tiempo (días)";
            chartArea3.AxisY.LabelStyle.Format = "E1";
            chartArea3.AxisY.Title = "Velocidad (m/s)";
            chartArea3.Name = "ChartArea1";
            this.chartVelocidad.ChartAreas.Add(chartArea3);
            this.chartVelocidad.Location = new System.Drawing.Point(3, 515);
            this.chartVelocidad.Name = "chartVelocidad";
            series3.BorderColor = System.Drawing.Color.Black;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.Purple;
            series3.LegendText = "Velocidad";
            series3.Name = "Velocidad";
            series3.YValuesPerPoint = 4;
            this.chartVelocidad.Series.Add(series3);
            this.chartVelocidad.Size = new System.Drawing.Size(724, 250);
            this.chartVelocidad.TabIndex = 2;
            this.chartVelocidad.Text = "Radio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(667, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Intervalo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(667, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Iteraciones: ";
            // 
            // numericUpDownIteraciones
            // 
            this.numericUpDownIteraciones.Location = new System.Drawing.Point(738, 49);
            this.numericUpDownIteraciones.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownIteraciones.Name = "numericUpDownIteraciones";
            this.numericUpDownIteraciones.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownIteraciones.TabIndex = 17;
            this.numericUpDownIteraciones.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // DetlaTiempoInput
            // 
            this.DetlaTiempoInput.Location = new System.Drawing.Point(724, 12);
            this.DetlaTiempoInput.Name = "DetlaTiempoInput";
            this.DetlaTiempoInput.Size = new System.Drawing.Size(192, 26);
            this.DetlaTiempoInput.TabIndex = 15;
            // 
            // PresionInicialInput
            // 
            this.PresionInicialInput.Location = new System.Drawing.Point(436, 45);
            this.PresionInicialInput.Name = "PresionInicialInput";
            this.PresionInicialInput.Size = new System.Drawing.Size(192, 28);
            this.PresionInicialInput.TabIndex = 10;
            // 
            // RadioInicialInput
            // 
            this.RadioInicialInput.Location = new System.Drawing.Point(113, 45);
            this.RadioInicialInput.Name = "RadioInicialInput";
            this.RadioInicialInput.Size = new System.Drawing.Size(192, 28);
            this.RadioInicialInput.TabIndex = 7;
            // 
            // MasaCascaronInput
            // 
            this.MasaCascaronInput.Location = new System.Drawing.Point(436, 12);
            this.MasaCascaronInput.Name = "MasaCascaronInput";
            this.MasaCascaronInput.Size = new System.Drawing.Size(192, 28);
            this.MasaCascaronInput.TabIndex = 4;
            // 
            // MasaInicialInput
            // 
            this.MasaInicialInput.Location = new System.Drawing.Point(113, 12);
            this.MasaInicialInput.Name = "MasaInicialInput";
            this.MasaInicialInput.Size = new System.Drawing.Size(192, 28);
            this.MasaInicialInput.TabIndex = 1;
            // 
            // Cefeida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(899, 653);
            this.Controls.Add(this.numericUpDownIteraciones);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DetlaTiempoInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PresionInicialInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RadioInicialInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MasaCascaronInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MasaInicialInput);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cefeida";
            this.Text = "Cefeida de una Zona";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRadio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPresion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVelocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIteraciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private scientificNotationInput MasaInicialInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private scientificNotationInput MasaCascaronInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private scientificNotationInput RadioInicialInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private scientificNotationInput PresionInicialInput;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRadio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPresion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVelocidad;
        private System.Windows.Forms.Label label9;
        private scientificNotationInput DetlaTiempoInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownIteraciones;
    }
}

