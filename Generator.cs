/*
 * Copyright (c) 2017 Rogan Matrivski Lartengalf.
 *
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System;
using System.Diagnostics;
using org.mariuszgromada.math.mxparser;
using System.Text;

public class Generator
{
    public Generator()
    {

    }

    private static void logAdd(string input)
    {
        StringBuilder sb = new StringBuilder(); // Ngeitialize StringBuilder buat naruh string Question ama Result
        sb.Append("=====================================" + Environment.NewLine + Environment.NewLine);
        sb.Append(input + Environment.NewLine + Environment.NewLine);
        Console.WriteLine(sb.ToString());
    }

    

    

    Random num1Gen = new Random();
    Random num2Gen = new Random();
    Random randOperator = new Random();

    //Generator questionGenerator = new questionGenerator();
    public static void QuestionGen(int firstNum1, int firstNum2, int iterationValue, int decimalNumbers, out string resultQuestion, out string resultAnswer)
    {
        resultQuestion = "";
        resultAnswer = "";
        int retryCount = 0; //Ngitung berapa kali ngeGenerate ulang
        bool decimals = true;
        var stopWatch = System.Diagnostics.Stopwatch.StartNew(); //Ngeinitialize sekaligus mulai ngitung waktu sampai fungsi Stopwatch dihentikan.
        while (decimals == true) //Ngecek jika Decimal bernilai True atau engga. Jika benar, jalankan kode ini secara berulang-ulang sampai Decimal bernilai selain True.
        {
            Random questionTypeGen = new Random();
            double result;
            string questionRandResult = questionGenerator(Convert.ToInt32(iterationValue) - 1, firstNum1, firstNum2); //Manggil Method questionGenerator sambil masukin iterationValue ama range angka random.
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
                Console.WriteLine("the number " + result.ToString() + " is not decimal");
                decimals = false;
                //logAdd("Succeeded generating a random problem in " + elapsedTime + " millisecond, with each value between " + firstNum1 + " to " + firstNum2 + ", with an iteration number of " + iterationValue + ", regenerated " + retryCount + " times in attempt to search for the non-decimal result.");
                //TODO : Ganti buat return ke function.

                //questionProblem = questionString;
                //resultNum = resultNew.ToString();


                //return questionString + " = " + result.ToString();

                resultQuestion = questionString;
                resultAnswer = result.ToString();
            }
            else
            {
                //if (noDecimalCheckbox.Checked == false) //TODO : Ganti buat ngecek kalo decimalNumbers ada ato engga.
                if (decimalNumbers >= 1)
                {
                    stopWatch.Stop(); //hentikan menghitung waktu kalkulasi
                    var elapsedTime = stopWatch.ElapsedMilliseconds; //memasukan waktu kalkulasi ke variabel.
                    logAdd("Succeeded generating a random problem in " + elapsedTime + " millisecond, with each value between " + firstNum1 + " to " + firstNum2 + ", with an iteration number of " + iterationValue + ", regenerated " + retryCount + " times in attempt to search for the non-decimal result.");
                    //Console.WriteLine("the number " + result.ToString() + " is decimal");
                    decimals = false;
                    double resultNew = Math.Round(result, Convert.ToInt32(decimalNumbers), MidpointRounding.AwayFromZero); //Jika noDecimalCheckbox tidak dicentang, maka hasil penghitungan tidak dicek dan langsung ditampilkan.

                    //TODO : Ganti buat return ke function.

                    //questionProblem = questionString;
                    //resultNum = resultNew.ToString();

                    //return questionString + " = " + resultNew.ToString();

                    resultQuestion = questionString;
                    resultAnswer = result.ToString();

                }
                else
                {
                    Console.WriteLine("the number " + result.ToString() + " is decimal");
                    decimals = true; //mengulang kalkulasi sambil menambahkan retryCount dengan 1
                    retryCount++;

                }
            }
        }
    }

    public bool reverseCheck(int input1, int input2) //method untuk mengecek jika angka input1 dan input2 terbalik atau tidak.
    {
        return input1 - input2 < 0;
    }

    
    
    public static string questionGenerator(int numIteration, int num1, int num2) //fungsi untuk mengenerate pertanyaan.
    {
        Random numGen = new Random();
        string problem = "";
        problem = numGen.Next(num1, num2).ToString();

        for (int i = 0; i < numIteration; i++)
        {
            problem = problem + operatorPick(numGen.Next(0, 100)) + numGen.Next(num1, num2).ToString();
        }
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

    public static bool decimalChecker(double Input)
    {
        return (Input % 1) == 0;
    }
}
