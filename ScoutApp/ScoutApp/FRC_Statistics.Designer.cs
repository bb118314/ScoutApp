namespace WindowsFormsApp1
{
    partial class FRC_Statistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Event ID");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Match ID");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Team ID");
            this.lViewAutonomous = new System.Windows.Forms.ListView();
            this.lViewDriver = new System.Windows.Forms.ListView();
            this.tbScoutReport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lViewEndgame = new System.Windows.Forms.ListView();
            this.BtnNextMatch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lViewLogIn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCargoTotal = new System.Windows.Forms.Label();
            this.lblHatchesTotal = new System.Windows.Forms.Label();
            this.lblCargoTotal2 = new System.Windows.Forms.Label();
            this.lblHatchesTotal2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCargoTotal3 = new System.Windows.Forms.Label();
            this.lblHatchesTotal3 = new System.Windows.Forms.Label();
            this.lblHatchesTotal3A = new System.Windows.Forms.Label();
            this.lblCargoTotal3A = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblHatchesTotal2A = new System.Windows.Forms.Label();
            this.lblCargoTotal2A = new System.Windows.Forms.Label();
            this.lblHatchesTotalA = new System.Windows.Forms.Label();
            this.lblCargoTotalA = new System.Windows.Forms.Label();
            this.lblEndgame = new System.Windows.Forms.Label();
            this.eventID = new System.Windows.Forms.Label();
            this.teamID = new System.Windows.Forms.Label();
            this.matchID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lViewAutonomous
            // 
            this.lViewAutonomous.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lViewAutonomous.Location = new System.Drawing.Point(120, 154);
            this.lViewAutonomous.Name = "lViewAutonomous";
            this.lViewAutonomous.Size = new System.Drawing.Size(163, 236);
            this.lViewAutonomous.TabIndex = 1;
            this.lViewAutonomous.UseCompatibleStateImageBehavior = false;
            // 
            // lViewDriver
            // 
            this.lViewDriver.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lViewDriver.Location = new System.Drawing.Point(311, 154);
            this.lViewDriver.Name = "lViewDriver";
            this.lViewDriver.Size = new System.Drawing.Size(163, 236);
            this.lViewDriver.TabIndex = 2;
            this.lViewDriver.UseCompatibleStateImageBehavior = false;
            // 
            // tbScoutReport
            // 
            this.tbScoutReport.Location = new System.Drawing.Point(714, 41);
            this.tbScoutReport.Name = "tbScoutReport";
            this.tbScoutReport.Size = new System.Drawing.Size(74, 20);
            this.tbScoutReport.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(678, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Scouting Report (1-10)";
            // 
            // lViewEndgame
            // 
            this.lViewEndgame.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lViewEndgame.Location = new System.Drawing.Point(516, 218);
            this.lViewEndgame.Name = "lViewEndgame";
            this.lViewEndgame.Size = new System.Drawing.Size(205, 86);
            this.lViewEndgame.TabIndex = 3;
            this.lViewEndgame.UseCompatibleStateImageBehavior = false;
            // 
            // BtnNextMatch
            // 
            this.BtnNextMatch.Location = new System.Drawing.Point(692, 394);
            this.BtnNextMatch.Name = "BtnNextMatch";
            this.BtnNextMatch.Size = new System.Drawing.Size(96, 44);
            this.BtnNextMatch.TabIndex = 6;
            this.BtnNextMatch.Text = "Next Match";
            this.BtnNextMatch.UseVisualStyleBackColor = true;
            this.BtnNextMatch.Click += new System.EventHandler(this.BtnNextMatch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Autonomous Stats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Driver Controlled Stats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Endgame Stats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Log";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lViewLogIn
            // 
            this.lViewLogIn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lViewLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lViewLogIn.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lViewLogIn.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lViewLogIn.Location = new System.Drawing.Point(317, 15);
            this.lViewLogIn.Name = "lViewLogIn";
            this.lViewLogIn.Size = new System.Drawing.Size(135, 90);
            this.lViewLogIn.TabIndex = 0;
            this.lViewLogIn.UseCompatibleStateImageBehavior = false;
            this.lViewLogIn.SelectedIndexChanged += new System.EventHandler(this.lViewLogIn_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Event ID";
            // 
            // lblCargoTotal
            // 
            this.lblCargoTotal.AutoSize = true;
            this.lblCargoTotal.Location = new System.Drawing.Point(314, 179);
            this.lblCargoTotal.Name = "lblCargoTotal";
            this.lblCargoTotal.Size = new System.Drawing.Size(98, 13);
            this.lblCargoTotal.TabIndex = 10;
            this.lblCargoTotal.Text = "Cargo:        Missed:";
            this.lblCargoTotal.Click += new System.EventHandler(this.lblCargoHigh_Click);
            // 
            // lblHatchesTotal
            // 
            this.lblHatchesTotal.AutoSize = true;
            this.lblHatchesTotal.Location = new System.Drawing.Point(314, 201);
            this.lblHatchesTotal.Name = "lblHatchesTotal";
            this.lblHatchesTotal.Size = new System.Drawing.Size(53, 13);
            this.lblHatchesTotal.TabIndex = 11;
            this.lblHatchesTotal.Text = "Hatches: ";
            this.lblHatchesTotal.Click += new System.EventHandler(this.lblHatchesTotal_Click);
            // 
            // lblCargoTotal2
            // 
            this.lblCargoTotal2.AutoSize = true;
            this.lblCargoTotal2.Location = new System.Drawing.Point(314, 253);
            this.lblCargoTotal2.Name = "lblCargoTotal2";
            this.lblCargoTotal2.Size = new System.Drawing.Size(41, 13);
            this.lblCargoTotal2.TabIndex = 12;
            this.lblCargoTotal2.Text = "Cargo: ";
            // 
            // lblHatchesTotal2
            // 
            this.lblHatchesTotal2.AutoSize = true;
            this.lblHatchesTotal2.Location = new System.Drawing.Point(314, 274);
            this.lblHatchesTotal2.Name = "lblHatchesTotal2";
            this.lblHatchesTotal2.Size = new System.Drawing.Size(53, 13);
            this.lblHatchesTotal2.TabIndex = 13;
            this.lblHatchesTotal2.Text = "Hatches: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(361, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Rocket 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(361, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Rocket 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(365, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Shuttle";
            // 
            // lblCargoTotal3
            // 
            this.lblCargoTotal3.AutoSize = true;
            this.lblCargoTotal3.Location = new System.Drawing.Point(314, 325);
            this.lblCargoTotal3.Name = "lblCargoTotal3";
            this.lblCargoTotal3.Size = new System.Drawing.Size(41, 13);
            this.lblCargoTotal3.TabIndex = 17;
            this.lblCargoTotal3.Text = "Cargo: ";
            // 
            // lblHatchesTotal3
            // 
            this.lblHatchesTotal3.AutoSize = true;
            this.lblHatchesTotal3.Location = new System.Drawing.Point(314, 345);
            this.lblHatchesTotal3.Name = "lblHatchesTotal3";
            this.lblHatchesTotal3.Size = new System.Drawing.Size(53, 13);
            this.lblHatchesTotal3.TabIndex = 18;
            this.lblHatchesTotal3.Text = "Hatches: ";
            // 
            // lblHatchesTotal3A
            // 
            this.lblHatchesTotal3A.AutoSize = true;
            this.lblHatchesTotal3A.Location = new System.Drawing.Point(126, 345);
            this.lblHatchesTotal3A.Name = "lblHatchesTotal3A";
            this.lblHatchesTotal3A.Size = new System.Drawing.Size(53, 13);
            this.lblHatchesTotal3A.TabIndex = 27;
            this.lblHatchesTotal3A.Text = "Hatches: ";
            // 
            // lblCargoTotal3A
            // 
            this.lblCargoTotal3A.AutoSize = true;
            this.lblCargoTotal3A.Location = new System.Drawing.Point(126, 325);
            this.lblCargoTotal3A.Name = "lblCargoTotal3A";
            this.lblCargoTotal3A.Size = new System.Drawing.Size(41, 13);
            this.lblCargoTotal3A.TabIndex = 26;
            this.lblCargoTotal3A.Text = "Cargo: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(177, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Shuttle";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(173, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Rocket 2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(173, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Rocket 1";
            // 
            // lblHatchesTotal2A
            // 
            this.lblHatchesTotal2A.AutoSize = true;
            this.lblHatchesTotal2A.Location = new System.Drawing.Point(126, 274);
            this.lblHatchesTotal2A.Name = "lblHatchesTotal2A";
            this.lblHatchesTotal2A.Size = new System.Drawing.Size(53, 13);
            this.lblHatchesTotal2A.TabIndex = 22;
            this.lblHatchesTotal2A.Text = "Hatches: ";
            // 
            // lblCargoTotal2A
            // 
            this.lblCargoTotal2A.AutoSize = true;
            this.lblCargoTotal2A.Location = new System.Drawing.Point(126, 253);
            this.lblCargoTotal2A.Name = "lblCargoTotal2A";
            this.lblCargoTotal2A.Size = new System.Drawing.Size(41, 13);
            this.lblCargoTotal2A.TabIndex = 21;
            this.lblCargoTotal2A.Text = "Cargo: ";
            // 
            // lblHatchesTotalA
            // 
            this.lblHatchesTotalA.AutoSize = true;
            this.lblHatchesTotalA.Location = new System.Drawing.Point(126, 201);
            this.lblHatchesTotalA.Name = "lblHatchesTotalA";
            this.lblHatchesTotalA.Size = new System.Drawing.Size(53, 13);
            this.lblHatchesTotalA.TabIndex = 20;
            this.lblHatchesTotalA.Text = "Hatches: ";
            // 
            // lblCargoTotalA
            // 
            this.lblCargoTotalA.AutoSize = true;
            this.lblCargoTotalA.Location = new System.Drawing.Point(126, 179);
            this.lblCargoTotalA.Name = "lblCargoTotalA";
            this.lblCargoTotalA.Size = new System.Drawing.Size(98, 13);
            this.lblCargoTotalA.TabIndex = 19;
            this.lblCargoTotalA.Text = "Cargo:        Missed:";
            // 
            // lblEndgame
            // 
            this.lblEndgame.AutoSize = true;
            this.lblEndgame.Location = new System.Drawing.Point(537, 253);
            this.lblEndgame.Name = "lblEndgame";
            this.lblEndgame.Size = new System.Drawing.Size(160, 13);
            this.lblEndgame.TabIndex = 28;
            this.lblEndgame.Text = "Robot did not make back to hab";
            this.lblEndgame.Click += new System.EventHandler(this.lblEndgame_Click);
            // 
            // eventID
            // 
            this.eventID.AutoSize = true;
            this.eventID.Location = new System.Drawing.Point(319, 61);
            this.eventID.Name = "eventID";
            this.eventID.Size = new System.Drawing.Size(46, 13);
            this.eventID.TabIndex = 29;
            this.eventID.Text = "ERROR";
            // 
            // teamID
            // 
            this.teamID.AutoSize = true;
            this.teamID.Location = new System.Drawing.Point(404, 61);
            this.teamID.Name = "teamID";
            this.teamID.Size = new System.Drawing.Size(46, 13);
            this.teamID.TabIndex = 30;
            this.teamID.Text = "ERROR";
            // 
            // matchID
            // 
            this.matchID.AutoSize = true;
            this.matchID.Location = new System.Drawing.Point(361, 61);
            this.matchID.Name = "matchID";
            this.matchID.Size = new System.Drawing.Size(46, 13);
            this.matchID.TabIndex = 31;
            this.matchID.Text = "ERROR";
            // 
            // FRC_Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.matchID);
            this.Controls.Add(this.teamID);
            this.Controls.Add(this.eventID);
            this.Controls.Add(this.lblEndgame);
            this.Controls.Add(this.lblHatchesTotal3A);
            this.Controls.Add(this.lblCargoTotal3A);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblHatchesTotal2A);
            this.Controls.Add(this.lblCargoTotal2A);
            this.Controls.Add(this.lblHatchesTotalA);
            this.Controls.Add(this.lblCargoTotalA);
            this.Controls.Add(this.lblHatchesTotal3);
            this.Controls.Add(this.lblCargoTotal3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblHatchesTotal2);
            this.Controls.Add(this.lblCargoTotal2);
            this.Controls.Add(this.lblHatchesTotal);
            this.Controls.Add(this.lblCargoTotal);
            this.Controls.Add(this.lViewLogIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnNextMatch);
            this.Controls.Add(this.lViewEndgame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbScoutReport);
            this.Controls.Add(this.lViewDriver);
            this.Controls.Add(this.lViewAutonomous);
            this.Name = "FRC_Statistics";
            this.Text = "FRC_Statistics";
            this.Load += new System.EventHandler(this.FRC_Statistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lViewAutonomous;
        private System.Windows.Forms.ListView lViewDriver;
        private System.Windows.Forms.TextBox tbScoutReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lViewEndgame;
        private System.Windows.Forms.Button BtnNextMatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lViewLogIn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lblCargoTotal;
        private System.Windows.Forms.Label lblHatchesTotal;
        private System.Windows.Forms.Label lblCargoTotal2;
        private System.Windows.Forms.Label lblHatchesTotal2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCargoTotal3;
        private System.Windows.Forms.Label lblHatchesTotal3;
        private System.Windows.Forms.Label lblHatchesTotal3A;
        private System.Windows.Forms.Label lblCargoTotal3A;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblHatchesTotal2A;
        private System.Windows.Forms.Label lblCargoTotal2A;
        private System.Windows.Forms.Label lblHatchesTotalA;
        private System.Windows.Forms.Label lblCargoTotalA;
        private System.Windows.Forms.Label lblEndgame;
        private System.Windows.Forms.Label eventID;
        private System.Windows.Forms.Label teamID;
        private System.Windows.Forms.Label matchID;
    }
}