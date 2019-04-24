using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{ 
    public partial class Form1 : Form
    {
         
        Random rand = new Random();
        
        int x, y;
        bool startGame = false;
        int randomNum;
        
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (startGame)
            {
                btn_Start.Text = "Start";

                btn_Bigger.Visible = false;
                btn_Less.Visible = false;
                btn_TrueNumber.Visible = false;
                lbl_question.Text = "";
                startGame = false;
            }
            else
            {
                btn_Start.Text = "Give up";

                btn_Bigger.Visible = true;
                btn_Less.Visible = true;
                btn_TrueNumber.Visible = true;
                startGame = true;
            }
            if (startGame)
            {
                randomNum = rand.Next(1, 2000);
                lbl_question.Text = "Your number " + randomNum.ToString() + " ?";
            }
            
            x = 1;
            y = 2000;
        }

        private void btn_Bigger_Click(object sender, EventArgs e)
        {
            if (x!=y && x != y-1)
            {
                x = randomNum;
                randomNum = rand.Next(x, y);
                lbl_question.Text = "Your number " + randomNum.ToString() + " ?";

            }
           
        }

        private void btn_Less_Click(object sender, EventArgs e)
        {
            y = randomNum;
            randomNum = rand.Next(x, y );
            lbl_question.Text = "Your number " + randomNum.ToString() + " ?";

        }

        private void btn_TrueNumber_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nice");
            btn_Start.Text = "Start";

            btn_Bigger.Visible = false;
            btn_Less.Visible = false;
            btn_TrueNumber.Visible = false;
            lbl_question.Text = "";
            startGame = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
