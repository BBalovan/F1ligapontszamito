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


            // Ez az alkalmazás kiszámolja egy népszerű online játékban (F1Liga) szerzett pontokat, így nem kell másnap 0:00-ig várni, ha valaki nagyon kíváncsi.
        }

        int pointsDriverQual;
        int pointsDriver2Qual;
        int pointsEngineQual;
        int pointsEngine2ndQual;
        int pointsChasseeQual;
        int pointsChassee2ndQual;
        int pointsCrewQual;
        int pointsCrew2ndQual;           //Ezek a változók tárolják a helyezésekért kapott pontokat, melyet a végén összeadunk.
        int pointsDriverRace;
        int pointsDriver2Race;
        int pointsEngineRace;
        int pointsEngine2ndRace;
        int pointsChasseeRace;
        int pointsChassee2ndRace;
        int pointsCrewRace;
        int pointsCrew2ndRace;
        
        //Argos idézeteket tároló konstansok
        const string message = "Mi öten vagyunk, Te meg egyen köcsög! Számot írjál be!";
        const string szamokat124Ker = "Tibi, ez így nem lesz jó, 1 és 24 közötti számokat írjál be!";


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
                        pointsDriverQual = Dictionaries.QualDriverDic.SingleOrDefault(r => r.Key == firstDriverQual).Value;

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
                        pointsDriver2Qual = Dictionaries.QualDriverDic.SingleOrDefault(r => r.Key == secondDriverQual).Value;
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
                        pointsEngineQual = Dictionaries.QualTeamDic.SingleOrDefault(r => r.Key == engineQual).Value;
                    }
                    else
                    {
                        MessageBox.Show(szamokat124Ker, "Még ezt a faszt!");
                    }
                }
            }
        }
        private void txtBoxEngine2ndQual_TextChanged_1(object sender, EventArgs e)
        {
           
            string stringEngine2ndQual = txtBoxEngine2ndQual.Text;
            int engine2ndQual;
            bool res = int.TryParse(stringEngine2ndQual, out engine2ndQual);

            if (res == false)
            {
                MessageBox.Show(message, "Még ezt a faszt!");
            }
            else
            {
                engine2ndQual = int.Parse(txtBoxEngine2ndQual.Text);
                if (engine2ndQual > 0 & engine2ndQual < 25)
                {
                    pointsEngine2ndQual = Dictionaries.QualTeamDic.SingleOrDefault(r => r.Key == engine2ndQual).Value;
                }
                else
                {
                    MessageBox.Show(szamokat124Ker, "Még ezt a faszt");
                }
            }
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
                        pointsChasseeQual = Dictionaries.QualTeamDic.SingleOrDefault(r => r.Key == chasseeQual).Value;
                    }
                    else
                    {
                        MessageBox.Show(szamokat124Ker, "Még ezt a faszt");
                    }
                }
            }
        }
        private void txtBoxChassee2ndQual_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxChassee2ndQual.TextLength != 0)
            {

                int chassee2ndQual;
                string stringChassee2ndQual = txtBoxChassee2ndQual.Text;
                bool res = int.TryParse(stringChassee2ndQual, out chassee2ndQual);

                if (res == false)
                {
                    MessageBox.Show(message, "Még ezt a faszt!");
                }
                else
                {
                    chassee2ndQual = int.Parse(txtBoxChassee2ndQual.Text);

                    if (chassee2ndQual > 0 & chassee2ndQual < 25)
                    {
                        pointsChassee2ndQual = Dictionaries.QualTeamDic.SingleOrDefault(r => r.Key == chassee2ndQual).Value;
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
                        pointsCrewQual = Dictionaries.QualTeamDic.SingleOrDefault(r => r.Key == crewQual).Value;
                    }
                    else
                    {
                        MessageBox.Show(szamokat124Ker, "Még ezt a faszt!");
                    }
                }
            }
        }
        private void txtBoxCrew2ndQual_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCrew2ndQual.TextLength != 0)
            {

                int crew2ndQual;
                string stringCrew2ndQual = txtBoxCrew2ndQual.Text;
                bool res = int.TryParse(stringCrew2ndQual, out crew2ndQual);
                if (res == false)
                {
                    MessageBox.Show(message, "Még ezt a faszt!");
                }
                else
                {
                    crew2ndQual = int.Parse(txtBoxCrew2ndQual.Text);

                    if (crew2ndQual > 0 & crew2ndQual < 25)
                    {
                        pointsCrew2ndQual = Dictionaries.QualTeamDic.SingleOrDefault(r => r.Key == crew2ndQual).Value;
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

                        pointsDriverRace = Dictionaries.RaceDriverDic.SingleOrDefault(r => r.Key == firstDriverRace).Value;
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
                        pointsDriver2Race = Dictionaries.RaceDriverDic.SingleOrDefault(r => r.Key == secondDriverRace).Value;
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
                        pointsEngineRace = Dictionaries.RaceTeamDic.SingleOrDefault(r => r.Key == engineRace).Value;
                    }
                    else
                    {
                        MessageBox.Show(szamokat124Ker, "Még ezt a faszt!");
                    }
                }
            }
        }
        private void txtBoxEngine2ndRace_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxEngine2ndRace.TextLength != 0)
            {

                int engine2ndRace;
                string stringEngine2ndRace = txtBoxEngine2ndRace.Text;
                bool res = int.TryParse(stringEngine2ndRace, out engine2ndRace);
                if (res == false)
                {
                    MessageBox.Show(message, "Még ezt a faszt!");
                }
                else
                {

                    engine2ndRace = int.Parse(txtBoxEngineRace.Text);

                    if (engine2ndRace > 0 & engine2ndRace < 25)
                    {
                        pointsEngine2ndRace = Dictionaries.RaceTeamDic.SingleOrDefault(r => r.Key == engine2ndRace).Value;
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

                        pointsChasseeRace = Dictionaries.RaceTeamDic.SingleOrDefault(r => r.Key == chasseeRace).Value;
                    }
                    else
                    {
                        MessageBox.Show(szamokat124Ker, "Még ezt a faszt!");
                    }

                }
            }
        }
        private void txtBoxChassee2ndRace_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxChassee2ndRace.TextLength != 0)
            {

                string stringChassee2ndRace = txtBoxChassee2ndRace.Text;
                int chassee2ndRace;
                bool res = int.TryParse(stringChassee2ndRace, out chassee2ndRace);
                if (res == false)
                {
                    MessageBox.Show(message, "Még ezt a faszt!");
                }
                else
                {

                    chassee2ndRace = int.Parse(txtBoxChassee2ndRace.Text);

                    if (chassee2ndRace > 0 & chassee2ndRace < 25)
                    {

                        pointsChassee2ndRace = Dictionaries.RaceTeamDic.SingleOrDefault(r => r.Key == chassee2ndRace).Value;
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
                        pointsCrewRace = Dictionaries.RaceTeamDic.SingleOrDefault(r => r.Key == crewRace).Value;
                    }
                    else
                    {
                        MessageBox.Show(szamokat124Ker, "Még ezt a faszt!");
                    }
                }
            }
        }
        private void txtBoxCrew2ndRace_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCrew2ndRace.TextLength != 0)
            {
                string stringCrew2ndRace = txtBoxCrew2ndRace.Text;

                int crew2ndRace;
                bool res = int.TryParse(stringCrew2ndRace, out crew2ndRace);
                if (res == false)
                {
                    MessageBox.Show(message, "Még ezt a faszt!");
                }
                else
                {
                    crew2ndRace = int.Parse(txtBoxCrew2ndRace.Text);
                    if (crew2ndRace > 0 & crew2ndRace < 25)
                    {
                        pointsCrew2ndRace = Dictionaries.RaceTeamDic.SingleOrDefault(r => r.Key == crew2ndRace).Value;
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
            finalPoints = pointsDriverQual + pointsDriver2Qual + pointsEngineQual + pointsEngine2ndQual + pointsCrewQual + pointsCrew2ndQual + pointsChasseeQual + pointsChassee2ndQual +pointsDriverRace + pointsDriver2Race + pointsEngineRace + pointsEngine2ndRace + pointsCrewRace + pointsCrew2ndRace + pointsChasseeRace + pointsChassee2ndRace;

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

        private void btnDeleteData_Click_1(object sender, EventArgs e)
        {
            txtBoxChasseeQual.Clear();
            txtBoxChassee2ndQual.Clear();
            txtBoxChasseeRace.Clear();
            txtBoxChassee2ndRace.Clear();
            txtBoxCrewQual.Clear();
            txtBoxCrew2ndQual.Clear();
            txtBoxCrewRace.Clear();
            txtBoxCrew2ndRace.Clear();
            txtBoxEngineQual.Clear();
            txtBoxEngine2ndQual.Clear();
            txtBoxEngineRace.Clear();
            txtBoxEngine2ndRace.Clear();
            txtBoxFirstDriverQual.Clear();
            txtBoxFirstDriverRace.Clear();
            txtBoxSecondDriverQual.Clear();
            txtBoxSecondDriverRace.Clear();
            pointsDriverQual = 0;
            pointsDriver2Qual = 0;
            pointsEngineQual = 0;
            pointsEngine2ndQual = 0;
            pointsChasseeQual = 0;
            pointsChassee2ndQual = 0;
            pointsCrewQual = 0;
            pointsCrew2ndQual = 0;
            pointsDriverRace = 0;
            pointsDriver2Race = 0;
            pointsEngineRace = 0;
            pointsEngine2ndRace = 0;
            pointsChasseeRace = 0;
            pointsChassee2ndRace = 0;
            pointsCrewRace = 0;
            pointsCrew2ndRace = 0;


        }
    }
}
