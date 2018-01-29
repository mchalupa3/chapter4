using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_verification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int ageInput;

            ageInput = Convert.ToInt32(txtEnterAge.Text);

            if (ageInput <= 18)
            {
                lblResult.Text = "You are a miner";
            }
               
            if (ageInput >= 14 )
                {       
                    lblResult.Text = "You are in High School and you smell";
                }
                else 
                { 
                    lblOtherResult.Text = "you are too small to insult";
                }
            if (ageInput >= 21 && ageInput < 19)
            {
                lblResult.Text = "Congrats you no longer smell";
                if (ageInput == 21)
                {
                    lblOtherResult.Text = "You are old enough to drink but probably should not";
                }

            }
            if (ageInput > 21 && ageInput < 35)
            {
                lblResult.Text = "you are having a quater life crisis";
                if (ageInput == 30)
                {
                    lblOtherResult.Text = "HAHAHA you turned 30!";

                }
            }
            if (ageInput > 36 && ageInput < 45)
            {
                lblResult.Text = "You are getting pretty old.";

            }
            if (ageInput > 46 && ageInput < 55)
            {
                lblResult.Text = "Yep you are old now.";
            }
            if (ageInput > 56 && ageInput <=75)
            {
                lblResult.Text = "youre really old now";

            }
            if (ageInput > 75)
            {
                lblResult.Text = "congrats on making it this far";


            }
           
        }
    }
}
