using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API
{
    public class TESTModule
    {
        public static object Module(object testObject)
        {
            switch (testObject)
            {
                case 1:
                case 2:
                    return doubler((int)testObject);
                case int value when value >= 3:
                    return tripler(value);

                /*It is unsafe for applications to rely on exact 
                  floating-point comparisons. Slight variations in rounding can change
                  the outcome of such comparisons, leading to non-convergence or other unexpected behavior*/
                
                /*You can improve the behavior of such codes by using inexact floating-point comparisons or
                 * fuzzy comparisons to test a value to within a certain tolerance
                 * we can make use of EPSILON comparisions
                 */

                case float floatValue when floatValue == 1.0f:
                    return leveler(floatValue);
                default:
                    return testObject;
            }


            int doubler(int amount) => amount * 2;
            int tripler(int amount) => amount * 3;
            double leveler(double amount) => amount - 0.1f * 10f;
        }

    }
}
