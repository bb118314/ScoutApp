namespace WindowsFormsApp1
{
    partial class PreloadForm
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
            this.rBtnSideA = new System.Windows.Forms.RadioButton();
            this.rBtnSideB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnSideC = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBtnCargo = new System.Windows.Forms.RadioButton();
            this.rBtnHatch = new System.Windows.Forms.RadioButton();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.rBtn1 = new System.Windows.Forms.RadioButton();
            this.rBtn2 = new System.Windows.Forms.RadioButton();
            this.rBtn3 = new System.Windows.Forms.RadioButton();
            this.rBtn4 = new System.Windows.Forms.RadioButton();
            this.rBtn5 = new System.Windows.Forms.RadioButton();
            this.rBtn6 = new System.Windows.Forms.RadioButton();
            this.rBtn7 = new System.Windows.Forms.RadioButton();
            this.rBtn8 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rBtnSideA
            // 
            this.rBtnSideA.AutoSize = true;
            this.rBtnSideA.Location = new System.Drawing.Point(50, 19);
            this.rBtnSideA.Name = "rBtnSideA";
            this.rBtnSideA.Size = new System.Drawing.Size(56, 17);
            this.rBtnSideA.TabIndex = 0;
            this.rBtnSideA.TabStop = true;
            this.rBtnSideA.Text = "Side A";
            this.rBtnSideA.UseVisualStyleBackColor = true;
            this.rBtnSideA.CheckedChanged += new System.EventHandler(this.rBtnSideA_CheckedChanged);
            // 
            // rBtnSideB
            // 
            this.rBtnSideB.AutoSize = true;
            this.rBtnSideB.Location = new System.Drawing.Point(50, 41);
            this.rBtnSideB.Name = "rBtnSideB";
            this.rBtnSideB.Size = new System.Drawing.Size(56, 17);
            this.rBtnSideB.TabIndex = 1;
            this.rBtnSideB.TabStop = true;
            this.rBtnSideB.Text = "Side B";
            this.rBtnSideB.UseVisualStyleBackColor = true;
            this.rBtnSideB.CheckedChanged += new System.EventHandler(this.rBtnSideB_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnSideC);
            this.groupBox1.Controls.Add(this.rBtnSideA);
            this.groupBox1.Controls.Add(this.rBtnSideB);
            this.groupBox1.Location = new System.Drawing.Point(239, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // rBtnSideC
            // 
            this.rBtnSideC.AutoSize = true;
            this.rBtnSideC.Location = new System.Drawing.Point(50, 63);
            this.rBtnSideC.Name = "rBtnSideC";
            this.rBtnSideC.Size = new System.Drawing.Size(56, 17);
            this.rBtnSideC.TabIndex = 2;
            this.rBtnSideC.TabStop = true;
            this.rBtnSideC.Text = "Side C";
            this.rBtnSideC.UseVisualStyleBackColor = true;
            this.rBtnSideC.CheckedChanged += new System.EventHandler(this.rBtnSideC_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(754, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Side A";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(604, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Side B";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(751, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Side C";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBtnCargo);
            this.groupBox2.Controls.Add(this.rBtnHatch);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cargo Or Hatch";
            // 
            // rBtnCargo
            // 
            this.rBtnCargo.AutoSize = true;
            this.rBtnCargo.Location = new System.Drawing.Point(50, 19);
            this.rBtnCargo.Name = "rBtnCargo";
            this.rBtnCargo.Size = new System.Drawing.Size(53, 17);
            this.rBtnCargo.TabIndex = 0;
            this.rBtnCargo.Text = "Cargo";
            this.rBtnCargo.UseVisualStyleBackColor = true;
            this.rBtnCargo.CheckedChanged += new System.EventHandler(this.rBtnCargo_CheckedChanged);
            // 
            // rBtnHatch
            // 
            this.rBtnHatch.AutoSize = true;
            this.rBtnHatch.Location = new System.Drawing.Point(50, 41);
            this.rBtnHatch.Name = "rBtnHatch";
            this.rBtnHatch.Size = new System.Drawing.Size(54, 17);
            this.rBtnHatch.TabIndex = 1;
            this.rBtnHatch.Text = "Hatch";
            this.rBtnHatch.UseVisualStyleBackColor = true;
            this.rBtnHatch.CheckedChanged += new System.EventHandler(this.rBtnHatch_CheckedChanged);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(98, 415);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(103, 32);
            this.btnNextPage.TabIndex = 13;
            this.btnNextPage.Text = "Next Page";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // rBtn1
            // 
            this.rBtn1.AutoSize = true;
            this.rBtn1.Location = new System.Drawing.Point(711, 213);
            this.rBtn1.Name = "rBtn1";
            this.rBtn1.Size = new System.Drawing.Size(14, 13);
            this.rBtn1.TabIndex = 14;
            this.rBtn1.TabStop = true;
            this.rBtn1.UseVisualStyleBackColor = true;
            // 
            // rBtn2
            // 
            this.rBtn2.AutoSize = true;
            this.rBtn2.Location = new System.Drawing.Point(675, 212);
            this.rBtn2.Name = "rBtn2";
            this.rBtn2.Size = new System.Drawing.Size(14, 13);
            this.rBtn2.TabIndex = 15;
            this.rBtn2.TabStop = true;
            this.rBtn2.UseVisualStyleBackColor = true;
            // 
            // rBtn3
            // 
            this.rBtn3.AutoSize = true;
            this.rBtn3.Location = new System.Drawing.Point(640, 213);
            this.rBtn3.Name = "rBtn3";
            this.rBtn3.Size = new System.Drawing.Size(14, 13);
            this.rBtn3.TabIndex = 16;
            this.rBtn3.TabStop = true;
            this.rBtn3.UseVisualStyleBackColor = true;
            // 
            // rBtn4
            // 
            this.rBtn4.AutoSize = true;
            this.rBtn4.Location = new System.Drawing.Point(532, 282);
            this.rBtn4.Name = "rBtn4";
            this.rBtn4.Size = new System.Drawing.Size(14, 13);
            this.rBtn4.TabIndex = 17;
            this.rBtn4.TabStop = true;
            this.rBtn4.UseVisualStyleBackColor = true;
            // 
            // rBtn5
            // 
            this.rBtn5.AutoSize = true;
            this.rBtn5.Location = new System.Drawing.Point(531, 320);
            this.rBtn5.Name = "rBtn5";
            this.rBtn5.Size = new System.Drawing.Size(14, 13);
            this.rBtn5.TabIndex = 18;
            this.rBtn5.TabStop = true;
            this.rBtn5.UseVisualStyleBackColor = true;
            // 
            // rBtn6
            // 
            this.rBtn6.AutoSize = true;
            this.rBtn6.Location = new System.Drawing.Point(640, 386);
            this.rBtn6.Name = "rBtn6";
            this.rBtn6.Size = new System.Drawing.Size(14, 13);
            this.rBtn6.TabIndex = 19;
            this.rBtn6.TabStop = true;
            this.rBtn6.UseVisualStyleBackColor = true;
            // 
            // rBtn7
            // 
            this.rBtn7.AutoSize = true;
            this.rBtn7.Location = new System.Drawing.Point(675, 386);
            this.rBtn7.Name = "rBtn7";
            this.rBtn7.Size = new System.Drawing.Size(14, 13);
            this.rBtn7.TabIndex = 20;
            this.rBtn7.TabStop = true;
            this.rBtn7.UseVisualStyleBackColor = true;
            // 
            // rBtn8
            // 
            this.rBtn8.AutoSize = true;
            this.rBtn8.Location = new System.Drawing.Point(711, 386);
            this.rBtn8.Name = "rBtn8";
            this.rBtn8.Size = new System.Drawing.Size(14, 13);
            this.rBtn8.TabIndex = 21;
            this.rBtn8.TabStop = true;
            this.rBtn8.UseVisualStyleBackColor = true;
            // 
            // PreloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.FRC_Field;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rBtn8);
            this.Controls.Add(this.rBtn7);
            this.Controls.Add(this.rBtn6);
            this.Controls.Add(this.rBtn5);
            this.Controls.Add(this.rBtn4);
            this.Controls.Add(this.rBtn3);
            this.Controls.Add(this.rBtn2);
            this.Controls.Add(this.rBtn1);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "PreloadForm";
            this.Text = "PreloadForm";
            this.Load += new System.EventHandler(this.PreloadForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rBtnSideA;
        private System.Windows.Forms.RadioButton rBtnSideB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnSideC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBtnCargo;
        private System.Windows.Forms.RadioButton rBtnHatch;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.RadioButton rBtn1;
        private System.Windows.Forms.RadioButton rBtn2;
        private System.Windows.Forms.RadioButton rBtn3;
        private System.Windows.Forms.RadioButton rBtn4;
        private System.Windows.Forms.RadioButton rBtn5;
        private System.Windows.Forms.RadioButton rBtn6;
        private System.Windows.Forms.RadioButton rBtn7;
        private System.Windows.Forms.RadioButton rBtn8;
    }
}