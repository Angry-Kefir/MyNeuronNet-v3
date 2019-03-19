using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MyNeuronNet
{
    public partial class Form1 : Form
    {
        int pressCounter = 0;
        int trueCounter = 0;
        double[] mass = new double[625];
        Net net;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string arr_to_str(double[] arr)
        {
            var res = ""; for (int i = 0; i < arr.Length; i++) res += arr[i].ToString("F2") + ", "; return res;
        }

        private void identifyClick(object sender, EventArgs e)
        {
            int[] trueCounterMass = new int[3] { 0, 0, 0 };

            for (int j = 0; j < 3; j++)
            {
                for (int n = 0; n < numToIdentify.Value; n++)
                {
                    ImageToMass(@catalogPath.Text, n, j);
                    var result = net.Calculate(mass);
                    double max = 100500; int typeOfMax = 100500;

                    if (result[0] > result[1] && result[0] > result[2]) { max = result[0]; typeOfMax = 0; }
                    else if (result[1] > result[0] && result[1] > result[2]) { max = result[1]; typeOfMax = 1; }
                    else if (result[2] > result[0] && result[2] > result[1]) { max = result[2]; typeOfMax = 2; }

                    identifyResult.Text += string.Format("result = {0}; type = {1}; real type = {2}\r\n", arr_to_str(result), typeOfMax, j);

                    pressCounter++;
                    if (j == typeOfMax)
                    {
                        trueCounter++;
                        trueCounterMass[j]++;
                    }
                }

                trueIdentify.Text = "Верных  " + trueCounter.ToString();
                totalIdentify.Text = "из  " + pressCounter.ToString();

                identifyResult.Text += string.Format("   TRUE = {0}\r\n", trueCounterMass[j]);
            }
        }

        private void saveWeightsClick(object sender, EventArgs e)
        {
            string path = "D:\\YandexDisk\\Программирование\\MyNeuronNet v3\\MyNeuronNet v3\\" + trueCounter.ToString() + ".txt";
            StreamWriter sw = new StreamWriter(path, false);

            for (int i = 1; i < net.layers.Length; i++)
            {
                for (int j = 0; j < net.layers[i].weights.Length; j++)
                {
                    string[] line = new string[net.layers[i].weights[j].Length];

                    for (int k = 0; k < net.layers[i].weights[j].Length; k++)
                    {
                        line[k] = net.layers[i].weights[j][k].value.ToString("F3");
                    }
                    sw.WriteLine(String.Join(" ", line));
                }
            }
            sw.Close();
        }

        private void chooseCatalog_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                catalogPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void learnButton_Click(object sender, EventArgs e)
        {
            string[] arrstring = null;
            if (neuronsInNet.Text != "")
            {
                arrstring = neuronsInNet.Text.Split(' ');
            }

            int[] countNeurons = new int[arrstring.Length];
            for (int i = 0; i < arrstring.Length; i++)
            {
                countNeurons[i] = Int32.Parse(arrstring[i]);
                //countNeurons = new int[] { 625, 3 };
            }

            net = new Net(countNeurons.Length, countNeurons);   // создание нейронной сети
            int type = 100500;

            for (int n = 0; n < numEpochs.Value; n++)
            {
                for (int i = 0; i < numExx.Value; i++)
                {
                    //type = ImageToMass("myImagesForNN\\forLearn\\normal\\", i);
                    type = ImageToMass("myImagesForNN\\forLearn\\sobel\\", i);
                    double[] input = mass;

                    double[] output = { -1, -1, -1 };
                    output[type] = 1;

                    var net_output = net.Calculate(input);

                    processLearn.Text += string.Format("n{0}/i{1}: Y*={2} Y={3}  type: {4}\r\n", n, i, arr_to_str(output), arr_to_str(net_output), type);

                    net.Learning(input, output, 1);
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            pressCounter = 0;
            trueCounter = 0;
            mass = new double[625];
            net = null;

            processLearn.Text = "";
            identifyResult.Text = "";

            numExx.Value = 70;
            numEpochs.Value = 10;
            neuronsInNet.Text = "625 3";

            numToIdentify.Value = 300;
            trueIdentify.Text = "Верных  0";
            totalIdentify.Text = "из  0";
            catalogPath.Text = @"myImagesForNN\forIdentify\sobel\";
            //catalogPath.Text = @"myImagesForNN\forIdentify\normal\";
        }

        private void loadWeights_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int counter = 0;
                string line; string[] arrstr = null;
                System.IO.StreamReader file = new System.IO.StreamReader(@openFileDialog1.FileName);
                while ((line = file.ReadLine()) != null)
                {
                    arrstr = line.Split(' ');
                    for (int i = 0; i < net.layers[1].weights[counter].Length; i++)
                    {
                        net.layers[1].weights[counter][i].value = Double.Parse(arrstr[i]);
                    }
                    counter++;
                }

                file.Close();
            }
        }

        int ImageToMass(string pathCatalog, int numPic)
        {
            string[] dir = null;

            Random rand = new Random();

            int type = rand.Next(3);

            switch (type)
            {
                case 0:
                    dir = Directory.GetFiles(pathCatalog + "circle\\", "*.bmp");
                    break;
                case 1:
                    dir = Directory.GetFiles(pathCatalog + "rectangle\\", "*.bmp");
                    break;
                case 2:
                    dir = Directory.GetFiles(pathCatalog + "triangle\\", "*.bmp");
                    break;
            }

            Bitmap bmp = new Bitmap(dir[numPic]);
            Thread.Sleep(19);

            int k = 0;  // счетчик
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    mass[k] = (bmp.GetPixel(i, j).GetBrightness() - 0.5) * 2;
                    k++;
                }
            }
            return type;
        }

        void ImageToMass(string pathCatalog, int num, int type)
        {
            string[] dir = null;

            switch (type)
            {
                case 0:
                    dir = Directory.GetFiles(pathCatalog + "circle\\", "*.bmp");
                    break;
                case 1:
                    dir = Directory.GetFiles(pathCatalog + "rectangle\\", "*.bmp");
                    break;
                case 2:
                    dir = Directory.GetFiles(pathCatalog + "triangle\\", "*.bmp");
                    break;
            }

            Bitmap bmp = new Bitmap(dir[num]);

            int k = 0;  // счетчик
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    mass[k] = (bmp.GetPixel(i, j).GetBrightness() - 0.5) * 2;
                    k++;
                }
            }
        }
    }
}
