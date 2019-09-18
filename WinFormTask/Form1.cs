using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCount_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBoxX.Text);
                double y = Convert.ToDouble(textBoxY.Text);
                double z = Convert.ToDouble(textBoxZ.Text);
                double s;
                s = (2 * Math.Cos(Math.Pow(x, 2)) - 0.5) / (0.5 + Math.Sin(Math.Pow(y, 2 - z))) + (Math.Pow(z, 2) / (7 - z / 3));

                textBoxCount.Text = s.ToString("F2");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Помилка введення значення z!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }
    }
}
