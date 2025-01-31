using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCommonLib.Exceptions
{
    public class NegativeInputException : Exception
    {
        private int _firstNo;
        private int _secondNo;

        public NegativeInputException(int firstNo, int secondNo)
        {
            this._firstNo = firstNo;
            this._secondNo = secondNo;

        }

        //public override string Message => base.Message;

        public override string Message
        {
            get
            {
                if (_firstNo < 0 && _secondNo < 0)
                    return $"The given both number is {_firstNo} , {_secondNo} in negative we support only positive number";
                else if (_firstNo < 0)
                    return $"The given number is {_firstNo} in negative we support only positive number";
                else if (_secondNo < 0)
                    return $"The given number is {_secondNo} in negative we support only positive number";
                else
                    return base.Message;

            }

        }
    }
}