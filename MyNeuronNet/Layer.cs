using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNeuronNet
{
    class Neuron
    {
        public double localGrad;   // delta, локальный градиент
        public double outValue;    // y
        public double localField;  // локальное поле
    }

    class Weight
    {
        public double correction;  // deltaW
        public double value;       // W
    }    

    class Layer
    {
        int neuronsCount;           // количество нейронов в слое
        public Weight[][] weights;  // первая цифра - номер нейрона, вторая - номер веса
        public Neuron[] neurons;
        Random rnd = new Random();
        double speed = 0.5;       // скорость обучения
        double mean=0;

        public Layer(int countNeuronsInLayer, int countNeuronsInPreviousLayer)
        {
            neuronsCount = countNeuronsInLayer;
            neurons = new Neuron[neuronsCount];

            mean = 1d / Math.Sqrt(countNeuronsInPreviousLayer);     // граничное значение веса

            weights = new Weight[countNeuronsInLayer][];        // создаем веса для каждого нейрона
            for (int i = 0; i < countNeuronsInLayer; i++)
            {
                neurons[i] = new Neuron();
                neurons[i].localGrad = 0;
                neurons[i].localField = 0;
                neurons[i].outValue = 0;

                weights[i] = new Weight[countNeuronsInPreviousLayer];
                
                for (int j = 0; j < weights[i].Length; j++)     // заполним веса случайными числами
                {
                    weights[i][j] = new Weight();
                    weights[i][j].value = rnd.NextDouble() * 2d * mean - mean;
                    weights[i][j].correction = 0;
                }
            }
        }


        public static double maxgrad = 1;
        public static void limit_val(ref double val, double A)
        {
            if (val < -A) val = -A;
            if (val > A) val = A;
        }


        public void ForwardPass(Layer previousLayer)        // метод формирует на выходе каждого нейрона в слое значение
        {
            for (int i = 0; i < neuronsCount; i++)
            {
                double inducedLocalField = 1;       // порог

                for (int j = 0; j < weights[i].Length; j++)
                {
                    inducedLocalField += weights[i][j].value * previousLayer.neurons[j].outValue;
                }

                //if (double.IsNaN(inducedLocalField))
                //{
                //    int x = 888;
                //}

                neurons[i].outValue = ActivationFunction(inducedLocalField);
                neurons[i].localField = inducedLocalField;
            }
        }

        public void BackwardPass(Layer previousLayer)
        {
            for (int i = 0; i < neuronsCount; i++)      // расчет коррекции весов текущего слоя
            {
                for (int j = 0; j < previousLayer.neuronsCount; j++)
                {
                    weights[i][j].correction = speed * neurons[i].localGrad * previousLayer.neurons[j].outValue;
                    // коррекция = скорость обучения * локальный градиент * выход нейрона предыдущего слоя

                    Layer.limit_val(ref weights[i][j].correction, mean / 10);

                    weights[i][j].value += weights[i][j].correction;

                    //if(Math.Abs(weights[i][j].value)>1000)
                    //{
                    //    int x = 999;
                    //}
                }
            }
            
            for (int i = 0; i < previousLayer.neuronsCount; i++)        // расчет локального градиента нейронов предыдущего слоя
            {
                previousLayer.neurons[i].localGrad = 0;

                for (int j = 0; j < neuronsCount; j++)
                {
                    previousLayer.neurons[i].localGrad += neurons[j].localGrad * weights[j][i].value;
                }

                //limit_val(ref previousLayer.neurons[i].localGrad, maxgrad);

                //if (previousLayer.neurons[i].localGrad>1000)
                //{
                //    int x = 777;
                //}
                previousLayer.neurons[i].localGrad *= DerivativeActivationFunction(previousLayer.neurons[i].outValue);

                //if (previousLayer.neurons[i].localGrad > 1000)
                //{
                //    int x = 778;
                //}
            }            
        }

        public double ActivationFunction(double x)
        {
            //return (1 / (1 + Math.Exp(-x))); 

            //return ((Math.Exp(2 * x) - 1) / (Math.Exp(2 * x) + 1));

            return 2d / (1d + Math.Exp(-2d * x)) - 1d;
        }

        public double DerivativeActivationFunction(double x)
        {
            //return (Math.Exp(-x) / Math.Pow((Math.Exp(-x) + 1), 2)); 

            //return ((4 * Math.Exp(2 * x)) / Math.Pow((Math.Exp(2 * x) + 1), 2));

            //var res = 0.5 * (y + 1) * (1 - y);
            //return res;

            double e2 = Math.Exp(2d * x);
            return 4d * e2 / Math.Pow((e2 + 1d), 2);
        }
    }
}