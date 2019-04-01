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
    public partial class PreloadForm : Form
    {
        public PreloadForm()
        {
            InitializeComponent();

            groupBox1.Visible = false;
            groupBox2.Visible = true;


            rBtn1.Visible = false;
            rBtn2.Visible = false;
            rBtn3.Visible = false;
            rBtn4.Visible = false;
            rBtn5.Visible = false;
            rBtn6.Visible = false;
            rBtn7.Visible = false;
            rBtn8.Visible = false;

        }

        private void rBtnCargo_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void rBtnHatch_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void rBtnSideA_CheckedChanged(object sender, EventArgs e)
        {
            rBtn1.Visible = true;
            rBtn2.Visible = true;
            rBtn3.Visible = true;
            rBtn4.Visible = false;
            rBtn5.Visible = false;
            rBtn6.Visible = false;
            rBtn7.Visible = false;
            rBtn8.Visible = false;

        }

        private void rBtnSideB_CheckedChanged(object sender, EventArgs e)
        {
            rBtn1.Visible = false;
            rBtn2.Visible = false;
            rBtn3.Visible = false;
            rBtn4.Visible = true;
            rBtn5.Visible = true;
            rBtn6.Visible = false;
            rBtn7.Visible = false;
            rBtn8.Visible = false;
        }

        private void rBtnSideC_CheckedChanged(object sender, EventArgs e)
        {
            rBtn1.Visible = false;
            rBtn2.Visible = false;
            rBtn3.Visible = false;
            rBtn4.Visible = false;
            rBtn5.Visible = false;
            rBtn6.Visible = true;
            rBtn7.Visible = true;
            rBtn8.Visible = true;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            Autonomous form3 = new Autonomous();
            this.Close();
            form3.Show();
        }

        private void PreloadForm_Load(object sender, EventArgs e)
        {

        }
    }
}
