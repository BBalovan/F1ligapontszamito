namespace F1ligapontszamito
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxFirstDriverQual = new System.Windows.Forms.TextBox();
            this.txtBoxEngineQual = new System.Windows.Forms.TextBox();
            this.txtBoxSecondDriverQual = new System.Windows.Forms.TextBox();
            this.txtBoxChasseeQual = new System.Windows.Forms.TextBox();
            this.txtBoxCrewQual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxFirstDriverRace = new System.Windows.Forms.TextBox();
            this.txtBoxSecondDriverRace = new System.Windows.Forms.TextBox();
            this.txtBoxEngineRace = new System.Windows.Forms.TextBox();
            this.txtBoxChasseeRace = new System.Windows.Forms.TextBox();
            this.txtBoxCrewRace = new System.Windows.Forms.TextBox();
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxEngine2ndQual = new System.Windows.Forms.TextBox();
            this.txtBoxChassee2ndQual = new System.Windows.Forms.TextBox();
            this.txtBoxCrew2ndQual = new System.Windows.Forms.TextBox();
            this.txtBoxEngine2ndRace = new System.Windows.Forms.TextBox();
            this.txtBoxChassee2ndRace = new System.Windows.Forms.TextBox();
            this.txtBoxCrew2ndRace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalc.BackgroundImage")));
            this.btnCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCalc.ForeColor = System.Drawing.Color.Black;
            this.btnCalc.Location = new System.Drawing.Point(200, 248);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(103, 88);
            this.btnCalc.TabIndex = 17;
            this.btnCalc.Text = "Számítás";
            this.btnCalc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Versenyző helyezése:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. versenyző helyezése:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Motor helyezése:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Karosszéria helyezése:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Személyzet helyezése:";
            // 
            // txtBoxFirstDriverQual
            // 
            this.txtBoxFirstDriverQual.Location = new System.Drawing.Point(136, 120);
            this.txtBoxFirstDriverQual.Name = "txtBoxFirstDriverQual";
            this.txtBoxFirstDriverQual.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFirstDriverQual.TabIndex = 1;
            this.txtBoxFirstDriverQual.TextChanged += new System.EventHandler(this.txtBoxFirstDriverQual_TextChanged);
            // 
            // txtBoxEngineQual
            // 
            this.txtBoxEngineQual.Location = new System.Drawing.Point(136, 170);
            this.txtBoxEngineQual.Name = "txtBoxEngineQual";
            this.txtBoxEngineQual.Size = new System.Drawing.Size(41, 20);
            this.txtBoxEngineQual.TabIndex = 3;
            this.txtBoxEngineQual.TextChanged += new System.EventHandler(this.txtBoxEngineQual_TextChanged);
            // 
            // txtBoxSecondDriverQual
            // 
            this.txtBoxSecondDriverQual.Location = new System.Drawing.Point(136, 144);
            this.txtBoxSecondDriverQual.Name = "txtBoxSecondDriverQual";
            this.txtBoxSecondDriverQual.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSecondDriverQual.TabIndex = 2;
            this.txtBoxSecondDriverQual.TextChanged += new System.EventHandler(this.txtBoxSecondDriverQual_TextChanged);
            // 
            // txtBoxChasseeQual
            // 
            this.txtBoxChasseeQual.Location = new System.Drawing.Point(136, 196);
            this.txtBoxChasseeQual.Name = "txtBoxChasseeQual";
            this.txtBoxChasseeQual.Size = new System.Drawing.Size(41, 20);
            this.txtBoxChasseeQual.TabIndex = 5;
            this.txtBoxChasseeQual.TextChanged += new System.EventHandler(this.txtBoxChasseeQual_TextChanged);
            // 
            // txtBoxCrewQual
            // 
            this.txtBoxCrewQual.Location = new System.Drawing.Point(136, 222);
            this.txtBoxCrewQual.Name = "txtBoxCrewQual";
            this.txtBoxCrewQual.Size = new System.Drawing.Size(41, 20);
            this.txtBoxCrewQual.TabIndex = 7;
            this.txtBoxCrewQual.TextChanged += new System.EventHandler(this.txtBoxCrewQual_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Időmérő";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Verseny";
            // 
            // txtBoxFirstDriverRace
            // 
            this.txtBoxFirstDriverRace.Location = new System.Drawing.Point(263, 120);
            this.txtBoxFirstDriverRace.Name = "txtBoxFirstDriverRace";
            this.txtBoxFirstDriverRace.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFirstDriverRace.TabIndex = 9;
            this.txtBoxFirstDriverRace.TextChanged += new System.EventHandler(this.txtBoxFirstDriverRace_TextChanged);
            // 
            // txtBoxSecondDriverRace
            // 
            this.txtBoxSecondDriverRace.Location = new System.Drawing.Point(263, 144);
            this.txtBoxSecondDriverRace.Name = "txtBoxSecondDriverRace";
            this.txtBoxSecondDriverRace.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSecondDriverRace.TabIndex = 10;
            this.txtBoxSecondDriverRace.TextChanged += new System.EventHandler(this.txtBoxSecondDriverRace_TextChanged);
            // 
            // txtBoxEngineRace
            // 
            this.txtBoxEngineRace.Location = new System.Drawing.Point(263, 170);
            this.txtBoxEngineRace.Name = "txtBoxEngineRace";
            this.txtBoxEngineRace.Size = new System.Drawing.Size(40, 20);
            this.txtBoxEngineRace.TabIndex = 11;
            this.txtBoxEngineRace.TextChanged += new System.EventHandler(this.txtBoxEngineRace_TextChanged);
            // 
            // txtBoxChasseeRace
            // 
            this.txtBoxChasseeRace.Location = new System.Drawing.Point(263, 196);
            this.txtBoxChasseeRace.Name = "txtBoxChasseeRace";
            this.txtBoxChasseeRace.Size = new System.Drawing.Size(40, 20);
            this.txtBoxChasseeRace.TabIndex = 13;
            this.txtBoxChasseeRace.TextChanged += new System.EventHandler(this.txtBoxChasseeRace_TextChanged);
            // 
            // txtBoxCrewRace
            // 
            this.txtBoxCrewRace.Location = new System.Drawing.Point(263, 222);
            this.txtBoxCrewRace.Name = "txtBoxCrewRace";
            this.txtBoxCrewRace.Size = new System.Drawing.Size(40, 20);
            this.txtBoxCrewRace.TabIndex = 15;
            this.txtBoxCrewRace.TextChanged += new System.EventHandler(this.txtBoxCrewRace_TextChanged);
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.Location = new System.Drawing.Point(12, 266);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(117, 23);
            this.btnDeleteData.TabIndex = 18;
            this.btnDeleteData.Text = "Adatok törlése";
            this.btnDeleteData.UseVisualStyleBackColor = true;
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(28, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 9);
            this.label9.TabIndex = 14;
            this.label9.Text = "© Balován Bence 2013";
            // 
            // txtBoxEngine2ndQual
            // 
            this.txtBoxEngine2ndQual.Location = new System.Drawing.Point(196, 170);
            this.txtBoxEngine2ndQual.Name = "txtBoxEngine2ndQual";
            this.txtBoxEngine2ndQual.Size = new System.Drawing.Size(40, 20);
            this.txtBoxEngine2ndQual.TabIndex = 4;
<<<<<<< HEAD
            this.txtBoxEngine2ndQual.TextChanged += new System.EventHandler(this.txtBoxEngine2ndQual_TextChanged_1);
=======
            this.txtBoxEngine2ndQual.TextChanged += new System.EventHandler(this.txtBoxEngine2ndQual_TextChanged);
>>>>>>> c03264fce4bf40d18af4753c9d75984528aba91e
            // 
            // txtBoxChassee2ndQual
            // 
            this.txtBoxChassee2ndQual.Location = new System.Drawing.Point(196, 196);
            this.txtBoxChassee2ndQual.Name = "txtBoxChassee2ndQual";
            this.txtBoxChassee2ndQual.Size = new System.Drawing.Size(40, 20);
            this.txtBoxChassee2ndQual.TabIndex = 6;
            // 
            // txtBoxCrew2ndQual
            // 
            this.txtBoxCrew2ndQual.Location = new System.Drawing.Point(196, 222);
            this.txtBoxCrew2ndQual.Name = "txtBoxCrew2ndQual";
            this.txtBoxCrew2ndQual.Size = new System.Drawing.Size(40, 20);
            this.txtBoxCrew2ndQual.TabIndex = 8;
            // 
            // txtBoxEngine2ndRace
            // 
            this.txtBoxEngine2ndRace.Location = new System.Drawing.Point(323, 170);
            this.txtBoxEngine2ndRace.Name = "txtBoxEngine2ndRace";
            this.txtBoxEngine2ndRace.Size = new System.Drawing.Size(40, 20);
            this.txtBoxEngine2ndRace.TabIndex = 12;
            // 
            // txtBoxChassee2ndRace
            // 
            this.txtBoxChassee2ndRace.Location = new System.Drawing.Point(323, 196);
            this.txtBoxChassee2ndRace.Name = "txtBoxChassee2ndRace";
            this.txtBoxChassee2ndRace.Size = new System.Drawing.Size(40, 20);
            this.txtBoxChassee2ndRace.TabIndex = 14;
            // 
            // txtBoxCrew2ndRace
            // 
            this.txtBoxCrew2ndRace.Location = new System.Drawing.Point(323, 222);
            this.txtBoxCrew2ndRace.Name = "txtBoxCrew2ndRace";
            this.txtBoxCrew2ndRace.Size = new System.Drawing.Size(40, 20);
            this.txtBoxCrew2ndRace.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(390, 347);
            this.Controls.Add(this.txtBoxCrew2ndRace);
            this.Controls.Add(this.txtBoxChassee2ndRace);
            this.Controls.Add(this.txtBoxEngine2ndRace);
            this.Controls.Add(this.txtBoxCrew2ndQual);
            this.Controls.Add(this.txtBoxChassee2ndQual);
            this.Controls.Add(this.txtBoxEngine2ndQual);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDeleteData);
            this.Controls.Add(this.txtBoxCrewRace);
            this.Controls.Add(this.txtBoxChasseeRace);
            this.Controls.Add(this.txtBoxEngineRace);
            this.Controls.Add(this.txtBoxSecondDriverRace);
            this.Controls.Add(this.txtBoxFirstDriverRace);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxCrewQual);
            this.Controls.Add(this.txtBoxChasseeQual);
            this.Controls.Add(this.txtBoxSecondDriverQual);
            this.Controls.Add(this.txtBoxEngineQual);
            this.Controls.Add(this.txtBoxFirstDriverQual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "F1Liga pontszámító - Tiby Security edition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxFirstDriverQual;
        private System.Windows.Forms.TextBox txtBoxEngineQual;
        private System.Windows.Forms.TextBox txtBoxSecondDriverQual;
        private System.Windows.Forms.TextBox txtBoxChasseeQual;
        private System.Windows.Forms.TextBox txtBoxCrewQual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxFirstDriverRace;
        private System.Windows.Forms.TextBox txtBoxSecondDriverRace;
        private System.Windows.Forms.TextBox txtBoxEngineRace;
        private System.Windows.Forms.TextBox txtBoxChasseeRace;
        private System.Windows.Forms.TextBox txtBoxCrewRace;
        private System.Windows.Forms.Button btnDeleteData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxEngine2ndQual;
        private System.Windows.Forms.TextBox txtBoxChassee2ndQual;
        private System.Windows.Forms.TextBox txtBoxCrew2ndQual;
        private System.Windows.Forms.TextBox txtBoxEngine2ndRace;
        private System.Windows.Forms.TextBox txtBoxChassee2ndRace;
        private System.Windows.Forms.TextBox txtBoxCrew2ndRace;
    }
}

