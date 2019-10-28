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

namespace graphics
{
    public partial class MainForm : Form
    {
        private Series sinusoid;
        private Series cosinusoid;
        public Boolean c = false;
        public Boolean s = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            c = !c;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool ok = true;
                errorP.Clear();
                if (!(s || c))
                {
                    MessageBox.Show("Не выбран график", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double min;
                min = double.Parse(minBox.Text);

                if (!double.TryParse(minBox.Text, out min))
                {
                    errorP.SetError(minBox, "Минимум задан некорректно");
                    ok = false;
                    return;
                }

                double max;
                max = double.Parse(maxBox.Text);

                if (!double.TryParse(maxBox.Text, out max))
                {
                    errorP.SetError(maxBox, "Максимум задан некорректно");
                    //errorP.SetIconAlignment(maxBox, ErrorIconAlignment);
                    ok = false;
                    return;
                }

                if (ok && (max <= min))
                {
                    errorP.SetError(maxBox, "Максимум меньше минимума");
                    errorP.SetError(minBox, "Минимум больше максимума");
                    return;
                }

                chart.ChartAreas[0].AxisX.Minimum = min;
                chart.ChartAreas[0].AxisX.Maximum = max;

                double delta = (max - min) / 100;
                double x = min;
                if (s)
                {
                    //Series sinusoid = chart.Series.Add("sin");
                    sinusoid = chart.Series.Add("sin");
                    sinusoid.ChartType = SeriesChartType.Spline;
                    sinusoid.Color = Color.DarkSeaGreen;
                    for (int i = 0; i <= 100; i++)
                    {
                        double y = Math.Sin(x);
                        sinusoid.Points.AddXY(x, y);
                        x += delta;
                    }
                }

                x = min;
                if (c)
                {
                    //Series cosinusoid = chart.Series.Add("cos");
                    cosinusoid = chart.Series.Add("cos");
                    cosinusoid.ChartType = SeriesChartType.Spline;
                    cosinusoid.Color = Color.Coral;
                    for (int i = 0; i <= 100; i++)
                    {
                        double y = Math.Cos(x);
                        cosinusoid.Points.AddXY(x, y);
                        x += delta;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                chart.Series.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sinx_CheckedChanged(object sender, EventArgs e)
        {
            s = !s;
        }

        private void min_TextChanged(object sender, EventArgs e)
        {

        }

        private void max_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart_Click(object sender, EventArgs e)
        {

        }
    }
}
