
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
    public partial class Autonomous : Form
    {

        public Autonomous()
        {
            InitializeComponent();

        }
        // values Driver Controlled
        public class valuesA
        {
            // All ints below are for the rocket misses
            public static int sideALow = 0;
            public static int sideAMed = 0;
            public static int sideAHigh = 0;
            public static int sideBLow = 0;
            public static int sideBMed = 0;
            public static int sideBHigh = 0;
            public static int cargoHigh = 0;
            public static int cargoMed = 0;
            public static int cargoLow = 0;

            public static int sideALow2 = 0;
            public static int sideAMed2 = 0;
            public static int sideAHigh2 = 0;
            public static int sideBLow2 = 0;
            public static int sideBMed2 = 0;
            public static int sideBHigh2 = 0;
            public static int cargoHigh2 = 0;
            public static int cargoMed2 = 0;
            public static int cargoLow2 = 0;

            // Below are for rocket successes
            public static Boolean sideALowS = false;
            public static Boolean sideAMedS = false;
            public static Boolean sideAHighS = false;
            public static Boolean sideBLowS = false;
            public static Boolean sideBMedS = false;
            public static Boolean sideBHighS = false;
            public static int cargoHighS = 0;
            public static int cargoMedS = 0;
            public static int cargoLowS = 0;

            public static Boolean sideALowS2 = false;
            public static Boolean sideAMedS2 = false;
            public static Boolean sideAHighS2 = false;
            public static Boolean sideBLowS2 = false;
            public static Boolean sideBMedS2 = false;
            public static Boolean sideBHighS2 = false;
            public static int cargoHighS2 = 0;
            public static int cargoMedS2 = 0;
            public static int cargoLowS2 = 0;

            // Completed for Shuttle
            public static int shuttle1;
            public static int shuttle2;
            public static int shuttle3;
            public static int shuttle4;
            public static int shuttle5;
            public static int shuttle6;
            public static int shuttle7;
            public static int shuttle8;
            public static int shuttle9;
            public static int shuttle10;
            public static int shuttle11;
            public static int shuttle12;
            public static int shuttle13;
            public static int shuttle14;
            public static int shuttle15;
            public static int shuttle16;
        }

        private void DriverControlled_Load(object sender, EventArgs e)
        {

        }

        private void BtnAttempted_1_Click(object sender, EventArgs e)
        {
            if (rBtnLow.Checked == true)
            {
                lblAttempted.Text = "" + valuesA.sideALow;
                valuesA.sideALow = valuesA.sideALow + 1;
            }
            else if (rBtnMedium.Checked == true)
            {
                lblAttempted.Text = "" + valuesA.sideAMed;
                valuesA.sideAMed = valuesA.sideAMed + 1;
            }
            else if (rBtnHigh.Checked == true)
            {
                lblAttempted.Text = "" + valuesA.sideAHigh;
                valuesA.sideAHigh = valuesA.sideAHigh + 1;
            }

        }

        private void lblAttempted_Click(object sender, EventArgs e)
        {

        }

        private void rBtnLow_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted.Text = "" + valuesA.sideALow;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted.Text = "";
            if (rBtnLow.Checked == true)
            {
                lblAttempted.Text = "" + valuesA.sideALow;
            }
            else if (rBtnMedium.Checked == true)
            {
                lblAttempted.Text = "" + valuesA.sideAMed;
            }
            else if (rBtnHigh.Checked == true)
            {
                lblAttempted.Text = "" + valuesA.sideAHigh;
            }
        }

        private void BtnNextScreenDriverStation_Click(object sender, EventArgs e)
        {
            gb form4 = new gb();
            this.Close();
            form4.Show();
        }

        private void BtnMinus_1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (rBtnLowTop.Checked == true)
                {
                    valuesA.cargoLow = valuesA.cargoLow - 1;
                    lblAttempted.Text = "" + valuesA.cargoLow;
                }
                else if (rBtnMediumTop.Checked == true)
                {
                    valuesA.cargoMed = valuesA.cargoMed - 1;
                    lblAttempted.Text = "" + valuesA.cargoMed;
                }
                else if (rBtnHighTop.Checked == true)
                {
                    valuesA.cargoHigh = valuesA.cargoHigh - 1;
                    lblAttempted.Text = "" + valuesA.cargoHigh;
                }
            }
            if (radioButton1.Checked == true)
            {
                if (btnATop.Checked == true)
                {
                    if (rBtnLowTop.Checked == true)
                    {

                        valuesA.sideALow = valuesA.sideALow - 1;
                        lblAttempted.Text = "" + valuesA.sideALow;

                    }
                    else if (rBtnMediumTop.Checked == true)
                    {
                        valuesA.sideAMed = valuesA.sideAMed - 1;
                        lblAttempted.Text = "" + valuesA.sideAMed;
                    }
                    else if (rBtnHighTop.Checked == true)
                    {
                        valuesA.sideAHigh = valuesA.sideAHigh - 1;
                        lblAttempted.Text = "" + valuesA.sideAHigh;
                    }
                }
                else if (btnBTop.Checked == true)
                {
                    if (rBtnLowTop.Checked == true)
                    {
                        valuesA.sideBLow = valuesA.sideBLow - 1;
                        lblAttempted.Text = "" + valuesA.sideBLow;
                    }
                    else if (rBtnMediumTop.Checked == true)
                    {
                        valuesA.sideBMed = valuesA.sideBMed - 1;
                        lblAttempted.Text = "" + valuesA.sideBMed;
                    }
                    else if (rBtnHighTop.Checked == true)
                    {
                        valuesA.sideBHigh = valuesA.sideBHigh - 1;
                        lblAttempted.Text = "" + valuesA.sideBHigh;

                    }
                }
            }
        }

        private void rBtnMedium_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted.Text = "" + valuesA.sideAMed;
        }

        private void rBtnHigh_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted.Text = "" + valuesA.sideAHigh;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (rBtnLowTop.Checked == true)
                {
                    valuesA.cargoLow = valuesA.cargoLow + 1;
                    lblAttempted.Text = "" + valuesA.cargoLow;
                }
                else if (rBtnMediumTop.Checked == true)
                {
                    valuesA.cargoMed = valuesA.cargoMed + 1;
                    lblAttempted.Text = "" + valuesA.cargoMed;
                }
                else if (rBtnHighTop.Checked == true)
                {
                    valuesA.cargoHigh = valuesA.cargoHigh + 1;
                    lblAttempted.Text = "" + valuesA.cargoHigh;
                }
            }
            if (radioButton1.Checked == true)
            {
                if (btnATop.Checked == true)
                {
                    if (rBtnLowTop.Checked == true)
                    {

                        valuesA.sideALow = valuesA.sideALow + 1;
                        lblAttempted.Text = "" + valuesA.sideALow;
                    }
                    else if (rBtnMediumTop.Checked == true)
                    {

                        valuesA.sideAMed = valuesA.sideAMed + 1;
                        lblAttempted.Text = "" + valuesA.sideAMed;
                    }
                    else if (rBtnHighTop.Checked == true)
                    {
                        valuesA.sideAHigh = valuesA.sideAHigh + 1;
                        lblAttempted.Text = "" + valuesA.sideAHigh;
                    }
                }
                else if (btnBTop.Checked == true)
                {
                    if (rBtnLowTop.Checked == true)
                    {
                        valuesA.sideBLow = valuesA.sideBLow + 1;
                        lblAttempted.Text = "" + valuesA.sideBLow;
                    }
                    else if (rBtnMediumTop.Checked == true)
                    {
                        valuesA.sideBMed = valuesA.sideBMed + 1;
                        lblAttempted.Text = "" + valuesA.sideBMed;
                    }
                    else if (rBtnHighTop.Checked == true)
                    {
                        valuesA.sideBHigh = valuesA.sideBHigh + 1;
                        lblAttempted.Text = "" + valuesA.sideBHigh;
                    }
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted.Text = "";
            rBtnHighTop.Checked = false;
            rBtnMediumTop.Checked = false;
            rBtnLowTop.Checked = false;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rBtnRocket.Checked == true)
            {
                gbSideTop.Visible = true;
                label1.Visible = true;
                label3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                groupBox4.Visible = true;
                groupBox2.Visible = true;
                gbHeightTop.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label7.Visible = true;
                lblAttempted.Visible = true;
                lblAttempted2.Visible = true;
                BtnMinus1.Visible = true;
                btnMinus2.Visible = true;
                btnAdd1.Visible = true;
                btnAdd2.Visible = true;
                gbS.Visible = false;
                gbS2.Visible = true;
                gbS3.Visible = false;
                gbS4.Visible = true;
                groupBox7.Visible = false;
                groupBox8.Visible = false;
                groupBox9.Visible = false;

            }
            else if (rBtnShuttle.Checked == true)
            {
                cBoxShuttle1.Visible = true;
                cBoxShuttle2.Visible = true;
                cBoxShuttle3.Visible = true;
                cBoxShuttle4.Visible = true;
                cBoxShuttle5.Visible = true;
                cBoxShuttle6.Visible = true;
                cBoxShuttle7.Visible = true;
                cBoxShuttle8.Visible = true;
            }
            cBoxShuttle10.Visible = false;
            cBoxShuttle11.Visible = false;
            cBoxShuttle12.Visible = false;
            cBoxShuttle13.Visible = false;
            cBoxShuttle9.Visible = false;
            cBoxShuttle14.Visible = false;
            cBoxShuttle15.Visible = false;
            cBoxShuttle16.Visible = false;
        }



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnRocket.Checked == true)
            {
                gbSideTop.Visible = false;
                label1.Visible = false;
                label3.Visible = false;
                groupBox4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                gbHeightTop.Visible = true;
                groupBox2.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label7.Visible = true;
                lblAttempted.Visible = true;
                lblAttempted2.Visible = true;
                BtnMinus1.Visible = true;
                btnMinus2.Visible = true;
                btnAdd1.Visible = true;
                btnAdd2.Visible = true;
                gbS.Visible = true;
                gbS2.Visible = false;
                gbS3.Visible = true;
                gbS4.Visible = false;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                groupBox9.Visible = true;
                lblAttempted2.Text = "";
                lblAttempted.Text = "";
                cBoxShuttle1.Visible = false;
                cBoxShuttle2.Visible = false;
                cBoxShuttle3.Visible = false;
                cBoxShuttle4.Visible = false;
                cBoxShuttle5.Visible = false;
                cBoxShuttle6.Visible = false;
                cBoxShuttle7.Visible = false;
                cBoxShuttle8.Visible = false;
                rBtnHighTop.Checked = false;
                rBtnMediumTop.Checked = false;
                rBtnLowTop.Checked = false;
                rBtnHighLow.Checked = false;
                rBtnMediumLow.Checked = false;
                rBtnLowLow.Checked = false;
            }

            else if (rBtnShuttle.Checked == true)
            {
                cBoxShuttle1.Visible = false;
                cBoxShuttle2.Visible = false;
                cBoxShuttle3.Visible = false;
                cBoxShuttle4.Visible = false;
                cBoxShuttle5.Visible = false;
                cBoxShuttle6.Visible = false;
                cBoxShuttle7.Visible = false;
                cBoxShuttle8.Visible = false;
                cBoxShuttle9.Visible = true;
                cBoxShuttle10.Visible = true;
                cBoxShuttle11.Visible = true;
                cBoxShuttle12.Visible = true;
                cBoxShuttle13.Visible = true;
                cBoxShuttle14.Visible = true;
                cBoxShuttle15.Visible = true;
                cBoxShuttle16.Visible = true;

            }
        }

        private void rBtnLowTop_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblAttempted.Text = "" + valuesA.cargoLow;
            }
            else if (radioButton1.Checked == true)
            {
                if (btnATop.Checked == true)
                {
                    lblAttempted.Text = "" + valuesA.sideALow;
                }
                if (btnBTop.Checked == true)
                {
                    lblAttempted.Text = "" + valuesA.sideBLow;
                }
            }
        }

        private void rBtnMediumTop_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblAttempted.Text = "" + valuesA.cargoMed;
            }
            else if (radioButton1.Checked == true)
            {
                if (btnATop.Checked == true)
                {
                    lblAttempted.Text = "" + valuesA.sideAMed;
                }
                if (btnBTop.Checked == true)
                {
                    lblAttempted.Text = "" + valuesA.sideBMed;
                }
            }
        }

        private void rBtnHighTop_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblAttempted.Text = "" + valuesA.cargoHigh;
            }
            else if (radioButton1.Checked == true)
            {
                if (btnATop.Checked == true)
                {
                    lblAttempted.Text = "" + valuesA.sideAHigh;
                }
                if (btnBTop.Checked == true)
                {
                    lblAttempted.Text = "" + valuesA.sideBHigh;
                }
            }
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (rBtnLowLow.Checked == true)
                {
                    valuesA.cargoLow2 = valuesA.cargoLow2 + 1;
                    lblAttempted2.Text = "" + valuesA.cargoLow2;
                }
                else if (rBtnMediumLow.Checked == true)
                {
                    valuesA.cargoMed2 = valuesA.cargoMed2 + 1;
                    lblAttempted2.Text = "" + valuesA.cargoMed2;
                }
                else if (rBtnHighLow.Checked == true)
                {
                    valuesA.cargoHigh2 = valuesA.cargoHigh2 + 1;
                    lblAttempted2.Text = "" + valuesA.cargoHigh2;
                }
            }
            if (radioButton1.Checked == true)
            {
                if (btnALow.Checked == true)
                {
                    if (rBtnLowLow.Checked == true)
                    {

                        valuesA.sideALow2 = valuesA.sideALow2 + 1;
                        lblAttempted2.Text = "" + valuesA.sideALow2;
                    }
                    else if (rBtnMediumLow.Checked == true)
                    {

                        valuesA.sideAMed2 = valuesA.sideAMed2 + 1;
                        lblAttempted2.Text = "" + valuesA.sideAMed2;
                    }
                    else if (rBtnHighLow.Checked == true)
                    {

                        valuesA.sideAHigh2 = valuesA.sideAHigh2 + 1;
                        lblAttempted2.Text = "" + valuesA.sideAHigh2;
                    }
                }
                else if (btnBLow.Checked == true)
                {
                    if (rBtnLowLow.Checked == true)
                    {
                        valuesA.sideBLow2 = valuesA.sideBLow2 + 1;
                        lblAttempted2.Text = "" + valuesA.sideBLow2;
                    }
                    else if (rBtnMediumLow.Checked == true)
                    {
                        valuesA.sideBMed2 = valuesA.sideBMed2 + 1;
                        lblAttempted2.Text = "" + valuesA.sideBMed2;
                    }
                    else if (rBtnHighLow.Checked == true)
                    {
                        valuesA.sideBHigh2 = valuesA.sideBHigh2 + 1;
                        lblAttempted2.Text = "" + valuesA.sideBHigh2;
                    }
                }
            }
        }

        private void btnBTop_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted.Text = "";
            rBtnHighTop.Checked = false;
            rBtnMediumTop.Checked = false;
            rBtnLowTop.Checked = false;
        }

        private void btnALow_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted2.Text = "";
            rBtnHighLow.Checked = false;
            rBtnMediumLow.Checked = false;
            rBtnLowLow.Checked = false;
        }

        private void btnBLow_CheckedChanged(object sender, EventArgs e)
        {
            lblAttempted2.Text = "";
            rBtnHighLow.Checked = false;
            rBtnMediumLow.Checked = false;
            rBtnLowLow.Checked = false;
        }

        private void rBtnLowLow_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblAttempted2.Text = "" + valuesA.cargoLow2;
            }
            else if (radioButton1.Checked == true)
            {
                if (btnALow.Checked == true)
                {
                    lblAttempted2.Text = "" + valuesA.sideALow2;
                }
                if (btnBTop.Checked == true)
                {
                    lblAttempted2.Text = "" + valuesA.sideBLow2;
                }
            }
        }

        private void rBtnMediumLow_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblAttempted2.Text = "" + valuesA.cargoMed2;
            }
            else if (radioButton1.Checked == true)
            {
                if (btnALow.Checked == true)
                {
                    lblAttempted2.Text = "" + valuesA.sideAMed2;
                }
                if (btnBLow.Checked == true)
                {
                    lblAttempted2.Text = "" + valuesA.sideBMed2;
                }
            }
        }

        private void rBtnHighLow_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                lblAttempted2.Text = "" + valuesA.cargoHigh2;
            }
            else if (radioButton1.Checked == true)
            {
                if (btnALow.Checked == true)
                {
                    lblAttempted2.Text = "" + valuesA.sideAHigh2;
                }
                if (btnBLow.Checked == true)
                {
                    lblAttempted2.Text = "" + valuesA.sideBHigh2;
                }
            }
        }

        private void btnMinus2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (rBtnLowLow.Checked == true)
                {
                    valuesA.cargoLow2 = valuesA.cargoLow2 - 1;
                    lblAttempted2.Text = "" + valuesA.cargoLow2;

                }
                else if (rBtnMediumLow.Checked == true)
                {
                    valuesA.cargoMed2 = valuesA.cargoMed2 - 1;
                    lblAttempted2.Text = "" + valuesA.cargoMed2;

                }
                else if (rBtnHighLow.Checked == true)
                {
                    valuesA.cargoHigh2 = valuesA.cargoHigh2 - 1;
                    lblAttempted2.Text = "" + valuesA.cargoHigh2;

                }
            }
            if (radioButton1.Checked == true)
            {
                if (btnALow.Checked == true)
                {
                    if (rBtnLowLow.Checked == true)
                    {

                        valuesA.sideALow2 = valuesA.sideALow2 - 1;
                        lblAttempted2.Text = "" + valuesA.sideALow2;


                    }
                    else if (rBtnMediumLow.Checked == true)
                    {
                        valuesA.sideAMed2 = valuesA.sideAMed2 - 1;
                        lblAttempted2.Text = "" + valuesA.sideAMed2;

                    }
                    else if (rBtnHighLow.Checked == true)
                    {
                        valuesA.sideAHigh2 = valuesA.sideAHigh2 - 1;
                        lblAttempted.Text = "" + valuesA.sideAHigh2;

                    }
                }
                else if (btnBLow.Checked == true)
                {
                    if (rBtnLowLow.Checked == true)
                    {
                        valuesA.sideBLow2 = valuesA.sideBLow2 - 1;
                        lblAttempted2.Text = "" + valuesA.sideBLow2;

                    }
                    else if (rBtnMediumLow.Checked == true)
                    {
                        valuesA.sideBMed2 = valuesA.sideBMed2 - 1;
                        lblAttempted2.Text = "" + valuesA.sideBMed2;

                    }
                    else if (rBtnHighLow.Checked == true)
                    {
                        valuesA.sideBHigh2 = valuesA.sideBHigh2 - 1;
                        lblAttempted2.Text = "" + valuesA.sideBHigh2;

                    }
                }
            }
        }

        private void rBtnRocket_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            cBoxShuttle1.Visible = false;
            cBoxShuttle2.Visible = false;
            cBoxShuttle3.Visible = false;
            cBoxShuttle4.Visible = false;
            cBoxShuttle5.Visible = false;
            cBoxShuttle6.Visible = false;
            cBoxShuttle7.Visible = false;
            cBoxShuttle8.Visible = false;
            cBoxShuttle9.Visible = false;
            cBoxShuttle10.Visible = false;
            cBoxShuttle11.Visible = false;
            cBoxShuttle12.Visible = false;
            cBoxShuttle13.Visible = false;
            cBoxShuttle14.Visible = false;
            cBoxShuttle15.Visible = false;
            cBoxShuttle16.Visible = false;
            groupBox3.Visible = true;
        }

        private void rBtnShuttle_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            gbSideTop.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            groupBox4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            gbHeightTop.Visible = false;
            groupBox2.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label7.Visible = false;
            lblAttempted.Visible = false;
            lblAttempted2.Visible = false;
            BtnMinus1.Visible = false;
            btnMinus2.Visible = false;
            btnAdd1.Visible = false;
            btnAdd2.Visible = false;
            lblAttempted2.Text = "";
            lblAttempted.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            gbS.Visible = false;
            gbS2.Visible = false;
            gbS3.Visible = false;
            gbS4.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            label11.Visible = false;
        }

        private void cBoxHatch_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (btnATop.Checked == true)
                {
                    if (rBtnLowTop.Checked == true)
                    {

                        valuesA.sideALow = valuesA.sideALow + 1;
                        lblAttempted.Text = "" + valuesA.sideALow;
                    }
                    else if (rBtnMediumTop.Checked == true)
                    {

                        valuesA.sideAMed = valuesA.sideAMed + 1;
                        lblAttempted.Text = "" + valuesA.sideAMed;
                    }
                    else if (rBtnHighTop.Checked == true)
                    {

                        valuesA.sideAHigh = valuesA.sideAHigh + 1;
                        lblAttempted.Text = "" + valuesA.sideAHigh;
                    }
                }
                else if (btnBTop.Checked == true)
                {
                    if (rBtnLowTop.Checked == true)
                    {
                        lblAttempted.Text = "" + valuesA.sideBLow;
                        valuesA.sideBLow = valuesA.sideBLow + 1;
                    }
                    else if (rBtnMediumTop.Checked == true)
                    {
                        lblAttempted.Text = "" + valuesA.sideBMed;
                        valuesA.sideBMed = valuesA.sideBMed + 1;
                    }
                    else if (rBtnHighTop.Checked == true)
                    {
                        lblAttempted.Text = "" + valuesA.sideBHigh;
                        valuesA.sideBHigh = valuesA.sideBHigh + 1;
                    }
                }
            }
        }

        private void cBoxSuccessfulCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rBtnLow1S_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnLow1S.Checked == true)
            {
                valuesA.cargoLowS = 1;
            }

        }

        private void rBtnLow2S_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnLow2S.Checked == true)
            {
                valuesA.cargoLowS = 2;
            }
        }

        private void rBtnMed1S_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnMed1S.Checked == true)
            {
                valuesA.cargoMedS = 1;
            }
        }

        private void rBtnMed2S_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnMed2S.Checked == true)
            {
                valuesA.cargoMedS = 2;
            }
        }

        private void rBtnHigh1S_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnHigh1S.Checked == true)
            {
                valuesA.cargoHighS = 1;
            }
        }

        private void rBtnHigh2S_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnHigh2S.Checked == true)
            {
                valuesA.cargoHighS = 2;
            }
        }

        private void rBtnHighHatchA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void cBoxMedHatchA_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxMedHatchA.Checked == true)
            {
                valuesA.sideAMedS = true;
            }
            else if (cBoxMedHatchA.Checked == false)
            {
                valuesA.sideAMedS = false;
            }
        }

        private void cBoxHighHatchA_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxHighHatchA.Checked == true)
            {
                valuesA.sideAHighS = true;
            }
            else if (cBoxHighHatchA.Checked == false)
            {
                valuesA.sideAHighS = false;
            }
        }

        private void cBoxLowHatchB_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxLowHatchB.Checked == true)
            {
                valuesA.sideBLowS = true;
            }
            else if (cBoxLowHatchB.Checked == false)
            {
                valuesA.sideBLowS = false;
            }
        }

        private void cBoxMedHatchB_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxMedHatchB.Checked == true)
            {
                valuesA.sideBMedS = true;
            }
            else if (cBoxMedHatchB.Checked == false)
            {
                valuesA.sideBMedS = false;
            }
        }

        private void cBoxHighHatchB_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxHighHatchB.Checked == true)
            {
                valuesA.sideBHighS = true;
            }
            else if (cBoxHighHatchB.Checked == false)
            {
                valuesA.sideBHighS = false;
            }
        }

        private void cBoxLowHatchA_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxLowHatchA.Checked == true)
            {
                valuesA.sideALowS = true;
            }
            else if (cBoxLowHatchA.Checked == false)
            {
                valuesA.sideALowS = false;
            }
        }

        private void rBtnLow1S2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnLow1S2.Checked == true)
            {
                valuesA.cargoLowS2 = 1;
            }
        }

        private void rBtnLow2S2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnLow2S2.Checked == true)
            {
                valuesA.cargoLowS2 = 2;
            }
        }

        private void rBtnMed1S2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnMed1S2.Checked == true)
            {
                valuesA.cargoMedS2 = 1;
            }
        }

        private void rBtnMed2S2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnMed2S2.Checked == true)
            {
                valuesA.cargoMedS2 = 2;
            }
        }

        private void rBtnHigh1S2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnHigh1S2.Checked == true)
            {
                valuesA.cargoHighS2 = 1;
            }
        }

        private void rBtnHigh2S2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnHigh2S2.Checked == true)
            {
                valuesA.cargoHighS2 = 2;
            }
        }

        private void cBoxLowHatchA2_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxLowHatchA2.Checked == true)
            {
                valuesA.sideALowS2 = true;
            }
            else if (cBoxLowHatchA2.Checked == false)
            {
                valuesA.sideALowS2 = false;
            }
        }

        private void cBoxMedHatchA2_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxMedHatchA2.Checked == true)
            {
                valuesA.sideAMedS2 = true;
            }
            else if (cBoxMedHatchA2.Checked == false)
            {
                valuesA.sideAMedS2 = false;
            }
        }

        private void cBoxHighHatchA2_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxHighHatchA2.Checked == true)
            {
                valuesA.sideAHighS2 = true;
            }
            else if (cBoxHighHatchA2.Checked == false)
            {
                valuesA.sideAHighS2 = false;
            }
        }

        private void cBoxHighHatchB2_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxHighHatchB2.Checked == true)
            {
                valuesA.sideBHighS2 = true;
            }
            else if (cBoxHighHatchB2.Checked == false)
            {
                valuesA.sideBHighS2 = false;
            }
        }

        private void cBoxMedHatchB2_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxMedHatchB2.Checked == true)
            {
                valuesA.sideBMedS2 = true;
            }
            else if (cBoxMedHatchB2.Checked == false)
            {
                valuesA.sideBMedS2 = false;
            }
        }

        private void cBoxLowHatchB2_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxLowHatchB2.Checked == true)
            {
                valuesA.sideBLowS2 = true;
            }
            else if (cBoxLowHatchB2.Checked == false)
            {
                valuesA.sideBLowS2 = false;
            }
        }

        private void cBoxShuttle9_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxShuttle10.Checked == true)
            {
                valuesA.shuttle10 = 1;
            }
            else if (cBoxShuttle10.Checked == false)
            {
                valuesA.shuttle10 = 0;
            }
        }

        private void cBoxShuttle9_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cBoxShuttle9.Checked == true)
            {
                valuesA.shuttle9 = 1;
            }
            else if (cBoxShuttle9.Checked == false)
            {
                valuesA.shuttle9 = 0;
            }
        }

        private void cBoxShuttle11_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxShuttle11.Checked == true)
            {
                valuesA.shuttle11 = 1;
            }
            else if (cBoxShuttle11.Checked == false)
            {
                valuesA.shuttle11 = 0;
            }
        }

        private void cBoxShuttle12_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxShuttle9.Checked == true)
            {
                valuesA.shuttle12 = 1;
            }
            else if (cBoxShuttle12.Checked == false)
            {
                valuesA.shuttle12 = 0;
            }
        }

        private void cBoxShuttle13_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxShuttle13.Checked == true)
            {
                valuesA.shuttle13 = 1;
            }
            else if (cBoxShuttle13.Checked == false)
            {
                valuesA.shuttle13 = 0;
            }
        }

        private void cBoxShuttle14_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxShuttle14.Checked == true)
            {
                valuesA.shuttle14 = 1;
            }
            else if (cBoxShuttle14.Checked == false)
            {
                valuesA.shuttle14 = 0;
            }
        }

        private void cBoxShuttle15_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxShuttle15.Checked == true)
            {
                valuesA.shuttle15 = 1;
            }
            else if (cBoxShuttle15.Checked == false)
            {
                valuesA.shuttle15 = 0;
            }
        }

        private void cBoxShuttle16_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxShuttle16.Checked == true)
            {
                valuesA.shuttle16 = 1;
            }
            else if (cBoxShuttle16.Checked == false)
            {
                valuesA.shuttle16 = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBoxShuttle2_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}