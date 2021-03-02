
namespace CurrencyExchange
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.remainderLabel = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.skipButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.buyOrSellNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.capitalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.courseNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.euroLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyOrSellNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.euroLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.remainderLabel);
            this.panel1.Controls.Add(this.Label5);
            this.panel1.Controls.Add(this.skipButton);
            this.panel1.Controls.Add(this.sellButton);
            this.panel1.Controls.Add(this.buyButton);
            this.panel1.Controls.Add(this.buyOrSellNumericUpDown);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.calculateButton);
            this.panel1.Controls.Add(this.capitalNumericUpDown);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.courseNumericUpDown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 623);
            this.panel1.TabIndex = 0;
            // 
            // remainderLabel
            // 
            this.remainderLabel.AutoSize = true;
            this.remainderLabel.Location = new System.Drawing.Point(128, 540);
            this.remainderLabel.Name = "remainderLabel";
            this.remainderLabel.Size = new System.Drawing.Size(0, 20);
            this.remainderLabel.TabIndex = 13;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label5.Location = new System.Drawing.Point(16, 540);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(106, 20);
            this.Label5.TabIndex = 12;
            this.Label5.Text = "Remainder: ";
            // 
            // skipButton
            // 
            this.skipButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.skipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skipButton.Location = new System.Drawing.Point(16, 449);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(158, 52);
            this.skipButton.TabIndex = 11;
            this.skipButton.Text = "SKIP";
            this.skipButton.UseVisualStyleBackColor = false;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sellButton.Location = new System.Drawing.Point(16, 376);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(158, 52);
            this.sellButton.TabIndex = 10;
            this.sellButton.Text = "SELL";
            this.sellButton.UseVisualStyleBackColor = false;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyButton.Location = new System.Drawing.Point(16, 300);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(158, 52);
            this.buyButton.TabIndex = 9;
            this.buyButton.Text = "BUY";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // buyOrSellNumericUpDown
            // 
            this.buyOrSellNumericUpDown.Location = new System.Drawing.Point(16, 241);
            this.buyOrSellNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.buyOrSellNumericUpDown.Name = "buyOrSellNumericUpDown";
            this.buyOrSellNumericUpDown.Size = new System.Drawing.Size(158, 26);
            this.buyOrSellNumericUpDown.TabIndex = 6;
            this.buyOrSellNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "How much to buy or sell";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(16, 145);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(162, 52);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "START GAME";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // capitalNumericUpDown
            // 
            this.capitalNumericUpDown.DecimalPlaces = 2;
            this.capitalNumericUpDown.Location = new System.Drawing.Point(16, 95);
            this.capitalNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.capitalNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.capitalNumericUpDown.Name = "capitalNumericUpDown";
            this.capitalNumericUpDown.Size = new System.Drawing.Size(158, 26);
            this.capitalNumericUpDown.TabIndex = 3;
            this.capitalNumericUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start-up capital";
            // 
            // courseNumericUpDown
            // 
            this.courseNumericUpDown.DecimalPlaces = 2;
            this.courseNumericUpDown.Location = new System.Drawing.Point(16, 32);
            this.courseNumericUpDown.Maximum = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.courseNumericUpDown.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.courseNumericUpDown.Name = "courseNumericUpDown";
            this.courseNumericUpDown.Size = new System.Drawing.Size(158, 26);
            this.courseNumericUpDown.TabIndex = 1;
            this.courseNumericUpDown.Value = new decimal(new int[] {
            8953,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current course";
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 60D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(246, 0);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "f2";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(750, 623);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Euro: ";
            // 
            // euroLabel
            // 
            this.euroLabel.AutoSize = true;
            this.euroLabel.Location = new System.Drawing.Point(71, 564);
            this.euroLabel.Name = "euroLabel";
            this.euroLabel.Size = new System.Drawing.Size(0, 20);
            this.euroLabel.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 623);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyOrSellNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown courseNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.NumericUpDown capitalNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.NumericUpDown buyOrSellNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label remainderLabel;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label euroLabel;
        private System.Windows.Forms.Label label4;
    }
}

