using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMainTestapi.Services
{
    public class MathBL
    {
        //find the sum 
        public int FindSum(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public int FindProduct(int numOne, int numTwo)
        {
            int product = numOne * numTwo;
            return product;
        }

        public int FindDifference(int numOne, int numTwo)
        {
            int difference = numTwo - numOne;
            return difference;
        }

        public int FindModulus(int numOne, int numTwo)
        {
            int modulus = numOne % numTwo;
            return modulus;
        }

        public int FindDivisor(int numOne, int numTwo)
        {
            int divisor = numOne / numTwo;
            return divisor;
        }
    }
}
