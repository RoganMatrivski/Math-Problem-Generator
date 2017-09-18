using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Math_Problem_Generator_C_Sharp
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["quizForm"];

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutForm_Load(object sender, EventArgs e)
        {
            int minValue = Convert.ToInt32(((quizForm)f).firstNum1.Value) - 1;
            int maxValue = Convert.ToInt32(((quizForm)f).firstNum2.Value);
            var iteration = ((quizForm)f).iterationValue.Value;
            var newLine = Environment.NewLine;
            int combinationTotal;

            combinationTotal = (maxValue - minValue);
            Debug.WriteLine(combinationTotal);
            string combinationTotalStr = "";

            for (int i = 0; i < iteration-1; i++)
            {
                Debug.WriteLine("Sucessfully run on For");
                combinationTotal = combinationTotal * 4;
                Debug.WriteLine(combinationTotal);
                combinationTotal = combinationTotal * (maxValue - minValue);
                Debug.WriteLine(combinationTotal);
                if (combinationTotal > 1000000000)
                {
                    combinationTotalStr = "over 1 million";
                    break;
                }
            }

            if (combinationTotal < 1000000000)
            {
                combinationTotalStr = combinationTotal.ToString() + " (This value changes according to your settings)";
            }

            richTextBox1.Text = "Math Problem Generator v. 1.0" + newLine + newLine + "This program basically generates sets of numbers and operators question with each question is unique up to " + combinationTotalStr + " questions." + newLine + "It means that this program have a chance to generate a same question 1 out of " + combinationTotalStr + "." + newLine + "Supports custom iteration, decimal and negative result, and batch generate to file." + newLine + newLine + "To be honest you can generate a lot of question in the Batch Generate. So big, the limits of generating questions is the maximum positive integer number, which is 2,147,483,647. But don't try it tho. Unless you have a beefy comp with a lot of time, or you are simply just a NASA." + newLine + newLine + @"Currently still using Math Parser .NET from icemanind in Codeproject.
www.codeproject.com/Articles/274093/Math-Parser-NET" + newLine + newLine + "Made by Rogan in C# language.";

        }
    }
}