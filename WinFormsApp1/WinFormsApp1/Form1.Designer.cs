namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            NTextBox = new TextBox();
            MTextBox = new TextBox();
            pTextBox = new TextBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 31);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // NTextBox
            // 
            NTextBox.Location = new Point(134, 55);
            NTextBox.Margin = new Padding(3, 4, 3, 4);
            NTextBox.Name = "NTextBox";
            NTextBox.Size = new Size(100, 27);
            NTextBox.TabIndex = 1;
            NTextBox.Text = "8";
            // 
            // MTextBox
            // 
            MTextBox.Location = new Point(12, 55);
            MTextBox.Margin = new Padding(3, 4, 3, 4);
            MTextBox.Name = "MTextBox";
            MTextBox.Size = new Size(100, 27);
            MTextBox.TabIndex = 2;
            MTextBox.Text = "8";
            // 
            // pTextBox
            // 
            pTextBox.Location = new Point(264, 55);
            pTextBox.Margin = new Padding(3, 4, 3, 4);
            pTextBox.Name = "pTextBox";
            pTextBox.Size = new Size(100, 27);
            pTextBox.TabIndex = 3;
            pTextBox.Text = "0.5";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart1.Legends.Add(legend3);
            chart1.Location = new Point(38, 142);
            chart1.Margin = new Padding(3, 4, 3, 4);
            chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart1.Series.Add(series3);
            chart1.Size = new Size(584, 375);
            chart1.TabIndex = 4;
            chart1.Text = "chart1";
            // 
            // button1
            // 
            button1.Location = new Point(12, 90);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 5;
            button1.Text = "Button";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SimulateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 562);
            Controls.Add(button1);
            Controls.Add(chart1);
            Controls.Add(pTextBox);
            Controls.Add(MTextBox);
            Controls.Add(NTextBox);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NTextBox;
        private TextBox MTextBox;
        private TextBox pTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button button1;
    }
}