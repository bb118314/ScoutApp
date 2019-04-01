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
    public partial class Preload : Form
    {
        public Preload()
        {
            InitializeComponent();
        }

        private void BtnNextScreen_Click(object sender, EventArgs e)
        {
            Autonomous formPreload = new Autonomous();
            this.Close();
            formPreload.Show();
        }

        private void BtnBackScreen_Click(object sender, EventArgs e)
        {
            frmRecordLog formPreload = new frmRecordLog();
            this.Close();
            formPreload.Show();
        }

       
    }
}
