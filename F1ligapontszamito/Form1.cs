using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace F1ligapontszamito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // FIGYELEM
            // A kódban idézetek találhatóak az Argo c. magyar filmből. Itt-ott trágár szavakkal, baráti társaságnak készült program!

        }

        int pointsDriverQual;
        int pointsDriver2Qual;
        int pointsEngineQual;
        int pointsEngine2ndQual;
        int pointsChasseeQual;
        int pointsCrewQual;
        int pointsDriverRace;
        int pointsDriver2Race;
        int pointsEngineRace;
        int pointsChasseeRace;
        int pointsCrewRace;
        string message = "Mi öten vagyunk, Te meg egyen köcsög! Számot írjál be!";
        string szamokat124Ker = "Tibi, ez így nem lesz jó, 1 és 24 közötti számokat írjál be!";

        private void btnDeleteDatas_Click(object sender, EventArgs e)
        {
            txtBoxChasseeQual.Clear();
            txtBoxChasseeRace.Clear();
            txtBoxCrewQual.Clear();
            txtBoxCrewRace.Clear();
            txtBoxEngineQual.Clear();
            txtBoxEngineRace.Clear();
            txtBoxFirstDriverQual.Clear();
            txtBoxFirstDriverRace.Clear();
            txtBoxSecondDriverQual.Clear();
            txtBoxSecondDriverRace.Clear();
            pointsDriverQual = 0;
            pointsDriver2Qual = 0;
            pointsEngineQual = 0;
            pointsChasseeQual = 0;
            pointsCrewQual = 0;
            pointsDriverRace = 0;
            pointsDriver2Race = 0;
            pointsEngineRace = 0;
            pointsChasseeRace = 0;
            pointsCrewRace = 0;

        }

        private void txtBoxFirstDriverQual_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxFirstDriverQual.TextLength != 0)
            {

                string stringFirstDriverQual = txtBoxFirstDriverQual.Text;
                int firstDriverQual;


                bool res = int.TryParse(stringFirstDriverQual, out firstDriverQual);

                if (res == false)
                {

                    MessageBox.Show(message, "Még ezt a faszt");
                    txtBoxFirstDriverQual.Clear();
                }

                else
                {
                    firstDriverQual = int.Parse(txtBoxFirstDriverQual.Text);

                    if (firstDriverQual > 0 & firstDriverQual < 25)
                    {
                        switch (firstDriverQual)
                        {
                            case 1:
                                pointsDriverQual = 30;
                                break;
                            case 2:
                                pointsDriverQual = 20;
                                break;
                            case 3:
                                pointsDriverQual = 18;
                                break;
                            case 4:
                                pointsDriverQual = 16;
                                break;
                            case 5:
                                pointsDriverQual = 15;
                                break;
                            case 6:
                                pointsDriverQual = 14;
                                break;
                            case 7:
                                pointsDriverQual = 13;
                                break;
                            case 8:
                                pointsDriverQual = 12;
                                break;
                            case 9:
                                pointsDriverQual = 11;
                                break;
                            case 10:
                                pointsDriverQual = 10;
                                break;
                            case 11:
                                pointsDriverQual = 9;
                                break;
                            case 12:
                                pointsDriverQual = 8;
                                break;
                            case 13:
                                pointsDriverQual = 7;
                                break;
                            case 14:
                                pointsDriverQual = 6;
                                break;
                            case 15:
                                pointsDriverQual = 5;
                                break;
                            case 16:
                                pointsDriverQual = 4;
                                break;
                            case 17:
                                pointsDriverQual = 4;
                                break;
                            case 18:
                                pointsDriverQual = 3;
                                break;
                            case 19:
                                pointsDriverQual = 3;
                                break;
                            case 20:
                                pointsDriverQual = 2;
                                break;
                            case 21:
                                pointsDriverQual = 2;
                                break;
                            case 22:
                                pointsDriverQual = 1;
                                break;
                            case 23:
                                pointsDriverQual = 1;
                                break;
                            case 24:
                                pointsDriverQual = 0;
                                break;
                        }

                    }
                    else
                    {
                        MessageBox.Show(szamokat124Ker, "Még ezt a faszt!");
                    }
                }
            }

        }
        private void txtBoxSecondDriverQual_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxSecondDriverQual.TextLength != 0)
            {
                int secondDriverQual;
                string stringSecondDriverQual = txtBoxSecondDriverQual.Text;
                bool res = int.TryParse(stringSecondDriverQual, out secondDriverQual);

                if (res == false)
                {
                    MessageBox.Show(message, "Még ezt a faszt!");
                }
                else
                {
                    secondDriverQual = int.Parse(txtBoxSecondDriverQual.Text);


                    if (secondDriverQual > 0 & secondDriverQual < 25)
                    {
                        switch (secondDriverQual)
                        {
                            case 1:
                                pointsDriver2Qual = 30;
                                break;
                            case 2:
                                pointsDriver2Qual = 20;
                                break;
                            case 3:
                                pointsDriver2Qual = 18;
                                break;
                            case 4:
                                pointsDriver2Qual = 16;
                                break;
                            case 5:
                                pointsDriver2Qual = 15;
                                break;
                            case 6:
                                pointsDriver2Qual = 14;
                                break;
                            case 7:
                                pointsDriver2Qual = 13;
                                break;
                            case 8:
                                pointsDriver2Qual = 12;
                                break;
                            case 9:
                                pointsDriver2Qual = 11;
                                break;
                            case 10:
                                pointsDriver2Qual = 10;
                                break;
                            case 11:
                                pointsDriver2Qual = 9;
                                break;
                            case 12:
                                pointsDriver2Qual = 8;
                                break;
                            case 13:
                                pointsDriver2Qual = 7;
                                break;
                            case 14:
                                pointsDriver2Qual = 6;
                                break;
                            case 15:
                                pointsDriver2Qual = 5;
                                break;
                            case 16:
                                pointsDriver2Qual = 4;
                                break;
                            case 17:
                                pointsDriver2Qual = 4;
                                break;
                            case 18:
                                pointsDriver2Qual = 3;
                                break;
                            case 19:
                                pointsDriver2Qual = 3;
                                break;
                            case 20:
                                pointsDriver2Qual = 2;
                                break;
                            case 21:
                                pointsDriver2Qual = 2;
                                break;
                            case 22:
                                pointsDriver2Qual = 1;
                                break;
                            case 23:
                                pointsDriver2Qual = 1;
                                break;
                            case 24:
                                pointsDriver2Qual = 0;
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show(szamokat124Ker, "Még ezt a faszt!");
                    }
                }
            }
        }

        private void txtBoxEngineQual_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxEngineQual.TextLength != 0)
            {
                string stringEngineQual = txtBoxEngineQual.Text;
                int engineQual;
                bool res = int.TryParse(stringEngineQual, out engineQual);

                if (res == false)
                {
                    MessageBox.Show(message, "Még ezt a faszt!");
                }
                else
                {
                    engineQual = int.Parse(txtBoxEngineQual.Text);

                    if (engineQual > 0 & engineQual < 25)
                    {
                        switch (engineQual)
                        {
                            case 1:
                                pointsEngineQual = 15;
                                break;
                            case 2:
                                pointsEngineQual = 10;
                                break;
                            case 3:
                                pointsEngineQual = 8;
                                break;
                            case 4:
                                pointsEngineQual = 7;
                                break;
                            case 5:
                                pointsEngineQual = 6;
                                break;
                            case 6:
                                pointsEngineQual = 5;
                                break;
                            case 7:
                                pointsEngineQual = 4;
                                break;
                            case 8:
                                pointsEngineQual = 3;
                                break;
                            case 9:
                                pointsEngineQual = 2;
                                break;
                            case 10:
                                pointsEngineQual = 1;
                                break;
                            default:
                                pointsEngineQual = 0;
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show(szamokat124Ker, "Még ezt a faszt!");
                    }
                }
            }
        }

        private void txtBoxEngine2ndQual_TextChanged(object sender, EventArgs e)
        //Gyakorlatilag ugyanazt szeretném elérni, mint feljebb, csak dictionary használatával.
        //Egyelőre nem működik.
        {
            var dic = new Dictionary<int, int>
                        {
                            {1, 15}, 
                            {2, 10},
                            {3, 8},
                            {4, 7},
                            {5, 6},
                            {6, 5},
                            {7, 4},
                            {8, 3},
                            {9, 2},
                            {10, 1}
                          
                        };


            string stringEngine2ndQual = txtBoxEngine2ndQual.Text;
            int engine2ndQual;
            var success = int.TryParse(stringEngine2ndQual, out engine2ndQual);
            pointsEngine2ndQual = success ? dic.SingleOrDefault(r => r.Value == pointsEngine2ndQual).Value : 0;

        }        
        private void txtBoxChasseeQual_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxChasseeQual.TextLength != 0)
            {

                int chasseeQual;
                string stringChasseeQual = txtBoxChasseeQual.Text;
                bool res = int.TryParse(stringChasseeQual, out chasseeQual);

                if (res == false)
                {
                    MessageBox.Show(message, "Még ezt a faszt!");
                }
                else
                {
                    chasseeQual = int.Parse(txtBoxChasseeQual.Text);

                    if (chasseeQual > 0 & chasseeQual < 25)
                    {
                        switch (chasseeQual)
                        {
                            case 1:
                                pointsChasseeQual = 15;
                                break;
                            case 2:
                                pointsChasseeQual = 10;
                                break;
                            case 3:
                                pointsChasseeQual = 8;
                                break;
                            case 4:
                                pointsChasseeQual = 7;
                                break;
                            case 5:
                                pointsChasseeQual = 6;
                                break;
                            case 6:
                                pointsChasseeQual = 5;
                                break;
                            case 7:
                                pointsChasseeQual = 4;
                                break;
                            case 8:
                                pointsChasseeQual = 3;
                                break;
                            case 9:
                                pointsChasseeQual = 2;
                                break;
                            case 10:
                                pointsChasseeQual = 1;
                                break;
                            default:
                                pointsChasseeQual = 0;
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show(szamokat124Ker, "Még ezt a faszt");
                    }
                }
            }
        }
        private void txtBoxCrewQual_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCrewQual.TextLength != 0)
            {

                int crewQual;
                string stringCrewQual = txtBoxCrewQual.Text;
                bool res = int.TryParse(stringCrewQual, out crewQual);
                if (res == false)
                {
                    MessageBox.Show(message, "Még ezt a faszt!");
                }
                else
                {
                    crewQual = int.Parse(txtBoxCrewQual.Text);

                    if (crewQual > 0 & crewQual < 25)
                    {
                        switch (crewQual)
                        {
                            case 1:
                                pointsCrewQual = 15;
                                break;
                            case 2:
                                pointsCrewQual = 10;
                                break;
                            case 3:
                                pointsCrewQual = 8;
                                break;
                            case 4:
                                pointsCrewQual = 7;
                                break;
                            case 5:
                                pointsCrewQual = 6;
                                break;
                            case 6:
                                pointsCrewQual = 5;
                                break;
                            case 7:
                                pointsCrewQual = 4;
                                break;
                            case 8:
                                pointsCrewQual = 3;
                                break;
                            case 9:
                                pointsCrewQual = 2;
                                break;
                            case 10:
                                pointsCrewQual = 1;
                                break;
                            default:
                                pointsCrewQual = 0;
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show(szamokat124Ker, "Még ezt a faszt!");
                    }
                }
            }
        }

        private void txtBoxFirstDriverRace_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxFirstDriverRace.TextLength != 0)
            {
                int firstDriverRace;
                string stringFirstDriverRace = txtBoxFirstDriverRace.Text;
                bool res = int.TryParse(stringFirstDriverRace, out firstDriverRace);

                if (res == false)
                {
                    MessageBox.Show(message, "Még ezt a faszt!");
                }
                else
                {
                    firstDriverRace = int.Parse(txtBoxFirstDriverRace.Text);

                    if (firstDriverRace > 0 & firstDriverRace < 25)
                    {
                        switch (firstDriverRace)
                        {
                            case 1:
                                pointsDriverRace = 100;
                                break;
                            case 2:
                                pointsDriverRace = 80;
                                break;
                            case 3:
                                pointsDriverRace = 70;
                                break;
                            case 4:
                                pointsDriverRace = 60;
                                break;
                            case 5:
                                pointsDriverRace = 50;
                                break;
                            case 6:
                                pointsDriverRace = 40;
                                break;
                            case 7:
                                pointsDriverRace = 30;
                                break;
                            case 8:
                                pointsDriverRace = 25;
                                break;
                            case 9:
                                pointsDriverRace = 20;
                                break;
                            case 10:
                                pointsDriverRace = 15;
                                break;
                            case 11:
                                pointsDriverRace = 13;
                                break;
                            case 12:
                                pointsDriverRace = 10;
                                break;
                            case 13:
                                pointsDriverRace = 8;
                                break;
                            case 14:
                                pointsDriverRace = 6;
                                break;
                            case 15:
                                pointsDriverRace = 5;
                                break;
                            case 16:
                                pointsDriverRace = 4;
                                break;
                            case 17:
                                pointsDriverRace = 4;
                                break;
                            case 18:
                                pointsDriverRace = 3;
                                break;
                            case 19:
                                pointsDriverRace = 3;
                                break;
                            case 20:
                                pointsDriverRace = 2;
                                break;
                            case 21:
                                pointsDriverRace = 2;
                                break;
                            case 22:
                                pointsDriverRace = 1;
                                break;
                            case 23:
                                pointsDriverRace = 1;
                                break;
                            case 24:
                                pointsDriverRace = 0;
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show(szamokat124Ker, "Még ezt a faszt!");
                    }
                }
            }
        }

        private void txtBoxSecondDriverRace_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxSecondDriverRace.TextLength != 0)
            {

                string stringSecondDriverRace = txtBoxSecondDriverRace.Text;
                int secondDriverRace;
                bool res = int.TryParse(stringSecondDriverRace, out secondDriverRace);

                if (res == false)
                {
                    MessageBox.Show(message, "Még ezt a faszt!");
                }

                else
                {
                    secondDriverRace = int.Parse(txtBoxSecondDriverRace.Text);


                    if (secondDriverRace > 0 & secondDriverRace < 25)
                    {
                        switch (secondDriverRace)
                        {
                            case 1:
                                pointsDriver2Race = 100;
                                break;
                            case 2:
                                pointsDriver2Race = 80;
                                break;
                            case 3:
                                pointsDriver2Race = 70;
                                break;
                            case 4:
                                pointsDriver2Race = 60;
                                break;
                            case 5:
                                pointsDriver2Race = 50;
                                break;
                            case 6:
                                pointsDriver2Race = 40;
                                break;
                            case 7:
                                pointsDriver2Race = 30;
                                break;
                            case 8:
                                pointsDriver2Race = 25;
                                break;
                            case 9:
                                pointsDriver2Race = 20;
                                break;
                            case 10:
                                pointsDriver2Race = 15;
                                break;
                            case 11:
                                pointsDriver2Race = 13;
                                break;
                            case 12:
                                pointsDriver2Race = 10;
                                break;
                            case 13:
                                pointsDriver2Race = 8;
                                break;
                            case 14:
                                pointsDriver2Race = 6;
                                break;
                            case 15:
                                pointsDriver2Race = 5;
                                break;
                            case 16:
                                pointsDriver2Race = 4;
                                break;
                            case 17:
                                pointsDriver2Race = 4;
                                break;
                            case 18:
                                pointsDriver2Race = 3;
                                break;
                            case 19:
                                pointsDriver2Race = 3;
                                break;
                            case 20:
                                pointsDriver2Race = 2;
                                break;
                            case 21:
                                pointsDriver2Race = 2;
                                break;
                            case 22:
                                pointsDriver2Race = 1;
                                break;
                            case 23:
                                pointsDriver2Race = 1;
                                break;
                            case 24:
                                pointsDriver2Race = 0;
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show(szamokat124Ker, "Még ezt a faszt!");
                    }
                }
            }
        }
        private void txtBoxEngineRace_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxEngineRace.TextLength != 0)
            {

                int engineRace;
                string stringEngineRace = txtBoxEngineRace.Text;
                bool res = int.TryParse(stringEngineRace, out engineRace);
                if (res == false)
                {
                    MessageBox.Show(message, "Még ezt a faszt!");
                }
                else
                {

                    engineRace = int.Parse(txtBoxEngineRace.Text);

                    if (engineRace > 0 & engineRace < 25)
                    {
                        switch (engineRace)
                        {
                            case 1:
                                pointsEngineRace = 45;
                                break;
                            case 2:
                                pointsEngineRace = 35;
                                break;
                            case 3:
                                pointsEngineRace = 30;
                                break;
                            case 4:
                                pointsEngineRace = 26;
                                break;
                            case 5:
                                pointsEngineRace = 24;
                                break;
                            case 6:
                                pointsEngineRace = 22;
                                break;
                            case 7:
                                pointsEngineRace = 20;
                                break;
                            case 8:
                                pointsEngineRace = 18;
                                break;
                            case 9:
                                pointsEngineRace = 16;
                                break;
                            case 10:
                                pointsEngineRace = 14;
                                break;
                            case 11:
                                pointsEngineRace = 12;
                                break;
                            case 12:
                                pointsEngineRace = 10;
                                break;
                            case 13:
                                pointsEngineRace = 8;
                                break;
                            case 14:
                                pointsEngineRace = 6;
                                break;
                            case 15:
                                pointsEngineRace = 5;
                                break;
                            case 16:
                                pointsEngineRace = 4;
                                break;
                            case 17:
                                pointsEngineRace = 4;
                                break;
                            case 18:
                                pointsEngineRace = 3;
                                break;
                            case 19:
                                pointsEngineRace = 3;
                                break;
                            case 20:
                                pointsEngineRace = 2;
                                break;
                            case 21:
                                pointsEngineRace = 2;
                                break;
                            case 22:
                                pointsEngineRace = 1;
                                break;
                            case 23:
                                pointsEngineRace = 1;
                                break;
                            case 24:
                                pointsEngineRace = 0;
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show(szamokat124Ker, "Még ezt a faszt!");
                    }
                }
            }
        }
        private void txtBoxChasseeRace_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxChasseeRace.TextLength != 0)
            {

                string stringChasseeRace = txtBoxChasseeRace.Text;
                int chasseeRace;
                bool res = int.TryParse(stringChasseeRace, out chasseeRace);
                if (res == false)
                {
                    MessageBox.Show(message, "Még ezt a faszt!");
                }
                else
                {

                    chasseeRace = int.Parse(txtBoxChasseeRace.Text);

                    if (chasseeRace > 0 & chasseeRace < 25)
                    {

                        switch (chasseeRace)
                        {
                            case 1:
                                pointsChasseeRace = 45;
                                break;
                            case 2:
                                pointsChasseeRace = 35;
                                break;
                            case 3:
                                pointsChasseeRace = 30;
                                break;
                            case 4:
                                pointsChasseeRace = 26;
                                break;
                            case 5:
                                pointsChasseeRace = 24;
                                break;
                            case 6:
                                pointsChasseeRace = 22;
                                break;
                            case 7:
                                pointsChasseeRace = 20;
                                break;
                            case 8:
                                pointsChasseeRace = 18;
                                break;
                            case 9:
                                pointsChasseeRace = 16;
                                break;
                            case 10:
                                pointsChasseeRace = 14;
                                break;
                            case 11:
                                pointsChasseeRace = 12;
                                break;
                            case 12:
                                pointsChasseeRace = 10;
                                break;
                            case 13:
                                pointsChasseeRace = 8;
                                break;
                            case 14:
                                pointsChasseeRace = 6;
                                break;
                            case 15:
                                pointsChasseeRace = 5;
                                break;
                            case 16:
                                pointsChasseeRace = 4;
                                break;
                            case 17:
                                pointsChasseeRace = 4;
                                break;
                            case 18:
                                pointsChasseeRace = 3;
                                break;
                            case 19:
                                pointsChasseeRace = 3;
                                break;
                            case 20:
                                pointsChasseeRace = 2;
                                break;
                            case 21:
                                pointsChasseeRace = 2;
                                break;
                            case 22:
                                pointsChasseeRace = 1;
                                break;
                            case 23:
                                pointsChasseeRace = 1;
                                break;
                            case 24:
                                pointsChasseeRace = 0;
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show(szamokat124Ker, "Még ezt a faszt!");
                    }

                }
            }
        }

        private void txtBoxCrewRace_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCrewRace.TextLength != 0)
            {
                string stringCrewRace = txtBoxCrewRace.Text;

                int crewRace;
                bool res = int.TryParse(stringCrewRace, out crewRace);
                if (res == false)
                {
                    MessageBox.Show(message, "Még ezt a faszt!");
                }
                else
                {
                    crewRace = int.Parse(txtBoxCrewRace.Text);
                    if (crewRace > 0 & crewRace < 25)
                    {
                        switch (crewRace)
                        {
                            case 1:
                                pointsCrewRace = 45;
                                break;
                            case 2:
                                pointsCrewRace = 35;
                                break;
                            case 3:
                                pointsCrewRace = 30;
                                break;
                            case 4:
                                pointsCrewRace = 26;
                                break;
                            case 5:
                                pointsCrewRace = 24;
                                break;
                            case 6:
                                pointsCrewRace = 22;
                                break;
                            case 7:
                                pointsCrewRace = 20;
                                break;
                            case 8:
                                pointsCrewRace = 18;
                                break;
                            case 9:
                                pointsCrewRace = 16;
                                break;
                            case 10:
                                pointsCrewRace = 14;
                                break;
                            case 11:
                                pointsCrewRace = 12;
                                break;
                            case 12:
                                pointsCrewRace = 10;
                                break;
                            case 13:
                                pointsCrewRace = 8;
                                break;
                            case 14:
                                pointsCrewRace = 6;
                                break;
                            case 15:
                                pointsCrewRace = 5;
                                break;
                            case 16:
                                pointsCrewRace = 4;
                                break;
                            case 17:
                                pointsCrewRace = 4;
                                break;
                            case 18:
                                pointsCrewRace = 3;
                                break;
                            case 19:
                                pointsCrewRace = 3;
                                break;
                            case 20:
                                pointsCrewRace = 2;
                                break;
                            case 21:
                                pointsCrewRace = 2;
                                break;
                            case 22:
                                pointsCrewRace = 1;
                                break;
                            case 23:
                                pointsCrewRace = 1;
                                break;
                            case 24:
                                pointsCrewRace = 0;
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show(szamokat124Ker, "Még ezt a faszt!");
                    }
                }
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {



            int finalPoints;
            finalPoints = pointsDriverQual + pointsDriver2Qual + pointsEngineQual + pointsEngine2ndQual + pointsCrewQual + pointsChasseeQual + pointsDriverRace + pointsDriver2Race + pointsEngineRace + pointsCrewRace + pointsChasseeRace;

            if (finalPoints <= 80)
            {
                MessageBox.Show("Baszd meg, nem hiszem el! Mit csinálsz?? Sok nekünk ez a meló... " + finalPoints.ToString() + " pont.", "Pontszám");
            }
            else if (finalPoints <= 100 & finalPoints > 80)
            {
                MessageBox.Show("Valaki elmegy benzinért! " + finalPoints.ToString() + " pont.", "Pontszám");
            }
            else if (finalPoints <= 170 & finalPoints > 100)
            {
                MessageBox.Show("Te kurva élet! Múlt héten ugyanez történt egy hülyegyerekkel. Lakatost kellett hívni " + finalPoints.ToString() + " pont", "Pontszám");
            }
            else if (finalPoints <= 250 & finalPoints > 170)
            {
                MessageBox.Show("Jobb, mint az a gizda dzsip!" + finalPoints.ToString() + " pont!", "Pontszám");
            }
            else
            {
                MessageBox.Show("Elhagyjuk a kispályát! " + finalPoints.ToString() + " pont!", "Pontszám");
            }


        }



    }
}
