using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolationApp.Models
{
    internal class FixedDeposit
    {
        private readonly int _accno;
        private readonly string _name;
        private readonly double _principleAmount;
        private readonly int _duration;
        private readonly FestivalType _festivalType;

        public FixedDeposit(int accno, string name, double princple, int duration, FestivalType festival)
        {

            _accno = accno;
            _name = name;
            _principleAmount = princple;
            _duration = duration;
            _festivalType = festival;
        }

        private double CalcualteRate() {
            if (_festivalType == FestivalType.DIWALI)
                return .09;// complex logic quarter wise , 
            if (_festivalType == FestivalType.NEW_YEAR)
                return .10;//complex logic , rate policy

            return .06;
        
        }

        public double SimpleInterest {

            get {


                return _principleAmount * _duration * CalcualteRate();
            
            }
        
        }


        public FestivalType Festival { 
         
            get  {
                return _festivalType;
            
            }
        
        }

        public int Duration {

            get {
                return _duration;

            }
        }

        public double Principle {

            get {

                return _principleAmount;
            }
        }


        public int Accouno {

            get {

                return _accno;
            }
        }

        public string Name {

            get {
                return _name;

            }
        }
    }
}
