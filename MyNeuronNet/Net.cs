using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNeuronNet
{
    class Net
    {
        public Layer[] layers;

        public Net(int countLayers, int[] countNeuronsInEachLayer)
        {
            layers = new Layer[countLayers];

            layers[0] = new Layer(countNeuronsInEachLayer[0], 0);   // первый слой
            for (int i = 1; i < countLayers; i++)                   // последующие слои
            {
                layers[i] = new Layer(countNeuronsInEachLayer[i], countNeuronsInEachLayer[i - 1]);
            }
        }


        public double[] Calculate(double[] input)
        {
            for (int i = 0; i < layers[0].neurons.Length; i++)          // настройка входа сети
            {
                layers[0].neurons[i].localField = input[i];
                layers[0].neurons[i].outValue = layers[0].ActivationFunction(layers[0].neurons[i].localField);
            }
            for (int i = 1; i < layers.Length; i++)     // прямой проход и расчет всех выходов
            {
                layers[i].ForwardPass(layers[i - 1]);
            }

            var neurons = layers[layers.Length - 1].neurons;
            double[] res = new double[neurons.Length];
            for(int i=0;i<neurons.Length;i++)
            {
                res[i] = neurons[i].outValue;
            }
            return res;

        }
        public void Learning(double[] desiredInput, double[] desiredOutput, int epochs)
        {
            while (epochs > 0)
            {
                Calculate(desiredInput);

                for (int i = 0; i < layers[layers.Length - 1].neurons.Length; i++)
                {
                    // вычисление локального градиента нейронов в последнем слое
                    var n = layers[layers.Length - 1].neurons[i];
                    n.localGrad =
                        (desiredOutput[i] - n.outValue) * // ошибка = желаемый - реальный отклик
                        layers[layers.Length - 1].DerivativeActivationFunction(n.outValue);
                    // производная функции активации от локального поля

                    //Layer.limit_val(ref layers[layers.Length - 1].neurons[i].localGrad, Layer.maxgrad);

                    //if(Math.Abs(layers[layers.Length - 1].neurons[i].localGrad)>1000)
                    //{
                    //    int x = 111111;
                    //}
                }

                for (int i = layers.Length - 1; i > 0; i--)     // обратный проход, коррекция весов
                {
                    layers[i].BackwardPass(layers[i - 1]);
                }

                epochs--;
            }
        }
    }
}