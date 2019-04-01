namespace WindowsFormsApp1
{
    partial class QuitNextForm
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
            this.BtnNextScreen = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnNextScreen
            // 
            this.BtnNextScreen.Location = new System.Drawing.Point(192, 163);
            this.BtnNextScreen.Name = "BtnNextScreen";
            this.BtnNextScreen.Size = new System.Drawing.Size(146, 62);
            this.BtnNextScreen.TabIndex = 0;
            this.BtnNextScreen.Text = "Next Match";
            this.BtnNextScreen.UseVisualStyleBackColor = true;
            this.BtnNextScreen.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(460, 163);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(146, 62);
            this.BtnQuit.TabIndex = 1;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            // 
            // QuitNextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnNextScreen);
            this.Name = "QuitNextForm";
            this.Text = "QuitNextForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNextScreen;
        private System.Windows.Forms.Button BtnQuit;
    }
}