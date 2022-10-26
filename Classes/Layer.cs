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
    }
}
