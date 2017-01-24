using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberOperator.Library;

namespace CocaColaProject
{
    class Runtime
    {
        
        public void Start()
        {

            NumOperator numOp = new NumOperator();

            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(numOp.CocaColaOperator(i));
            }

            Console.ReadKey();
        }
    }
}
