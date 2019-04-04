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
    public partial class frmRecordLog : Form
    {
        public frmRecordLog()
        {
            InitializeComponent();
        }

        public class valuesForm
        {
            public static String eventID = "";
            public static String teamID = "";
            public static String matchNum = "";
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            PreloadForm form2 = new PreloadForm();
            form2.Show();
            this.Visible = false;
        }

        private void chkBox1AllianceID_CheckedChanged(object sender, EventArgs e)
        {
            if(rBtn1AllianceID.Checked==true)
            {
                
            }
        }

        private void tbEvent_TextChanged(object sender, EventArgs e)
        {
            valuesForm.eventID = tbEvent.Text;
        }

        private void tbMatchNum_TextChanged(object sender, EventArgs e)
        {
            valuesForm.matchNum = tbMatchNum.Text;
        }

        private void tbTeamNum_TextChanged(object sender, EventArgs e)
        {
            valuesForm.teamID = tbTeamNum.Text;
        }
    }
}
