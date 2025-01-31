using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCommonLib.Exceptions
{
    public class NotAnEvenNumberException:Exception
    {
        private int _number;
        public NotAnEvenNumberException(int number)
        {
            _number = number;
        }

        //public override string Message => base.Message; //This method will give the parent class (Exception)error message

        public override string Message
        {
            get { 
                return $"The number passed {_number} is not an Even number "; 
            }
        }
    }
}
