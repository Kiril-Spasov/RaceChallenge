using System;
using System.Drawing;
using System.Windows.Forms;

namespace RaceChallenge
{
    public partial class FormRaceChallenge : Form
    {
        public FormRaceChallenge()
        {
            InitializeComponent();
        }

        //Use image arrays to simulate animation.
        Image[] redCarImages = new Image[11];
        Image[] yellowCarImages = new Image[2];

        int countRed = 0;
        int countYellow = 0;

        Random r = new Random();


        //Store the images for both cars in the image arrays.
        private void FormRaceChallenge_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                redCarImages[i] = Image.FromFile(Application.StartupPath + @"\redcar\redcar" + i.ToString() + ".png");
            }

            for (int i = 0; i <= 1; i++)
            {
                yellowCarImages[i] = Image.FromFile(Application.StartupPath + @"\yellowcar\yellowcar" + i.ToString() + ".png");
            }

            PicRedCar.Image = redCarImages[0];
            PicYellowCar.Image = yellowCarImages[0];

        }

        //timer1 simulate cars animation
        private void timer1_Tick(object sender, EventArgs e)
        {
            PicRedCar.Image = redCarImages[countRed];
            countRed++;
            if (countRed > 10)
                countRed = 0;

            PicYellowCar.Image = yellowCarImages[countYellow];
            countYellow++;
            if (countYellow > 1)
                countYellow = 0;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        //timer2 moves cars randomly each tick
        private void timer2_Tick(object sender, EventArgs e)
        {          
            PicRedCar.Left += r.Next(10, 16);
            PicYellowCar.Left += r.Next(10, 16);

            if (PicRedCar.Left + PicRedCar.Width >= ClientRectangle.Width && PicYellowCar.Left + PicYellowCar.Width >= ClientRectangle.Width)
            {
                timer2.Enabled = false;
                MessageBox.Show("It's a tie.");
            }
            else if (PicRedCar.Left + PicRedCar.Width >= ClientRectangle.Width)
            { 
                timer2.Enabled = false;
                MessageBox.Show("Red car wins.");
            }      
            else if (PicYellowCar.Left + PicYellowCar.Width >= ClientRectangle.Width)
            {
                timer2.Enabled = false;
                MessageBox.Show("Yellow car wins.");
            }  

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            PicRedCar.Left = 50;
            PicYellowCar.Left = 50;
            timer2.Enabled = false;
        }
    }
}
