namespace WindowsFormsApp1
{
    partial class EndGame
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
            this.cBoxDidGetBackOnPlatform = new System.Windows.Forms.CheckBox();
            this.BtnNextScreen = new System.Windows.Forms.Button();
            this.rbHigh = new System.Windows.Forms.RadioButton();
            this.rbMed = new System.Windows.Forms.RadioButton();
            this.rbLow = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cBoxDidGetBackOnPlatform
            // 
            this.cBoxDidGetBackOnPlatform.Location = new System.Drawing.Point(242, 226);
            this.cBoxDidGetBackOnPlatform.Name = "cBoxDidGetBackOnPlatform";
            this.cBoxDidGetBackOnPlatform.Size = new System.Drawing.Size(96, 93);
            this.cBoxDidGetBackOnPlatform.TabIndex = 0;
            this.cBoxDidGetBackOnPlatform.Text = "Did Robot get back on platform?";
            this.cBoxDidGetBackOnPlatform.UseVisualStyleBackColor = true;
            this.cBoxDidGetBackOnPlatform.CheckedChanged += new System.EventHandler(this.cBoxDidGetBackOnPlatform_CheckedChanged);
            // 
            // BtnNextScreen
            // 
            this.BtnNextScreen.Location = new System.Drawing.Point(679, 382);
            this.BtnNextScreen.Name = "BtnNextScreen";
            this.BtnNextScreen.Size = new System.Drawing.Size(115, 56);
            this.BtnNextScreen.TabIndex = 1;
            this.BtnNextScreen.Text = "Next Screen";
            this.BtnNextScreen.UseVisualStyleBackColor = true;
            this.BtnNextScreen.Click += new System.EventHandler(this.BtnNextScreen_Click);
            // 
            // rbHigh
            // 
            this.rbHigh.AutoSize = true;
            this.rbHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHigh.Location = new System.Drawing.Point(389, 226);
            this.rbHigh.Name = "rbHigh";
            this.rbHigh.Size = new System.Drawing.Size(130, 28);
            this.rbHigh.TabIndex = 2;
            this.rbHigh.TabStop = true;
            this.rbHigh.Text = "Tall Platform";
            this.rbHigh.UseVisualStyleBackColor = true;
            this.rbHigh.Visible = false;
            this.rbHigh.CheckedChanged += new System.EventHandler(this.rbHigh_CheckedChanged);
            // 
            // rbMed
            // 
            this.rbMed.AutoSize = true;
            this.rbMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMed.Location = new System.Drawing.Point(389, 260);
            this.rbMed.Name = "rbMed";
            this.rbMed.Size = new System.Drawing.Size(169, 28);
            this.rbMed.TabIndex = 3;
            this.rbMed.TabStop = true;
            this.rbMed.Text = "Medium Platform";
            this.rbMed.UseVisualStyleBackColor = true;
            this.rbMed.Visible = false;
            this.rbMed.CheckedChanged += new System.EventHandler(this.rbMed_CheckedChanged);
            // 
            // rbLow
            // 
            this.rbLow.AutoSize = true;
            this.rbLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLow.Location = new System.Drawing.Point(389, 294);
            this.rbLow.Name = "rbLow";
            this.rbLow.Size = new System.Drawing.Size(86, 28);
            this.rbLow.TabIndex = 4;
            this.rbLow.TabStop = true;
            this.rbLow.Text = "Bottom";
            this.rbLow.UseVisualStyleBackColor = true;
            this.rbLow.Visible = false;
            this.rbLow.CheckedChanged += new System.EventHandler(this.rbLow_CheckedChanged);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.FRC_Field;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbLow);
            this.Controls.Add(this.rbMed);
            this.Controls.Add(this.rbHigh);
            this.Controls.Add(this.BtnNextScreen);
            this.Controls.Add(this.cBoxDidGetBackOnPlatform);
            this.Name = "EndGame";
            this.Text = "EndGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cBoxDidGetBackOnPlatform;
        private System.Windows.Forms.Button BtnNextScreen;
        private System.Windows.Forms.RadioButton rbHigh;
        private System.Windows.Forms.RadioButton rbMed;
        private System.Windows.Forms.RadioButton rbLow;
    }
}