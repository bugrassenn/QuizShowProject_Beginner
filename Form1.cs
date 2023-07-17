using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizShowProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int questionNumber, questionTrue, questionFalse = 0;
        private void BtnNext_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnNext.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            questionNumber++;
            LblQuestion.Text = questionNumber.ToString();

            if (questionNumber == 1)
            {
                richTextBox1.Text = " Where is the capital of Turkey? ";
                BtnA.Text = "Istanbul";
                BtnB.Text = "Samsun";
                BtnC.Text = "Ankara";
                BtnD.Text = "Konya";
                LblQuestionTrue.Text = "Ankara";
            }
            if (questionNumber == 2)
            {
                richTextBox1.Text = "How many oceans are there in the world?";
                BtnA.Text = "7";
                BtnB.Text = "5";
                BtnC.Text = "4";
                BtnD.Text = "8";
                LblQuestionTrue.Text = "5";

            }
            if (questionNumber == 3)
            {
                richTextBox1.Text = "What is the currency of turkey";
                BtnA.Text = "₺";
                BtnB.Text = "€";
                BtnC.Text = "$";
                BtnD.Text = "£";
                LblQuestionTrue.Text = "₺";
                BtnNext.Text = "Results";

            }
            if (questionNumber == 4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnNext.Enabled = false;
                MessageBox.Show("True: " + questionTrue + "\n" + "False: " + questionFalse);
            }
        }
        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnNext.Enabled = true;


            LblVote.Text = BtnA.Text;

            if (LblQuestionTrue.Text == LblVote.Text)
            {
                questionTrue++;
                LblTrue.Text = questionTrue.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                questionFalse++;
                LblFalse.Text = questionFalse.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnNext.Enabled = true;

            LblVote.Text = BtnB.Text;

            if (LblQuestionTrue.Text == LblVote.Text)
            {
                questionTrue++;
                LblTrue.Text = questionTrue.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                questionFalse++;
                LblFalse.Text = questionFalse.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnNext.Enabled = true;


            LblVote.Text = BtnC.Text;

            if (LblQuestionTrue.Text == LblVote.Text)
            {
                questionTrue++;
                LblTrue.Text = questionTrue.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                questionFalse++;
                LblFalse.Text = questionFalse.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnNext.Enabled = true;


            LblVote.Text = BtnD.Text;

            if (LblQuestionTrue.Text == LblVote.Text)
            {
                questionTrue++;
                LblTrue.Text = questionTrue.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                questionFalse++;
                LblFalse.Text = questionFalse.ToString();
                pictureBox2.Visible = true;
            }
        }

      

        
    }
}
