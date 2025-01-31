using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorCommonLib.Exceptions;


namespace CalculatorCommonLib.Models
{
    public class Calculator //It should be public
    {
        public long PositiveNumberAddition(int firstNo, int secondNo)
        {
            if (AnyNumberIsNegative(firstNo, secondNo))
                throw new NegativeInputException(firstNo, secondNo);
            return firstNo + secondNo;
        }

        public bool AnyNumberIsNegative(int firstNo, int secondNo)
        {
            if ((firstNo < 0) || (secondNo < 0))
                return true;
            return false;
        }
        public long CubeEventNo(int number)
        {
            if (!IsEven(number))
                throw new NotAnEvenNumberException(number);
            return number * number * number;
        }

        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
