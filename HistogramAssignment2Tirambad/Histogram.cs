using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MUtilities.Utilities;

namespace HistogramAssignment2Tirambad
{
    public partial class Histogram : Form
    {

        public int[] data;
        public string title;
        public double mean;
        public double variance;

        public Histogram()
        {
            InitializeComponent();
                     
        }


        private void UpdateChartSettings()
        {
              // Create a histogram series

            Helper helper = new Helper();
            helper.SegmentIntervalNumber = 10;

            helper.CreateHistogram(chart1, "RawData", "Histogram");

            this.label1.Text = this.title;
            this.label2.Text = "Mean = "+this.mean;
            this.label3.Text = "Variance = " + String.Format("{0:0.00}", this.variance);
               
        }

        
        private void PieChartType_Load(object sender, EventArgs e)
        {
            // Populate chart with frequency count per bit
            for (int j = 0; j < data.Length; j++)
            {
               chart1.Series["RawData"].Points.AddY(data[j]);
            }

            // Update chart
            UpdateChartSettings();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.SaveImage("F:\\CS740\\" + this.title +".png", ChartImageFormat.Png);
            
           
	
        }

        

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
