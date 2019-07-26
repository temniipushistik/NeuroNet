using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuronsPet
{
    class NeuroCalc
    {
        //проперти с исходными данными
        public double Vodka { get; set; }
        public double Rain { get; set; }
        public double Friend { get; set; }

        //свойство, генерирующее плавный переход от 0 к 1 вместо больше/меньше 0,5
        public double Sygmoid { get; set; }


        //массив с весом скрытого первого нейрона
        double[] hiddenNeuron01ArrWeight = new double[3] { 0.25, 0.25, 0 };
        //массив с весом скрытого второго нейрона
        double[] hiddenNeuron02ArrWeight = new double[3] { 0.5, -0.4, 0.9 };
        //скрытый нейрон №1 для анализа исходных данных
        double[] hiddenNeuron01Arr = new double[3];
        //скрытый нейрон №2 для анализа исходных данных
        double[] hiddenNeuron02Arr = new double[3];
        //массив с исходными данными
        double[] inputNeuroArr = new double[3];

        //массив из водки, дождя и друга
        public double[] AttachArray()
        {
            inputNeuroArr[0] = Vodka;
            inputNeuroArr[1] = Rain;
            inputNeuroArr[2] = Friend;

            return inputNeuroArr;

        }

        //  любой нейрон с любым нейронов буду умножать
        public double[] CreateHiddenNeuro(double[] InputNeuro, double[] WeightNeuro)
        {
            double[] TempNeuro = new double[WeightNeuro.Length] ;

            if (InputNeuro.Length == WeightNeuro.Length) { 
            
                for (int i = 0; i < InputNeuro.Length; i++)

                {
                    TempNeuro[i] = InputNeuro[i] * WeightNeuro[i];
                }

                // MessageBox.Show(TempNeuro[0] + " " + TempNeuro[1] + " " + TempNeuro[2]);
                return TempNeuro;

            }
            else
            {
                MessageBox.Show("какой-то косяк, размеры матриц не сходятся");
                return null;
            }

        }
        
        public double NeuroAnalysis01()
        {double sumInside=0;

        hiddenNeuron01Arr =CreateHiddenNeuro(inputNeuroArr, hiddenNeuron01ArrWeight);
            for (int i = 0; i < hiddenNeuron01Arr.Length; i++)
            {
                sumInside = sumInside + hiddenNeuron01Arr[i];
            }
            // MessageBox.Show(sumInside.ToString(), "сумма первой нейронки");
            if (sumInside >= 0.5)
                return -1;
            else
                return 0;
                           
        }

        public double NeuroAnalysis02()
        {
            double sumInside = 0;

            hiddenNeuron02Arr = CreateHiddenNeuro(inputNeuroArr, hiddenNeuron02ArrWeight);
            for (int i = 0; i < hiddenNeuron02Arr.Length; i++)
            {
                sumInside = sumInside + hiddenNeuron02Arr[i];
            }
           // MessageBox.Show(sumInside.ToString(), "сумма второй нейронки");
            if (sumInside >= 0.5)
                return 1;
            else
                return 0;
            
        }

       // идти или нет на вечеринку
        public Boolean CheckedToHandOut()
        {
            if (NeuroAnalysis02() + NeuroAnalysis01() >= 0.5)
            { return true; }
            else
            { return false; }
        }

    }

}
