using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem10
{
    public partial class Form1 : Form
    {
        float total;
        public Form1()
        {
            InitializeComponent();
            total = 0f;
        }

        private void PizzaSize_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSmallSize.Checked)
            {
                total = 10;
            }
            else if (rdoMediumSize.Checked)
            {
                total = 15;
            }
            else
            {
                total = 20;
            }

            txtTotal.Text = String.Format("{0:C}", total);

        }
    }
}