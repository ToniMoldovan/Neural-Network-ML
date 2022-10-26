using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_3.Classes
{
    public class Layer
    {
        public List<Neuron> neurons = new List<Neuron>();
        public string LAYER_TYPE = "";

        public Layer(string lAYER_TYPE, int neuronsNumber, int previousNeuronsNumber)
        {
            LAYER_TYPE = lAYER_TYPE;

            for (int i = 0; i < neuronsNumber; i++)
            {
                Random random = new Random();
                Neuron temp = new Neuron();

                Array.Resize(ref temp.inputValue, previousNeuronsNumber);
                Array.Resize(ref temp.weightValue, previousNeuronsNumber);

                double maximum = 1;
                double minimum = -1;

                for (int j = 0; j < previousNeuronsNumber; j++)
                {
                    temp.weightValue[j] = random.NextDouble() * (maximum - minimum) + minimum;
                }
            }
        }

        private void calculateOutputValue(Neuron neuron)
        {
            neuron.output = neuron.activation;
        }

        private void calculateActivationValue(Neuron neuron)
        {
            double numarator = 1f;
            double numitor = 1 + Math.Exp(-1 * neuron.input);
            double act = numarator / numitor;

            neuron.activation = act;
        }

        private void calculateInputValue(Neuron neuron)
        {
            double sum = 0;
            for (int i = 0; i < neuron.inputValue.Length; i++)
            {
                sum += neuron.inputValue[i] * neuron.weightValue[i];
            }
            neuron.input = sum;
        }

        internal void CalculateOutput()
        {
            //Input
            if (LAYER_TYPE == "input")
            {
                foreach (Neuron item in neurons)
                    item.output = item.inputValue[0];

            }
            else // hidden & output
            {
                foreach (Neuron item in neurons)
                {
                    calculateInputValue(item);
                    calculateActivationValue(item);
                    calculateOutputValue(item);
                }
            }
        }
    }
}
