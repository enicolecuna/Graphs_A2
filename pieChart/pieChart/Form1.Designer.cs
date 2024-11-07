namespace pieChart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelChart = new Panel();
            label1 = new Label();
            txtValues = new TextBox();
            btnDrawChart = new Button();
            label2 = new Label();
            txtLabels = new TextBox();
            panelLegend = new Panel();
            SuspendLayout();
            // 
            // panelChart
            // 
            panelChart.Location = new Point(67, 83);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(286, 235);
            panelChart.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 113);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Values";
            // 
            // txtValues
            // 
            txtValues.Location = new Point(446, 113);
            txtValues.Name = "txtValues";
            txtValues.Size = new Size(380, 23);
            txtValues.TabIndex = 2;
            // 
            // btnDrawChart
            // 
            btnDrawChart.Location = new Point(399, 295);
            btnDrawChart.Name = "btnDrawChart";
            btnDrawChart.Size = new Size(101, 23);
            btnDrawChart.TabIndex = 3;
            btnDrawChart.Text = "Draw Pie Chart";
            btnDrawChart.UseVisualStyleBackColor = true;
            btnDrawChart.Click += btnDrawChart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 172);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Labels";
            // 
            // txtLabels
            // 
            txtLabels.Location = new Point(446, 169);
            txtLabels.Name = "txtLabels";
            txtLabels.Size = new Size(380, 23);
            txtLabels.TabIndex = 5;
            // 
            // panelLegend
            // 
            panelLegend.Location = new Point(67, 338);
            panelLegend.Name = "panelLegend";
            panelLegend.Size = new Size(286, 100);
            panelLegend.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 612);
            Controls.Add(panelLegend);
            Controls.Add(txtLabels);
            Controls.Add(label2);
            Controls.Add(btnDrawChart);
            Controls.Add(txtValues);
            Controls.Add(label1);
            Controls.Add(panelChart);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelChart;
        private Label label1;
        private TextBox txtValues;
        private Button btnDrawChart;
        private Label label2;
        private TextBox txtLabels;
        private Panel panelLegend;
    }
}
