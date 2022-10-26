using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_3.Classes
{
    public class NeuralNetwork
    {
        public List<Layer> layers = new List<Layer>();
        public int hiddenLayerNeurons = 30;

        private NeuralNetwork() {}
        private static NeuralNetwork Instance = null;
        public static NeuralNetwork getInstance()
        {
            if (Instance == null) Instance = new NeuralNetwork();

            return Instance;
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

    }
}
