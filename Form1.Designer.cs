namespace FinanceProject
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DailyValuesTableButtonPanel = new System.Windows.Forms.Panel();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TransactionsButton = new System.Windows.Forms.Button();
            this.StartDate = new System.Windows.Forms.Label();
            this.TickerLabel = new System.Windows.Forms.Label();
            this.TransactionsStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TransactionsLabel = new System.Windows.Forms.Label();
            this.TransactionsReportDataGridView = new System.Windows.Forms.DataGridView();
            this.PnLReportDataGridView = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InsertNewTradesButton = new System.Windows.Forms.Button();
            this.PnLlabel = new System.Windows.Forms.Label();
            this.DailyValuesTableButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsReportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnLReportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // DailyValuesTableButtonPanel
            // 
            this.DailyValuesTableButtonPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DailyValuesTableButtonPanel.Controls.Add(this.endDateLabel);
            this.DailyValuesTableButtonPanel.Controls.Add(this.endDateTimePicker);
            this.DailyValuesTableButtonPanel.Controls.Add(this.TransactionsButton);
            this.DailyValuesTableButtonPanel.Controls.Add(this.StartDate);
            this.DailyValuesTableButtonPanel.Controls.Add(this.TickerLabel);
            this.DailyValuesTableButtonPanel.Controls.Add(this.TransactionsStartDatePicker);
            this.DailyValuesTableButtonPanel.Controls.Add(this.comboBox1);
            this.DailyValuesTableButtonPanel.Location = new System.Drawing.Point(7, 12);
            this.DailyValuesTableButtonPanel.Name = "DailyValuesTableButtonPanel";
            this.DailyValuesTableButtonPanel.Size = new System.Drawing.Size(1852, 107);
            this.DailyValuesTableButtonPanel.TabIndex = 4;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(1087, 12);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(225, 55);
            this.endDateLabel.TabIndex = 17;
            this.endDateLabel.Text = "End Date";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(1347, 10);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(290, 61);
            this.endDateTimePicker.TabIndex = 16;
            this.endDateTimePicker.Value = new System.DateTime(2020, 12, 24, 0, 0, 0, 0);
            // 
            // TransactionsButton
            // 
            this.TransactionsButton.Location = new System.Drawing.Point(1678, 9);
            this.TransactionsButton.Name = "TransactionsButton";
            this.TransactionsButton.Size = new System.Drawing.Size(156, 68);
            this.TransactionsButton.TabIndex = 13;
            this.TransactionsButton.Text = "Get";
            this.TransactionsButton.UseVisualStyleBackColor = true;
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.BackColor = System.Drawing.SystemColors.Control;
            this.StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Location = new System.Drawing.Point(485, 13);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(240, 55);
            this.StartDate.TabIndex = 12;
            this.StartDate.Text = "Start Date";
            // 
            // TickerLabel
            // 
            this.TickerLabel.AutoSize = true;
            this.TickerLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TickerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TickerLabel.Location = new System.Drawing.Point(1, 14);
            this.TickerLabel.Name = "TickerLabel";
            this.TickerLabel.Size = new System.Drawing.Size(154, 55);
            this.TickerLabel.TabIndex = 11;
            this.TickerLabel.Text = "Ticker";
            // 
            // TransactionsStartDatePicker
            // 
            this.TransactionsStartDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsStartDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TransactionsStartDatePicker.Location = new System.Drawing.Point(760, 9);
            this.TransactionsStartDatePicker.Name = "TransactionsStartDatePicker";
            this.TransactionsStartDatePicker.Size = new System.Drawing.Size(297, 61);
            this.TransactionsStartDatePicker.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(196, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 62);
            this.comboBox1.TabIndex = 9;
            // 
            // TransactionsLabel
            // 
            this.TransactionsLabel.AutoSize = true;
            this.TransactionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsLabel.Location = new System.Drawing.Point(186, 198);
            this.TransactionsLabel.Name = "TransactionsLabel";
            this.TransactionsLabel.Size = new System.Drawing.Size(457, 55);
            this.TransactionsLabel.TabIndex = 8;
            this.TransactionsLabel.Text = "Transactions Report";
            // 
            // TransactionsReportDataGridView
            // 
            this.TransactionsReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionsReportDataGridView.Location = new System.Drawing.Point(6, 291);
            this.TransactionsReportDataGridView.Name = "TransactionsReportDataGridView";
            this.TransactionsReportDataGridView.RowHeadersWidth = 102;
            this.TransactionsReportDataGridView.RowTemplate.Height = 40;
            this.TransactionsReportDataGridView.Size = new System.Drawing.Size(826, 1312);
            this.TransactionsReportDataGridView.TabIndex = 5;
            // 
            // PnLReportDataGridView
            // 
            this.PnLReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PnLReportDataGridView.Location = new System.Drawing.Point(865, 291);
            this.PnLReportDataGridView.Name = "PnLReportDataGridView";
            this.PnLReportDataGridView.RowHeadersWidth = 102;
            this.PnLReportDataGridView.RowTemplate.Height = 40;
            this.PnLReportDataGridView.Size = new System.Drawing.Size(934, 1312);
            this.PnLReportDataGridView.TabIndex = 6;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(1815, 291);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(951, 1312);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chartPrices";
            // 
            // InsertNewTradesButton
            // 
            this.InsertNewTradesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertNewTradesButton.Location = new System.Drawing.Point(1865, 12);
            this.InsertNewTradesButton.Name = "InsertNewTradesButton";
            this.InsertNewTradesButton.Size = new System.Drawing.Size(901, 273);
            this.InsertNewTradesButton.TabIndex = 8;
            this.InsertNewTradesButton.Text = "Insert New Trade";
            this.InsertNewTradesButton.UseVisualStyleBackColor = true;
            this.InsertNewTradesButton.Click += new System.EventHandler(this.InsertNewTradesButton_Click);
            // 
            // PnLlabel
            // 
            this.PnLlabel.AutoSize = true;
            this.PnLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnLlabel.Location = new System.Drawing.Point(1181, 198);
            this.PnLlabel.Name = "PnLlabel";
            this.PnLlabel.Size = new System.Drawing.Size(268, 55);
            this.PnLlabel.TabIndex = 9;
            this.PnLlabel.Text = "PnL Report";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2795, 1644);
            this.Controls.Add(this.PnLlabel);
            this.Controls.Add(this.InsertNewTradesButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.PnLReportDataGridView);
            this.Controls.Add(this.TransactionsReportDataGridView);
            this.Controls.Add(this.DailyValuesTableButtonPanel);
            this.Controls.Add(this.TransactionsLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DailyValuesTableButtonPanel.ResumeLayout(false);
            this.DailyValuesTableButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnLReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel DailyValuesTableButtonPanel;
        private System.Windows.Forms.DataGridView TransactionsReportDataGridView;
        private System.Windows.Forms.DataGridView PnLReportDataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label TransactionsLabel;
        private System.Windows.Forms.Button InsertNewTradesButton;
        private System.Windows.Forms.DateTimePicker TransactionsStartDatePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button TransactionsButton;
        private System.Windows.Forms.Label StartDate;
        private System.Windows.Forms.Label TickerLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label PnLlabel;
    }
}

