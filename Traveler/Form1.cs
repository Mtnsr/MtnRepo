using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traveler.Models;

namespace Traveler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void rightCoorTxtBox_Leave(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;
            if (text == "")
                return;

            if (text.Length != 3)
                Error(rightCoorTxtBox, Statics.rightCoorErrorTxt);
            else
            {
                foreach (var ch in text)
                {
                    int index = text.IndexOf(ch);
                    if (index == 0 || index == 2)
                    {
                        if (!Statics.numbers.Contains(ch))
                        {
                            Error(rightCoorTxtBox, Statics.rightCoorErrorTxt);
                            return;
                        }
                    }
                    else
                    {
                        if (ch != ',')
                        {
                            Error(rightCoorTxtBox, Statics.rightCoorErrorTxt);
                            return;
                        }
                    }
                }
            }
        }
        private void robotCoorTxtBox_Leave(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;
            if (text == "")
                return;

            if (text.Length != 5)
                Error(robotCoorTxtBox, Statics.robotCoorErrorText);
            else
            {
                foreach (var ch in text)
                {
                    int index = text.IndexOf(ch);

                    if (index == 0 || index == 2)
                    {
                        if (!Statics.numbers.Contains(ch))
                        {
                            Error(robotCoorTxtBox, Statics.robotCoorErrorText);
                            return;
                        }
                    }
                    else if (index == 1)
                    {
                        if (ch != ',')
                        {
                            Error(robotCoorTxtBox, Statics.robotCoorErrorText);
                            return;
                        }
                    }
                    else if (index == 3)
                    {
                        if (ch != ' ')
                        {
                            Error(robotCoorTxtBox, Statics.robotCoorErrorText);
                            return;
                        }
                    }
                    else
                    {
                        if (!Statics.directions.Contains(ch))
                        {
                            Error(robotCoorTxtBox, Statics.robotCoorErrorText);
                            return;
                        }
                    }
                }
            }
        }
        private void commandTxtBox_Leave(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;

            bool notMatched = text.ToString().Any(b => !Statics.commands.Contains(b));
            if (notMatched)
                Error(commandTxtBox, Statics.commandErrorText);
        }
        private void Error(TextBox txtBox, string errorMessage)
        {
            MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            txtBox.Text = "";
            txtBox.Focus();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rightCoorTxtBox.Text == "" || robotCoorTxtBox.Text == "" || commandTxtBox.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
                return;
            }

            Robot customRobot = new Robot(Statics. leftCoor, rightCoorTxtBox.Text, robotCoorTxtBox.Text, commandTxtBox.Text);
            MessageBox.Show("Robotunuzun şu anki konumu  " + customRobot.currentCoor);
        }

      
    }


}
