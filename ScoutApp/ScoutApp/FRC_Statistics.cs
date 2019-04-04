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
    public partial class FRC_Statistics : Form
    {
        public FRC_Statistics()
        {
            InitializeComponent();
            int totalHatches = 0;
            int totalHatches2 = 0;

            int totalHatchesA = 0;
            int totalHatches2A = 0;

            int shuttleHatchA = 0;
            int shuttleHatch = 0;

            


            if (WindowsFormsApp1.gb.valuesDC.sideALowS == true)
            {
                totalHatches = totalHatches + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideAMedS == true)
            {
                totalHatches = totalHatches + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideAHighS == true)
            {
                totalHatches = totalHatches + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideBLowS == true)
            {
                totalHatches = totalHatches + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideBMedS == true)
            {
                totalHatches = totalHatches + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideBHighS == true)
            {
                totalHatches = totalHatches + 1;
            }

            if (WindowsFormsApp1.gb.valuesDC.sideALowS2 == true)
            {
                totalHatches2 = totalHatches2 + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideAMedS2 == true)
            {
                totalHatches2 = totalHatches2 + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideAHighS2 == true)
            {
                totalHatches2 = totalHatches2 + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideBLowS2 == true)
            {
                totalHatches2 = totalHatches2 + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideBMedS2 == true)
            {
                totalHatches2 = totalHatches2 + 1;
            }
            if (WindowsFormsApp1.gb.valuesDC.sideBHighS2 == true)
            {
                totalHatches2 = totalHatches2 + 1;
            }

            //AUTO

            if (WindowsFormsApp1.Autonomous.valuesA.sideALowS == true)
            {
                totalHatches = totalHatches + 1;
            }
            if (WindowsFormsApp1.Autonomous.valuesA.sideAMedS == true)
            {
                totalHatches = totalHatchesA + 1;
            }
            if (WindowsFormsApp1.Autonomous.valuesA.sideAHighS == true)
            {
                totalHatchesA = totalHatchesA + 1;
            }
            if (WindowsFormsApp1.Autonomous.valuesA.sideBLowS == true)
            {
                totalHatchesA = totalHatchesA + 1;
            }
            if (WindowsFormsApp1.Autonomous.valuesA.sideBMedS == true)
            {
                totalHatchesA = totalHatchesA + 1;
            }
            if (WindowsFormsApp1.Autonomous.valuesA.sideBHighS == true)
            {
                totalHatchesA = totalHatchesA + 1;
            }

            if (WindowsFormsApp1.Autonomous.valuesA.sideALowS2 == true)
            {
                totalHatches2A = totalHatches2A + 1;
            }
            if (WindowsFormsApp1.Autonomous.valuesA.sideAMedS2 == true)
            {
                totalHatches2A = totalHatches2A + 1;
            }
            if (WindowsFormsApp1.Autonomous.valuesA.sideAHighS2 == true)
            {
                totalHatches2A = totalHatches2A + 1;
            }
            if (WindowsFormsApp1.Autonomous.valuesA.sideBLowS2 == true)
            {
                totalHatches2A = totalHatches2A + 1;
            }
            if (WindowsFormsApp1.Autonomous.valuesA.sideBMedS2 == true)
            {
                totalHatches2A = totalHatches2A + 1;
            }
            if (WindowsFormsApp1.Autonomous.valuesA.sideBHighS2 == true)
            {
                totalHatches2A = totalHatches2A + 1;
            }



            int totalCargoMissed = WindowsFormsApp1.gb.valuesDC.cargoHigh + WindowsFormsApp1.gb.valuesDC.cargoMed + WindowsFormsApp1.gb.valuesDC.cargoLow;
            int totalCargoMissed2 = WindowsFormsApp1.gb.valuesDC.cargoHigh2 + WindowsFormsApp1.gb.valuesDC.cargoMed2 + WindowsFormsApp1.gb.valuesDC.cargoLow2;
            int totalHatchesMissed = WindowsFormsApp1.gb.valuesDC.sideALow + WindowsFormsApp1.gb.valuesDC.sideAMed + WindowsFormsApp1.gb.valuesDC.sideAHigh + WindowsFormsApp1.gb.valuesDC.sideBLow + WindowsFormsApp1.gb.valuesDC.sideBMed + WindowsFormsApp1.gb.valuesDC.sideBHigh;
            int totalHatchesMissed2 = WindowsFormsApp1.gb.valuesDC.sideALow2 + WindowsFormsApp1.gb.valuesDC.sideAMed2 + WindowsFormsApp1.gb.valuesDC.sideAHigh2 + WindowsFormsApp1.gb.valuesDC.sideBLow2 + WindowsFormsApp1.gb.valuesDC.sideBMed2 + WindowsFormsApp1.gb.valuesDC.sideBHigh2;
            int totalCargo = WindowsFormsApp1.gb.valuesDC.cargoHighS + WindowsFormsApp1.gb.valuesDC.cargoMedS + WindowsFormsApp1.gb.valuesDC.cargoLowS;
            int totalCargo2 = WindowsFormsApp1.gb.valuesDC.cargoHighS2 + WindowsFormsApp1.gb.valuesDC.cargoMedS2 + WindowsFormsApp1.gb.valuesDC.cargoLowS2;

            int totalCargoMissedA = WindowsFormsApp1.Autonomous.valuesA.cargoHigh + WindowsFormsApp1.Autonomous.valuesA.cargoMed + WindowsFormsApp1.Autonomous.valuesA.cargoLow;
            int totalCargoMissed2A = WindowsFormsApp1.Autonomous.valuesA.cargoHigh2 + WindowsFormsApp1.Autonomous.valuesA.cargoMed2 + WindowsFormsApp1.Autonomous.valuesA.cargoLow2;
            int totalHatchesMissedA = WindowsFormsApp1.Autonomous.valuesA.sideALow + WindowsFormsApp1.Autonomous.valuesA.sideAMed + WindowsFormsApp1.Autonomous.valuesA.sideAHigh + WindowsFormsApp1.Autonomous.valuesA.sideBLow + WindowsFormsApp1.Autonomous.valuesA.sideBMed + WindowsFormsApp1.Autonomous.valuesA.sideBHigh;
            int totalHatchesMissed2A = WindowsFormsApp1.Autonomous.valuesA.sideALow2 + WindowsFormsApp1.Autonomous.valuesA.sideAMed2 + WindowsFormsApp1.Autonomous.valuesA.sideAHigh2 + WindowsFormsApp1.Autonomous.valuesA.sideBLow2 + WindowsFormsApp1.Autonomous.valuesA.sideBMed2 + WindowsFormsApp1.Autonomous.valuesA.sideBHigh2;
            int totalCargoA = WindowsFormsApp1.Autonomous.valuesA.cargoHighS + WindowsFormsApp1.Autonomous.valuesA.cargoMedS + WindowsFormsApp1.Autonomous.valuesA.cargoLowS;
            int totalCargo2A = WindowsFormsApp1.Autonomous.valuesA.cargoHighS2 + WindowsFormsApp1.Autonomous.valuesA.cargoMedS2 + WindowsFormsApp1.Autonomous.valuesA.cargoLowS2;

            lblCargoTotal.Text = "Cargo: " + totalCargo + "       Misses: " + totalCargoMissed;
            lblHatchesTotal.Text = "Hatches: " + totalHatches + "       Misses: " + totalHatchesMissed;
            lblCargoTotal2.Text = "Cargo: " + totalCargo2 + "       Misses: " + totalCargoMissed2;
            lblHatchesTotal2.Text = "Hatches: " + totalHatches2 + "       Misses: " + totalHatchesMissed2;

            lblCargoTotalA.Text = "Cargo: " + totalCargoA + "       Misses: " + totalCargoMissedA;
            lblHatchesTotalA.Text = "Hatches: " + totalHatchesA + "       Misses: " + totalHatchesMissedA;
            lblCargoTotal2A.Text = "Cargo: " + totalCargo2A + "       Misses: " + totalCargoMissed2A;
            lblHatchesTotal2A.Text = "Hatches: " + totalHatches2A + "       Misses: " + totalHatchesMissed2A;

            if (WindowsFormsApp1.EndGame.valuesEnd.position == 3)
            {
                lblEndgame.Text = "Robot ended on the high platform";
            }
            else if (WindowsFormsApp1.EndGame.valuesEnd.position == 2)
            {
                lblEndgame.Text = "Robot ended on the low platform";
            }
            else if (WindowsFormsApp1.EndGame.valuesEnd.position == 1)
            {
                lblEndgame.Text = "Robot ended on the hab floor";
            }
            else if (WindowsFormsApp1.EndGame.valuesEnd.position == 0)
            {
                lblEndgame.Text = "Robot did not make back to hab";
            }

            int shuttleCargo = WindowsFormsApp1.gb.valuesDC.shuttle9 + WindowsFormsApp1.gb.valuesDC.shuttle10 + WindowsFormsApp1.gb.valuesDC.shuttle11 + WindowsFormsApp1.gb.valuesDC.shuttle12 + WindowsFormsApp1.gb.valuesDC.shuttle13 + WindowsFormsApp1.gb.valuesDC.shuttle14 + WindowsFormsApp1.gb.valuesDC.shuttle15 + WindowsFormsApp1.gb.valuesDC.shuttle16;

            int shuttleCargoA = WindowsFormsApp1.Autonomous.valuesA.shuttle9 + WindowsFormsApp1.Autonomous.valuesA.shuttle10 + WindowsFormsApp1.Autonomous.valuesA.shuttle11 + WindowsFormsApp1.Autonomous.valuesA.shuttle12 + WindowsFormsApp1.Autonomous.valuesA.shuttle13 + WindowsFormsApp1.Autonomous.valuesA.shuttle14 + WindowsFormsApp1.Autonomous.valuesA.shuttle15 + WindowsFormsApp1.Autonomous.valuesA.shuttle16;

            eventID.Text = WindowsFormsApp1.frmRecordLog.valuesForm.eventID;
            matchID.Text = WindowsFormsApp1.frmRecordLog.valuesForm.matchNum;
            teamID.Text = WindowsFormsApp1.frmRecordLog.valuesForm.teamID;
            lblCargoTotal3.Text = "Cargo: " + shuttleCargo;
            lblHatchesTotal3.Text = "Hatches: " + shuttleHatch;
            lblHatchesTotal3A.Text = "Hatches: " + shuttleHatchA;
            lblCargoTotal3A.Text = "Cargo: " + shuttleCargoA;
        }

        private void BtnNextMatch_Click(object sender, EventArgs e)
        {
            frmRecordLog form1 = new frmRecordLog();
            this.Close();
            form1.Visible=true;
        }

        private void FRC_Statistics_Load(object sender, EventArgs e)
        {

        }

        private void lblCargoHigh_Click(object sender, EventArgs e)
        {

        }

        private void lblHatchesTotal_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lViewLogIn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblEndgame_Click(object sender, EventArgs e)
        {

        }
    }
}
