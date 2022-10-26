using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_3.Classes
{
    public class Neuron
    {
        public double[] inputValue = null;
        public double[] weightValue = null;

        public double delta;
        public double input;        // input function
        public double activation;   // activ function (sigomidal)
        public double output;       // out function (non-binary)
        public double targetOutput; 


    }
}
