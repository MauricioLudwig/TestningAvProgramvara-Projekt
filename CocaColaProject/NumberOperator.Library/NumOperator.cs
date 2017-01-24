using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOperator.Library
{
    public class NumOperator
    {
        // Operator that check if the variable is divided by 3 so it return "Coca"
        //                     if the variable is divided by 5 so it return "Cola"
        //                     if the variable is divided by 3 and 5 so it return "CocaCola"
        //                     else it will return it as it is
        #region CocaColaOperator
        public string CocaColaOperator(int num)
        {
            // return "1";

            // return num.ToString();

            string output = string.Empty;
            if (num % 3 == 0 && num % 5 == 0)//Tests if the variable num is divided on 3 AND 5
                output = "CocaCola";         //result "CocaCola" as output
            else if (num % 3 == 0)           //Tests if the variable num is divided on 3
                output = "Coca";             //result "CocaCola" as output
            else if (num % 5 == 0)           //Tests if the variable num is divided on 5
                output = "Cola";             //result "CocaCola as output
            else                             //If not
                output = num.ToString();     //the method will return the variable as it is

            return output;
        }
        #endregion 
    }
}
