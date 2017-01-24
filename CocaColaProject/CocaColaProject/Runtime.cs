using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberOperator.Library;

namespace CocaColaProject
{

    // Creating a new class Runtime so that we may avoid any issues in dealing with static methods
    class Runtime
    {
       
        public void Start()
        {

            // Creating a new instance of NumOperator to access its methods. NumOpeator derives from a class library
            NumOperator numOp = new NumOperator();

            // Region is comprised of a for loop which increments the I variable from 1-100, which itself serves as the input
            // for the NumOperator. The NumOperator returns a string which is then printed out onto the console
            #region PrintOperator
            for (int i = 1; i < 101; i++)
            {
                // Invoking the CocaColaOperator for each increment of I. The string returned is then printed to the Console
                Console.WriteLine(numOp.CocaColaOperator(i));
            }
            #endregion

            Console.ReadKey();
        }
    }
}
