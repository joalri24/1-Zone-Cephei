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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.PresionInicialInput = new Cefeidas.scientificNotationInput();
            this.RadioInicialInput = new Cefeidas.scientificNotationInput();
            this.MasaCascaronInput = new Cefeidas.scientificNotationInput();
            this.MasaInicialInput = new Cefeidas.scientificNotationInput();
            this.chartPresion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVelocidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRadio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPresion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVelocidad)).BeginInit();
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
            this.label3.Location = new System.Drawing.Point(685, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 18);
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
            this.label7.Location = new System.Drawing.Point(685, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Presión inicial:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.chartRadio);
            this.flowLayoutPanel1.Controls.Add(this.chartPresion);
            this.flowLayoutPanel1.Controls.Add(this.chartVelocidad);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 135);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(727, 399);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // chartRadio
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRadio.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRadio.Legends.Add(legend1);
            this.chartRadio.Location = new System.Drawing.Point(3, 3);
            this.chartRadio.Name = "chartRadio";
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.SteelBlue;
            series1.Legend = "Legend1";
            series1.Name = "Radio";
            series1.YValuesPerPoint = 4;
            this.chartRadio.Series.Add(series1);
            this.chartRadio.Size = new System.Drawing.Size(724, 238);
            this.chartRadio.TabIndex = 0;
            this.chartRadio.Text = "Radio";
            // 
            // PresionInicialInput
            // 
            this.PresionInicialInput.Location = new System.Drawing.Point(500, 45);
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
            this.MasaCascaronInput.Location = new System.Drawing.Point(500, 12);
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
            // chartPresion
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPresion.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPresion.Legends.Add(legend2);
            this.chartPresion.Location = new System.Drawing.Point(3, 247);
            this.chartPresion.Name = "chartPresion";
            series2.BorderColor = System.Drawing.Color.Black;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Maroon;
            series2.Legend = "Legend1";
            series2.Name = "Presión";
            series2.YValuesPerPoint = 4;
            this.chartPresion.Series.Add(series2);
            this.chartPresion.Size = new System.Drawing.Size(724, 238);
            this.chartPresion.TabIndex = 1;
            this.chartPresion.Text = "Radio";
            // 
            // chartVelocidad
            // 
            chartArea3.Name = "ChartArea1";
            this.chartVelocidad.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartVelocidad.Legends.Add(legend3);
            this.chartVelocidad.Location = new System.Drawing.Point(3, 491);
            this.chartVelocidad.Name = "chartVelocidad";
            series3.BorderColor = System.Drawing.Color.Black;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.Purple;
            series3.Legend = "Legend1";
            series3.LegendText = "Velocidad";
            series3.Name = "Velocidad";
            series3.YValuesPerPoint = 4;
            this.chartVelocidad.Series.Add(series3);
            this.chartVelocidad.Size = new System.Drawing.Size(724, 238);
            this.chartVelocidad.TabIndex = 2;
            this.chartVelocidad.Text = "Radio";
            // 
            // Cefeida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 534);
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
            this.Name = "Cefeida";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRadio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPresion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVelocidad)).EndInit();
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
    }
}

