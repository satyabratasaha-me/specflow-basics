using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Features
{
    class CalculatorApplication
    {
        private List<int> inputs = new List<int>();

        private int result;

        public void feedInputs(int input)
        {
            inputs.Add(input);
        }

        public void add()
        {
            result = 0;
            foreach (var item in inputs)
            {
                result = result + item;
            }
        }

        public void multiply()
        {
            result = 1;
            foreach (var item in inputs)
            {
                result = result * item;
            }
        }

        public void subtraction()
        {
            result = 0;
            foreach (var item in inputs)
            {
                result = result - item;
            }
        }

        public int getResult()
        {
            return result;
        }


    }
}
