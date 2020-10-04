using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiAOD_prak_1_3sem
{
    public partial class Form1 : Form
    {
        public void SplineChartExample(int check)
        {
            this.chart1.Series.Clear();
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("Norwegian krone");

            Series series = this.chart1.Series.Add("Exchange rate per 10");
            series.ChartType = SeriesChartType.Spline;
            
            switch (check)
            {
                case 1:
                    {
                        for (int i = 0; i < Class1.num; i++)
                        {
                            series.Points.AddXY(Class1.transs[i], Class1.transi[i]);
                        }
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < Class1.num; i += 30)
                        {
                            series.Points.AddXY(Class1.transs[i], Class1.transi[i]);
                        }
                        break;
                    }
                case 3:
                    {
                        for (int i = 0; i < Class1.num; i += 365)
                        {
                            series.Points.AddXY(Class1.transs[i], Class1.transi[i]);
                        }
                        break;
                    }
            }
        }

        public Form1()
        {
            InitializeComponent();
            //SplineChartExample();
        }

        

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SplineChartExample(1);
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SplineChartExample(2);
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SplineChartExample(3);
        }
    }
}
