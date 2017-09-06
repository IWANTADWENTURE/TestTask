namespace TestTask
{
    partial class ChartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CancerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.reloadButton = new System.Windows.Forms.Button();
            this.dateComboBox = new System.Windows.Forms.ComboBox();
            this.delPointButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CancerChart)).BeginInit();
            this.SuspendLayout();
            // 
            // CancerChart
            // 
            chartArea6.Name = "ChartArea1";
            this.CancerChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.CancerChart.Legends.Add(legend6);
            this.CancerChart.Location = new System.Drawing.Point(12, 12);
            this.CancerChart.Name = "CancerChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.CancerChart.Series.Add(series6);
            this.CancerChart.Size = new System.Drawing.Size(543, 419);
            this.CancerChart.TabIndex = 0;
            this.CancerChart.Text = "chart1";
            this.CancerChart.Click += new System.EventHandler(this.CancerChart_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(561, 401);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(121, 30);
            this.reloadButton.TabIndex = 1;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // dateComboBox
            // 
            this.dateComboBox.FormattingEnabled = true;
            this.dateComboBox.Location = new System.Drawing.Point(561, 45);
            this.dateComboBox.Name = "dateComboBox";
            this.dateComboBox.Size = new System.Drawing.Size(121, 21);
            this.dateComboBox.TabIndex = 2;
            // 
            // delPointButt
            // 
            this.delPointButt.Location = new System.Drawing.Point(561, 72);
            this.delPointButt.Name = "delPointButt";
            this.delPointButt.Size = new System.Drawing.Size(121, 32);
            this.delPointButt.TabIndex = 3;
            this.delPointButt.Text = "Delete Point";
            this.delPointButt.UseVisualStyleBackColor = true;
            this.delPointButt.Click += new System.EventHandler(this.delPointButt_Click);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 474);
            this.Controls.Add(this.delPointButt);
            this.Controls.Add(this.dateComboBox);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.CancerChart);
            this.Name = "ChartForm";
            this.Text = "Диаграмма рака";
            this.Load += new System.EventHandler(this.ChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CancerChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CancerChart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button delPointButt;
        private System.Windows.Forms.ComboBox dateComboBox;
    }
}

