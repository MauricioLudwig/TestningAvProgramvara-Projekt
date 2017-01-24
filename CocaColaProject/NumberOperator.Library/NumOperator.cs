using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOperator.Library
{
    public class NumOperator
    {
        public string CocaColaOperator(int num)
        {
            // return "1";

            // return num.ToString();

            string output = string.Empty;
            if (num % 3 == 0 && num % 5 == 0)
                output = "CocaCola";
            else if (num % 3 == 0)
                output = "Coca";
            else if (num % 5 == 0)
                output = "Cola";
            else
                output = num.ToString();

            return output;
        }
    }
}
