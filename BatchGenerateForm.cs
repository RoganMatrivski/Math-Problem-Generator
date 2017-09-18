using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using org.mariuszgromada.math.mxparser;

namespace Math_Problem_Generator_C_Sharp
{
    public partial class BatchGenerateForm : Form
    {
        public BatchGenerateForm()
        {
            InitializeComponent();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            progressBar.Value = 0;
        }

        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["quizForm"];
        //MathFunctions.MathParser mp = new MathFunctions.MathParser();

        int retryCount = 0;
        bool decimals = true;
        System.Windows.Forms.Form batchForm = System.Windows.Forms.Application.OpenForms["BatchGenerateForm"]; 
        Random num1Gen = new Random();
        Random num2Gen = new Random();
        Random randOperator = new Random();
        string questionString = "";
        Double result = 0;
        StringBuilder sb = new StringBuilder();
        int elapsedTime;

        bool switchToCancel = false;

        private void generateButton_Click(object sender, EventArgs e)
        {
            //Problem Generator

            if (string.IsNullOrWhiteSpace(browseLocation.Text))
            {
                MessageBox.Show("Please specify the save location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!switchToCancel)
                {
                    //ini sebelumnya kode buat ngitung
                    progressBar.Maximum = Convert.ToInt32(questionNumber.Value);
                    backgroundWorker1.RunWorkerAsync();
                    generateButton.Text = "Cancel";
                    switchToCancel = true;
                }
                else
                {
                    if (backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.CancelAsync();
                        Debug.WriteLine("Tried to cancel Process");
                    }
                    generateButton.Text = "Generate";
                }
            }
        }

        public bool decimalCheck(int input)
        {
            return Math.Abs(input % 1) < double.Epsilon;
        }

        Random numGen = new Random();

        public string questionGenerator(int numIteration, int num1, int num2)
        {
            string problem = "";
            problem = numGen.Next(num1, num2).ToString();

            for (int i = 0; i < numIteration; i++)
            {
                problem = problem + operatorPick(numGen.Next(0, 100)) + numGen.Next(num1, num2).ToString();
            }
            return problem;
        }

        public static string operatorPick(int input1)
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


        public bool styleMethod()
        {
            bool methodUsed = true;

            if (formattingOption1.Checked == true)
            {
                methodUsed = false;
            }

            if (formattingOption2.Checked == true)
            {
                methodUsed = true;
            }

            return methodUsed;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            saveLocation.ShowDialog();
            browseLocation.Text = saveLocation.FileName;
        }

        private void BatchGenerateForm_Load(object sender, EventArgs e)
        {
            browseLocation.Text = Application.StartupPath + @"\GeneratedQuestions.txt";
        }

        bool workIsCompleted = false;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var stopWatch = System.Diagnostics.Stopwatch.StartNew();
            int questionNum = Convert.ToInt32(questionNumber.Value);
            if (backgroundWorker1.CancellationPending)
            {
                e.Cancel = true;
                backgroundWorker1.ReportProgress(0);
                return;
            }
            else
            {
                while (!backgroundWorker1.CancellationPending && !workIsCompleted)
                {
                    Debug.WriteLine("Checking if backgroundWorker Cancelled");

                    for (int i = 0; i <= questionNumber.Value; i++)
                    {
                        Debug.WriteLine("This Line has been executed on For Loop.");
                        decimals = true;

                        while (decimals == true)
                        {
                            Random questionTypeGen = new Random();
                            string questionRandResult = questionGenerator(Convert.ToInt32(((quizForm)f).iterationValue.Text) - 1, Convert.ToInt32(((quizForm)f).firstNum1.Value), Convert.ToInt32(((quizForm)f).firstNum2.Value));
                            if (formattingOption1.Checked == true)
                            {
                                questionString = questionRandResult;
                            }
                            else
                            {
                                questionString = questionRandResult.Replace("*", " X ");
                                questionString = questionString.Replace("+", " + ");
                                questionString = questionString.Replace("-", " - ");
                                questionString = questionString.Replace("/", " : ");
                            }
                            Expression ex = new Expression(questionRandResult);
                            result = ex.calculate();
                            Debug.WriteLine("This Line executed after computing");
                            if (Math.Abs(result % 1) < Double.Epsilon)
                            {

                                decimals = false;
                                sb.Append(questionString + " = " + result.ToString() + Environment.NewLine);
                                Debug.WriteLine(sb.ToString());
                            }
                            else
                            {
                                if (((quizForm)f).noDecimalCheckbox.Checked == false)
                                {
                                    decimals = false;
                                    double resultNew = Math.Round(result, Convert.ToInt32(((quizForm)f).decimalNumbers.Text), MidpointRounding.AwayFromZero);
                                    sb.Append(questionString + " = " + resultNew.ToString() + Environment.NewLine);
                                }
                                else
                                {
                                    decimals = true;
                                    retryCount++;
                                }
                            }
                        }

                        if (backgroundWorker1.CancellationPending)
                        {
                            backgroundWorker1.ReportProgress(0);
                            
                            break;
                        }

                        if (i == questionNum)
                        {
                            Debug.WriteLine("Completed!");
                            workIsCompleted = true;
                        }
                        backgroundWorker1.ReportProgress(i);
                    }
                }
            }
            stopWatch.Stop();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                statusLabel2.Text = "Process was cancelled";
                generateButton.Enabled = false;
            }
            else if (e.Error != null)
            {
                statusLabel2.Text = "Error completing process.";
            }
            else
            {
                try
                {
                    File.WriteAllText(browseLocation.Text, sb.ToString() + Environment.NewLine);
                }

                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("Cannot write file to this location. It probably caused by the location that may not exist or protected. Please pick another location.", "Error Writing File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Cannot write file to this location. It probably caused by the location that may not exist or protected. Please pick another location.", "Error Writing File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                generateButton.Text = "Generate";
                generateButton.Enabled = false;

                

                MessageBox.Show("Succeeded generating " + questionNumber.Value + " random problems, with each value between " + ((quizForm)f).firstNum1.Text + " to " + ((quizForm)f).firstNum2.Text + ", with an iteration number of " + ((quizForm)f).iterationValue.Text + ", and saved to " + browseLocation.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StringBuilder sb2 = new StringBuilder();
                sb2.Append("=====================================" + Environment.NewLine + Environment.NewLine);
                sb2.Append("Succeeded generating " + questionNumber.Value + " random problems, with each value between " + ((quizForm)f).firstNum1.Text + " to " + ((quizForm)f).firstNum2.Text + ", with an iteration number of " + ((quizForm)f).iterationValue.Text + ", and saved to " + browseLocation.Text + Environment.NewLine + Environment.NewLine);
                ((quizForm)f).logBox.Text = sb2.ToString();
                ((quizForm)f).logBox.SelectionStart = ((quizForm)f).logBox.Text.Length;
                ((quizForm)f).logBox.ScrollToCaret();
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            statusLabel2.Text = "Completed generating " + e.ProgressPercentage + " out of " + questionNumber.Value + ".";
        }

        private void BatchGenerateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                Debug.WriteLine("Tried to cancel Process");
            }
        }
    }
}
