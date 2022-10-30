using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Proiect_3.Classes
{
    public class NeuralNetwork
    {
        public BackgroundWorker backgroundWorker = new BackgroundWorker();
        public MainForm mainForm;

        public List<Layer> layers = new List<Layer>();
        public int hiddenLayerNeurons = 30;

        public double learningRate = 0.001;
        public double targetError = 0.001;
        public int epochsNumber = 1000;

        public List<NormHouseData> training_normData;
        public List<NormHouseData> testing_normData;

        private NeuralNetwork() 
        {
            backgroundWorker.DoWork += new DoWorkEventHandler(TrainNetwork);
            backgroundWorker.ProgressChanged += OnRunning;
            backgroundWorker.WorkerReportsProgress = true;
        }

        private void OnRunning(object sender, ProgressChangedEventArgs e)
        {
            mainForm.SetStatus(e.ProgressPercentage);
        }

        private static NeuralNetwork Instance = null;
        public static NeuralNetwork getInstance()
        {
            if (Instance == null)
            {
                Instance = new NeuralNetwork();
            }

            return Instance;
        }

        public void setData(List<NormHouseData> training_normData, List<NormHouseData> testing_normData)
        {
            this.training_normData = training_normData;
            this.testing_normData = testing_normData;
        }

        public void LoadDataToNetwork(NormHouseData data)
        {
            PropertyInfo[] properties = typeof(NormHouseData).GetProperties();

            int i = 0;
            foreach (PropertyInfo property in properties)
            {
                if (property.Name == "SalePrice") break;

                this.layers[0].neurons[i].inputValue[0] = (double)property.GetValue(data);
                i++;
            }

            // Adding sale price to the target output
            this.layers[2].neurons[0].targetOutput = data.SalePrice;
        }

        public void TransferData(Layer leftLayer, Layer rightLayer)
        {
            for (int i = 0; i < rightLayer.neurons.Count; i++)
            {
                for (int j = 0; j < rightLayer.neurons[i].inputValue.Length; j++)
                {
                    rightLayer.neurons[i].inputValue[j] = leftLayer.neurons[j].output;
                }
            }
        }

        public void FeedForward()
        {
            layers[0].CalculateOutput();

            TransferData(layers[0], layers[1]);

            layers[1].CalculateOutput();

            TransferData(layers[1], layers[2]);

            layers[2].CalculateOutput();
        }

        private double CalculateEpochError(List<double> errorList)
        {
            double error = 0;
            foreach (double value in errorList)
            {
                error += value;
            }
            error /= errorList.Count;
            return error;
        }

        private void BackPropagation()
        {
            foreach (Neuron neuron in layers[2].neurons)
            {
                double delta = (neuron.output - neuron.targetOutput) * neuron.activation * (1 - neuron.activation);
                neuron.delta = delta;

                for (int k = 0; k < neuron.weightValue.Length; k++)
                {
                    double deltaWeight = this.learningRate * layers[1].neurons[k].output * delta;
                    neuron.weightValue[k] -= deltaWeight;
                }
            }

            for (int j = 0; j < layers[1].neurons.Count; j++)
            {
                double deltaS = 0;
                List<double> deltaLayer = layers[2].GetDeltas();

                for (int k = 0; k < layers[2].neurons.Count; k++)
                {
                    deltaS += layers[2].neurons[k].weightValue[j] * deltaLayer[k];
                }

                double delta = deltaS * layers[1].neurons[j].activation * (1 - layers[1].neurons[j].activation);
                layers[1].neurons[j].delta = delta;

                for (int k = 0; k < layers[1].neurons[j].weightValue.Length; k++)
                {
                    double deltaWeight = this.learningRate * layers[0].neurons[k].output * delta;
                    layers[1].neurons[j].weightValue[k] -= deltaWeight;
                }
            }
        }

        public void GenerateNetwork(MainForm form)
        {
            this.mainForm = form;

            Layer inputLayer = new Layer("input", 28, 1);
            this.layers.Add(inputLayer);

            Layer hiddenLayer = new Layer("hidden", this.hiddenLayerNeurons, 28);
            this.layers.Add(hiddenLayer);

            Layer outputLayer = new Layer("output", 1, this.hiddenLayerNeurons);
            this.layers.Add(outputLayer);
        }

        private double FindCurrentError()
        {
            double sum = Math.Pow((layers[2].neurons[0].targetOutput - layers[2].neurons[0].output), 2);

            return sum / 2;
        }

        public void TrainNetwork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<double> error = new List<double>();
            bool status = false;

            for (int i = 0; i < epochsNumber; i++)
            {
                foreach (NormHouseData item in training_normData)
                {
                    LoadDataToNetwork(item);
                    FeedForward();

                    //Console.WriteLine("Output\t\t" + layers[2].neurons[0].output);
                    //Console.WriteLine("Target output\t\t" + layers[2].neurons[0].targetOutput);

                    double currentError = FindCurrentError();
                    error.Add(currentError);

                    BackPropagation();
                }
                double currentErrVal = CalculateEpochError(error);
                Console.WriteLine("Curr. err. val: " + currentErrVal.ToString());

                if (currentErrVal < targetError)
                {
                    status = true;
                    backgroundWorker.ReportProgress(1);
                    break;
                }
            }

            if (status == false)
            {
                backgroundWorker.ReportProgress(0);
            }
        }

    }
}
