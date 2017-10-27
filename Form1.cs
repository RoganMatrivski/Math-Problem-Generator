using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using org.mariuszgromada.math.mxparser;


namespace Math_Problem_Generator_C_Sharp
{
    public partial class quizForm : Form
    {
        public quizForm()
        {
            InitializeComponent();
            iterationValue.Maximum = int.MaxValue / 4; //Capped the iterationValue at the 1/4th of the integer Maximum Value. 
        }

        //MathFunctions.MathParser mp = new MathFunctions.MathParser(); //NgeInitialize Math Parser

        StringBuilder sb = new StringBuilder(); // Ngeitialize StringBuilder buat naruh string Question ama Result

        private void genButton_Click(object sender, EventArgs e)
        {
            Random num1Gen = new Random();
            Random num2Gen = new Random();
            int num1Min;
            int num1Max;
            Random randOperator = new Random();


            if (string.IsNullOrWhiteSpace(firstNum1.Text)) //Ngecek jika kolom yang akan digunakan kosong atau hanya berupa spasi.
            {
                num1Min = 1;
            }
            else
            {
                num1Min = int.Parse(firstNum1.Text);
            }

            if (string.IsNullOrWhiteSpace(firstNum2.Text))//Ngecek jika kolom yang akan digunakan kosong atau hanya berupa spasi.
            {
                num1Max = 100;
            }
            else
            {
                num1Max = int.Parse(firstNum2.Text) + 1;
            }

            if (reverseCheck(num1Min, num1Max)) //Ngecek jika angka minimum ama maximum ketuker atau enggak.
            {
                int decNum = 0;
                if (!noDecimalCheckbox.Checked)
                {
                    decNum = Convert.ToInt32(decimalNumbers.Value);
                }
                else
                {
                    decNum = 0;
                }

                int numOfDec = 0;
                if (noDecimalCheckbox.Checked != true) 
                {
                    numOfDec = Convert.ToInt32(decimalNumbers.Value);
                }

                string questionRes, resNum;

                Generator.QuestionGen(num1Min, num1Max, (Convert.ToInt32(iterationValue.Text)), numOfDec, out questionRes, out resNum);

                questionProblem.Text = questionRes;
                resultNum.Text = resNum;
                
                /*

                //Problem Generator

                int retryCount = 0; //Ngitung berapa kali ngeGenerate ulang
                bool decimals = true;
                var stopWatch = System.Diagnostics.Stopwatch.StartNew(); //Ngeinitialize sekaligus mulai ngitung waktu sampai fungsi Stopwatch dihentikan.
                while (decimals == true) //Ngecek jika Decimal bernilai True atau engga. Jika benar, jalankan kode ini secara berulang-ulang sampai Decimal bernilai selain True.
                {
                    Random questionTypeGen = new Random();
                    Double result;
                    string questionRandResult = questionGenerator(Convert.ToInt32(iterationValue.Text) - 1, num1Min, num1Max); //Manggil Method questionGenerator sambil masukin iterationValue ama range angka random.
                    string questionString = questionRandResult.Replace("*", " X "); //Ngeganti string yang bisa dibaca komputer ke tulisan yang bisa dibaca manusia.
                    questionString = questionString.Replace("+", " + "); //Ngeganti string yang bisa dibaca komputer ke tulisan yang bisa dibaca manusia.
                    questionString = questionString.Replace("-", " - "); //Ngeganti string yang bisa dibaca komputer ke tulisan yang bisa dibaca manusia.
                    questionString = questionString.Replace("/", " : "); //Ngeganti string yang bisa dibaca komputer ke tulisan yang bisa dibaca manusia.
                    Expression ex = new Expression(questionRandResult);
                    result = ex.calculate(); //Ngekalkulasi questionRandResult dengan MathFunction.MathParser.Calculate.
                    Debug.WriteLine("This Value {0} is the result. This value {1} is the epsilon. This Boolean {2} should have turned on.", result, double.Epsilon, Math.Abs(result % 1) < Double.Epsilon);

                    if (Math.Abs(result % 1) < Double.Epsilon) //Ngecek jika result merupakan angka dengan desimal
                    {
                        stopWatch.Stop(); //hentikan menghitung waktu kalkulasi
                        var elapsedTime = stopWatch.ElapsedMilliseconds; //memasukan waktu kalkulasi ke variabel.
                        Debug.WriteLine("the number " + result.ToString() + " is not decimal");
                        decimals = false;
                        logAdd("Succeeded generating a random problem in " + elapsedTime + " millisecond, with each value between " + firstNum1.Text + " to " + firstNum2.Text + ", with an iteration number of " + iterationValue.Text + ", regenerated " + retryCount + " times in attempt to search for the non-decimal result.");
                        questionProblem.Text = questionString;
                        resultNum.Text = result.ToString();
                    }
                    else
                    {
                        if (noDecimalCheckbox.Checked == false)
                        {
                            stopWatch.Stop(); //hentikan menghitung waktu kalkulasi
                            var elapsedTime = stopWatch.ElapsedMilliseconds; //memasukan waktu kalkulasi ke variabel.
                            logAdd("Succeeded generating a random problem in " + elapsedTime + " millisecond, with each value between " + firstNum1.Text + " to " + firstNum2.Text + ", with an iteration number of " + iterationValue.Text + ", regenerated " + retryCount + " times in attempt to search for the non-decimal result.");
                            Debug.WriteLine("the number " + result.ToString() + " is decimal");
                            decimals = false;
                            double resultNew = Math.Round(result, Convert.ToInt32(decimalNumbers.Text), MidpointRounding.AwayFromZero); //Jika noDecimalCheckbox tidak dicentang, maka hasil penghitungan tidak dicek dan langsung ditampilkan.
                            questionProblem.Text = questionString;
                            resultNum.Text = resultNew.ToString();
                        }
                        else
                        {
                            Debug.WriteLine("the number " + result.ToString() + " is decimal");
                            decimals = true; //mengulang kalkulasi sambil menambahkan retryCount dengan 1
                            retryCount++;
                        }
                    }
                }
                 */
            }
            else
            {
                MessageBox.Show("The minimum value should not exceed the maximum value. Please recheck your input.", "Error", MessageBoxButtons.OK); //Jika 
            }

        }

        public bool reverseCheck(int input1, int input2) //method untuk mengecek jika angka input1 dan input2 terbalik atau tidak.
        {
            return input1 - input2 < 0;
        }

        Random numGen = new Random();

        public string questionGenerator(int numIteration, int num1, int num2) //fungsi untuk mengenerate pertanyaan.
        {
            string problem = "";
            problem = numGen.Next(num1, num2).ToString();

            for (int i = 0; i < numIteration; i++)
            {
                problem = problem + operatorPick(numGen.Next(0, 100)) + numGen.Next(num1, num2).ToString();
            }

            Debug.WriteLine(problem);
            return problem;
        }

        public static string operatorPick(int input1) //memberikan string operator sesuai dengan input1.
        {
            string operatorSymbol = "";
            if (input1 >= 0 && input1 <= 25)
            {
                operatorSymbol = "+";
            }

            if (input1 > 25 && input1 <= 50)
            {
                operatorSymbol = "-";
            }

            if (input1 > 50 && input1 <= 75)
            {
                operatorSymbol = "/";
            }

            if (input1 > 75 && input1 <= 100)
            {
                operatorSymbol = "*";
            }
            return operatorSymbol;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This controls how long and how much the operators is. For example, If you set the iteration to 2, it will add two number with a one operator. You can insert the value as much as you can. " + Environment.NewLine + "Please be aware that if you check the 'No-Decimal numbers' checkbox, the higher the iteration is, the more it can give you unwanted result." + Environment.NewLine + Environment.NewLine + "Just for reminder that the higher the iteration value, the slower the process." + Environment.NewLine + "But please note that iteration of 1 will just generate a random number. Because, why not?", "What's this?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void noDecimalCheckbox_CheckedChanged(object sender, EventArgs e) //method untuk mengecek jika noDecimalCheckbox tercentang.
        {
            if (noDecimalCheckbox.Checked == true)
            {
                decimalNumberLabel.Enabled = false;
                decimalNumbers.Enabled = false;
            }
            else
            {
                decimalNumberLabel.Enabled = true;
                decimalNumbers.Enabled = true;
            }
        }

        private void quizForm_Load(object sender, EventArgs e)
        {
            firstNum2.Maximum = int.MaxValue;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("=====================================");
            stringBuilder.Append(Environment.NewLine + "Math Problem Generator has started.");
            stringBuilder.Append(Environment.NewLine + "=====================================");
            logBox.Text = stringBuilder.ToString();
        }

        private void logAdd(string input)
        {
            sb.Append("=====================================" + Environment.NewLine + Environment.NewLine);
            sb.Append(input + Environment.NewLine + Environment.NewLine);
            logBox.Text = sb.ToString();
            logBox.SelectionStart = logBox.Text.Length;
            logBox.ScrollToCaret();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1Min;
            int num1Max;

            if (string.IsNullOrWhiteSpace(firstNum1.Text))
            {
                num1Min = 1;
            }
            else
            {
                num1Min = int.Parse(firstNum1.Text);
            }

            if (string.IsNullOrWhiteSpace(firstNum2.Text))
            {
                num1Max = 100;
            }
            else
            {
                num1Max = int.Parse(firstNum2.Text);
            }

            if (reverseCheck(num1Min, num1Max))
            {
                BatchGenerateForm batchForm = new BatchGenerateForm();
                batchForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("The minimum value should not exceed the maximum value. Please recheck your input.", "Error", MessageBoxButtons.OK);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            aboutForm aboutForm = new aboutForm();
            aboutForm.ShowDialog();
        }
    }
}

