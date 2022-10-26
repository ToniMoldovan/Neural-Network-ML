using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_3.Classes
{
    public class NeuralNetwork
    {
        public List<Layer> layers = new List<Layer>();
        public int hiddenLayerNeurons = 30;

        public double learningRate  = 0.001;
        public double targetError   = 0.001;
        public int epochsNumber     = 10;

        public List<NormHouseData> training_normData;
        public List<NormHouseData> testing_normData;

        private NeuralNetwork() {}

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

        public void GenerateNetwork()
        {
            Layer inputLayer = new Layer("input", 28, 1);
            this.layers.Add(inputLayer);

            Layer hiddenLayer = new Layer("hidden", this.hiddenLayerNeurons, 28);
            this.layers.Add(hiddenLayer);

            Layer outputLayer = new Layer("output", 1, this.hiddenLayerNeurons);
            this.layers.Add(outputLayer);
        }
        private double FindCurrentError()
        {
            double sum = Math.Pow((layers[2].neurons[0].targetOutput - layers[2].neurons[0].targetOutput), 2);

            return sum / 2;
        }

        public void TrainNetwork()
        {
            List<double> error = new List<double>();

            for (int i = 0; i < epochsNumber; i++)
            {
                foreach (NormHouseData item in training_normData)
                {
                    LoadDataToNetwork(item);
                    FeedForward();

                    double currentError = FindCurrentError();
                    error.Add(currentError);
                }
            }
        }

        
    }
}
