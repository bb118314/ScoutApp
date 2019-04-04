using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EndGame : Form
    {
        public EndGame()
        {
            InitializeComponent();
        }

        public class valuesEnd
        {
            public static int position = 0;
        }

            private void BtnNextScreen_Click(object sender, EventArgs e)
        {
            FRC_Statistics form5 = new FRC_Statistics();
            this.Close();
            form5.Show();
        }

        private void cBoxDidGetBackOnPlatform_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxDidGetBackOnPlatform.Checked == true)
            {
                rbHigh.Visible = true;
                rbMed.Visible = true;
                rbLow.Visible = true;
            }
            else if (cBoxDidGetBackOnPlatform.Checked == false)
            {
                rbHigh.Visible = false;
                rbMed.Visible = false;
                rbLow.Visible = false;
            }
        }

        private void rbHigh_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHigh.Checked == true)
            {
                valuesEnd.position = 3;
            }

            else if (rbMed.Checked == true)
            {
                valuesEnd.position = 2;
            }

            else if (rbLow.Checked == true)
            {
                valuesEnd.position = 1;
            }
        }

        private void rbMed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHigh.Checked == true)
            {
                valuesEnd.position = 3;
            }

            else if (rbMed.Checked == true)
            {
                valuesEnd.position = 2;
            }

            else if (rbLow.Checked == true)
            {
                valuesEnd.position = 1;
            }
        }

        private void rbLow_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHigh.Checked == true)
            {
                valuesEnd.position = 3;
            }

            else if (rbMed.Checked == true)
            {
                valuesEnd.position = 2;
            }

            else if (rbLow.Checked == true)
            {
                valuesEnd.position = 1;
            }
        }
    }
}
