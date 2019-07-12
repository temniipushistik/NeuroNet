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

       
        


        //массив из водки, дождя и друга
        public void CreateArray()
        {
            double[] inputNeuroArray = new double[3] { Vodka, Rain, Friend };

            //массив с весом скрытого первого нейрона
            double[] hiddenNeuron01ArrayWeight = new double[] { 0.25, 0.25, 0 };
            //массив с весом скрытого второго нейрона
            double[] hiddenNeuron02ArrayWeight = new double[3] { 0.5, -0.4, 0.9 };
            double[] hiddenNeuron01Array = new double[3];
            double[] hiddenNeuron02Array = new double[3];
            //массив с исходными данными


            if (inputNeuroArray.Length == hiddenNeuron01ArrayWeight.Length && inputNeuroArray.Length == hiddenNeuron02ArrayWeight.Length && hiddenNeuron01Array.Length == hiddenNeuron02Array.Length)
            {

                for (int i = 0; i < inputNeuroArray.Length; i++)

                {

                    hiddenNeuron01Array[i] = inputNeuroArray[i] * hiddenNeuron01ArrayWeight[i];

                }

               MessageBox.Show(hiddenNeuron01Array[0]+" "+ hiddenNeuron01Array[1] + " " + hiddenNeuron01Array[2]);

            }
            else
            {
                MessageBox.Show("какой-то косяк, размеры матриц не сходятся");
            }




        }

        public Boolean CheckedToHandOut(double x)
        {
            if (x>=0.5)
            { return true; }
            else
            { return false; }
        }


    }



}
