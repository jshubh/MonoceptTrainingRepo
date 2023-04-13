using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolationApp.Model
{
    internal class FixedDeposit
    {
        private int _accno;
        private string _name;
        private double _principalAmount;
        private int _duration;
        private FesitvalTypes _festivalTypes;

        public FixedDeposit(int accno,string name,double princpalAmount,int duration,FesitvalTypes fesitval)
        {
            _accno = accno;
            _name = name;
            _principalAmount = princpalAmount;
            _duration = duration;
            _festivalTypes = fesitval;
        }



        public double SimpleInterset
        {
            get
            {
                return _principalAmount * _duration * CalcuateRate();
            }
        }
        public double CalcuateRate()
        {
            if (_festivalTypes == FesitvalTypes.DIWALI)
            {
                return .09;

            }
            else if (_festivalTypes == FesitvalTypes.NEW_YEAR)
            {
                return 0.8;
            }
            else
                return .07;
        }
    }
}
