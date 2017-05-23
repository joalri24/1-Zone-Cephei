namespace Cefeidas
{
    partial class scientificNotationInput
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownCoeficiente = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownExp = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoeficiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExp)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownCoeficiente
            // 
            this.numericUpDownCoeficiente.DecimalPlaces = 4;
            this.numericUpDownCoeficiente.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownCoeficiente.Location = new System.Drawing.Point(3, 3);
            this.numericUpDownCoeficiente.Name = "numericUpDownCoeficiente";
            this.numericUpDownCoeficiente.Size = new System.Drawing.Size(91, 20);
            this.numericUpDownCoeficiente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X10^";
            // 
            // numericUpDownExp
            // 
            this.numericUpDownExp.Location = new System.Drawing.Point(138, 3);
            this.numericUpDownExp.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownExp.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            -2147483648});
            this.numericUpDownExp.Name = "numericUpDownExp";
            this.numericUpDownExp.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownExp.TabIndex = 2;
            // 
            // scientificNotationInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDownExp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownCoeficiente);
            this.Name = "scientificNotationInput";
            this.Size = new System.Drawing.Size(192, 26);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoeficiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownCoeficiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownExp;
    }
}
