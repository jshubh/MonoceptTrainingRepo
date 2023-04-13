using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPViolatiobApp.Model
{
    internal class Invoic
    {
        private int _id;
        private string _description;
       
        private double _cost;
        private double _discountPercent;
        private const double _tax = .10;

        public Invoic(int id,string description,double cost,double discount)
        {
            _id = id;
            _description = description;
            _cost = cost;
            _discountPercent = discount;
        }
        public double CalculateTax()
        {
            return _cost * _tax;
        }
        public double CalcualteDiscount()
        {
            return _cost * _discountPercent;
        }
        public double FinalCost()
        {
            return _cost + CalculateTax() - CalcualteDiscount();
        }
        public void PrintInvoice()
        {
            string template = $"Id:{_id}" +
                $"description:{_description}" +
                $"cost is :{_cost}" +
                $"tax amount is :{CalculateTax()}" +
                $"discount amt is: {CalcualteDiscount()}" +
                $"final cost is :{FinalCost()}";
            Console.WriteLine(template);

        }
    }
}
