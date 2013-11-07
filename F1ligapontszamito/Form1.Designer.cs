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
            this.btnDeleteDatas = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.btnCalc.TabIndex = 11;
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
            this.txtBoxEngineQual.Size = new System.Drawing.Size(100, 20);
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
            this.txtBoxChasseeQual.Size = new System.Drawing.Size(100, 20);
            this.txtBoxChasseeQual.TabIndex = 4;
            this.txtBoxChasseeQual.TextChanged += new System.EventHandler(this.txtBoxChasseeQual_TextChanged);
            // 
            // txtBoxCrewQual
            // 
            this.txtBoxCrewQual.Location = new System.Drawing.Point(136, 222);
            this.txtBoxCrewQual.Name = "txtBoxCrewQual";
            this.txtBoxCrewQual.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCrewQual.TabIndex = 5;
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
            this.txtBoxFirstDriverRace.TabIndex = 6;
            this.txtBoxFirstDriverRace.TextChanged += new System.EventHandler(this.txtBoxFirstDriverRace_TextChanged);
            // 
            // txtBoxSecondDriverRace
            // 
            this.txtBoxSecondDriverRace.Location = new System.Drawing.Point(263, 144);
            this.txtBoxSecondDriverRace.Name = "txtBoxSecondDriverRace";
            this.txtBoxSecondDriverRace.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSecondDriverRace.TabIndex = 7;
            this.txtBoxSecondDriverRace.TextChanged += new System.EventHandler(this.txtBoxSecondDriverRace_TextChanged);
            // 
            // txtBoxEngineRace
            // 
            this.txtBoxEngineRace.Location = new System.Drawing.Point(263, 170);
            this.txtBoxEngineRace.Name = "txtBoxEngineRace";
            this.txtBoxEngineRace.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEngineRace.TabIndex = 8;
            this.txtBoxEngineRace.TextChanged += new System.EventHandler(this.txtBoxEngineRace_TextChanged);
            // 
            // txtBoxChasseeRace
            // 
            this.txtBoxChasseeRace.Location = new System.Drawing.Point(263, 196);
            this.txtBoxChasseeRace.Name = "txtBoxChasseeRace";
            this.txtBoxChasseeRace.Size = new System.Drawing.Size(100, 20);
            this.txtBoxChasseeRace.TabIndex = 9;
            this.txtBoxChasseeRace.TextChanged += new System.EventHandler(this.txtBoxChasseeRace_TextChanged);
            // 
            // txtBoxCrewRace
            // 
            this.txtBoxCrewRace.Location = new System.Drawing.Point(263, 222);
            this.txtBoxCrewRace.Name = "txtBoxCrewRace";
            this.txtBoxCrewRace.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCrewRace.TabIndex = 10;
            this.txtBoxCrewRace.TextChanged += new System.EventHandler(this.txtBoxCrewRace_TextChanged);
            // 
            // btnDeleteDatas
            // 
            this.btnDeleteDatas.Location = new System.Drawing.Point(12, 266);
            this.btnDeleteDatas.Name = "btnDeleteDatas";
            this.btnDeleteDatas.Size = new System.Drawing.Size(117, 23);
            this.btnDeleteDatas.TabIndex = 0;
            this.btnDeleteDatas.Text = "Adatok törlése";
            this.btnDeleteDatas.UseVisualStyleBackColor = true;
            this.btnDeleteDatas.Click += new System.EventHandler(this.btnDeleteDatas_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(390, 347);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDeleteDatas);
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
        private System.Windows.Forms.Button btnDeleteDatas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

