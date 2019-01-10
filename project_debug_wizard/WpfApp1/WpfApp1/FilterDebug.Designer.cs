namespace WpfApp1
{
    partial class FilterDebug
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.ResistorBox = new System.Windows.Forms.TextBox();
            this.CapBox = new System.Windows.Forms.TextBox();
            this.equalCheck = new System.Windows.Forms.CheckBox();
            this.orderUpDown = new System.Windows.Forms.NumericUpDown();
            this.fCalculate = new System.Windows.Forms.Button();
            this.fClose = new System.Windows.Forms.Button();
            this.fHelp = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.orderUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 394);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ResistorBox
            // 
            this.ResistorBox.Location = new System.Drawing.Point(223, 79);
            this.ResistorBox.Name = "ResistorBox";
            this.ResistorBox.Size = new System.Drawing.Size(90, 20);
            this.ResistorBox.TabIndex = 1;
            // 
            // CapBox
            // 
            this.CapBox.Location = new System.Drawing.Point(224, 105);
            this.CapBox.Name = "CapBox";
            this.CapBox.Size = new System.Drawing.Size(88, 20);
            this.CapBox.TabIndex = 2;
            // 
            // equalCheck
            // 
            this.equalCheck.AutoSize = true;
            this.equalCheck.Location = new System.Drawing.Point(223, 21);
            this.equalCheck.Name = "equalCheck";
            this.equalCheck.Size = new System.Drawing.Size(59, 17);
            this.equalCheck.TabIndex = 3;
            this.equalCheck.Text = "Equal?";
            this.equalCheck.UseVisualStyleBackColor = true;
            // 
            // orderUpDown
            // 
            this.orderUpDown.Location = new System.Drawing.Point(223, 44);
            this.orderUpDown.Name = "orderUpDown";
            this.orderUpDown.Size = new System.Drawing.Size(120, 20);
            this.orderUpDown.TabIndex = 4;
            // 
            // fCalculate
            // 
            this.fCalculate.Location = new System.Drawing.Point(223, 143);
            this.fCalculate.Name = "fCalculate";
            this.fCalculate.Size = new System.Drawing.Size(90, 29);
            this.fCalculate.TabIndex = 5;
            this.fCalculate.Text = "Calculate";
            this.fCalculate.UseVisualStyleBackColor = true;
            this.fCalculate.Click += new System.EventHandler(this.fCalculate_Click);
            // 
            // fClose
            // 
            this.fClose.Location = new System.Drawing.Point(221, 382);
            this.fClose.Name = "fClose";
            this.fClose.Size = new System.Drawing.Size(91, 33);
            this.fClose.TabIndex = 6;
            this.fClose.Text = "Close";
            this.fClose.UseVisualStyleBackColor = true;
            this.fClose.Click += new System.EventHandler(this.fClose_Click);
            // 
            // fHelp
            // 
            this.fHelp.Location = new System.Drawing.Point(336, 382);
            this.fHelp.Name = "fHelp";
            this.fHelp.Size = new System.Drawing.Size(91, 33);
            this.fHelp.TabIndex = 7;
            this.fHelp.Text = "Help";
            this.fHelp.UseVisualStyleBackColor = true;
            this.fHelp.Click += new System.EventHandler(this.fHelp_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(433, 21);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Freq. Resp.";
            series2.ChartArea = "ChartArea2";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Phase Resp.";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(355, 394);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // FilterDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.fHelp);
            this.Controls.Add(this.fClose);
            this.Controls.Add(this.fCalculate);
            this.Controls.Add(this.orderUpDown);
            this.Controls.Add(this.equalCheck);
            this.Controls.Add(this.CapBox);
            this.Controls.Add(this.ResistorBox);
            this.Controls.Add(this.listBox1);
            this.Name = "FilterDebug";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FilterDebug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TextBox ResistorBox;
        private System.Windows.Forms.TextBox CapBox;
        private System.Windows.Forms.CheckBox equalCheck;
        private System.Windows.Forms.NumericUpDown orderUpDown;
        private System.Windows.Forms.Button fCalculate;
        private System.Windows.Forms.Button fClose;
        private System.Windows.Forms.Button fHelp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}