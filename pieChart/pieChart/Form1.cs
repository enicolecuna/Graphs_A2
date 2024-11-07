namespace pieChart
{
    public partial class Form1 : Form
    {// Class-level variables for storing angles
        private List<float> angles = new List<float>(); // Store calculated angles for slices
        private List<string> labels = new List<string>(); // Store labels for legend
        private List<Color> sliceColors = new List<Color>(); // list for colors

        public Form1()
        {
            InitializeComponent();
            panelChart.Paint += PanelChart_Paint;

        }

        private void btnDrawChart_Click(object sender, EventArgs e)
        {

            // splits by comma
            string[] valueStrings = txtValues.Text.Split(',');
            string[] labelStrings = txtLabels.Text.Split(',');

            //check if they match in length
            if (valueStrings.Length != labelStrings.Length)
            {
                MessageBox.Show("Please ensure the number of labels matches the number of values.", "Input Error");
                return;
            }
            try
            {
                //turns values from strings to integers
                int[] values = Array.ConvertAll(valueStrings, int.Parse);
                // Total of all values
                int total = values.Sum(); 

                // checks if all values are positive
                if (values.Any(v => v <= 0))
                {
                    MessageBox.Show("All values must be positive only.", "Input Error");
                    return;
                }

                //clear the previous inputs and chart
                angles.Clear();
                labels.Clear();
                sliceColors.Clear();


                // loop through the values so for each it computes for angles 
                for (int i = 0; i < values.Length; i++)
                {
                    float angle = (float)values[i] / total * 360;
                    angles.Add(angle);//add the computed angles in angles list
                    labels.Add($"{labelStrings[i].Trim()}: {values[i]}"); // Use custom label with value

                    // Generate or select a color for each slice
                    if (i < 10) // Use predefined colors for the first 10 slices
                    {
                        Color[] predefinedColors = { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Purple, Color.Orange, Color.Pink, Color.Brown, Color.Cyan, Color.Magenta };
                        sliceColors.Add(predefinedColors[i]);
                    }
                    else // Generate a random color for more slices
                    {
                        sliceColors.Add(GenerateRandomColor());
                    }
                }

                // Redraw the panel
                panelChart.Invalidate();

                // Update the legend
                UpdateLegend();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for values.", "Input Error");
            }
        }
        private Color GenerateRandomColor()
        {
            // Generate a random color
            Random rand = new Random();
            return Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)); 
            
        }

        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {
            // Draw the pie chart
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(10, 10, panelChart.Width - 20, panelChart.Height - 20);

            float startAngle = 0;

            for (int i = 0; i < angles.Count; i++)
            {
                Brush brush = new SolidBrush(sliceColors[i]); // Use color from the dynamic list
                g.FillPie(brush, rect, startAngle, angles[i]);
                startAngle += angles[i];
            }
        }

        private void UpdateLegend()
        {
            panelLegend.Controls.Clear();

            for (int i = 0; i < labels.Count; i++)
            {
                Label lbl = new Label
                {
                    Text = labels[i],
                    ForeColor = sliceColors[i], // Match color with slice
                    Location = new Point(10, 10 + (i * 20))
                };
                panelLegend.Controls.Add(lbl);
            }

        }
    }
}
