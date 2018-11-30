using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace NOAA_Monitor
{
    public partial class graphForm : MaterialForm
    {
        BuoyList data;
        public graphForm(BuoyList tmp)
        {
            data = tmp;
            InitializeComponent();
            comboBox1.Items.Add("Wind Speed");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
