using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework1
{
    public class SqueareRoot
    {
        public object Calculation(object a, object b, object c)
        {
            double epsilon = 1e-5;

            double absA = 0;
            double absB = 0;
            double absC = 0;  

            if (!(double.TryParse(a.ToString(), out absA) && double.TryParse(b.ToString(), out absB) && double.TryParse(c.ToString(), out absC)))
            {
                return new ArgumentException("(a || b || c) is not double");
            }
            else
            {
                if (Math.Abs(absA) < epsilon)
                {
                    return new ArgumentException("a != 0");
                }
                else
                {
                    var D = absB * absB - 4 * absA * absC;

                    if (Math.Abs(D) <= Math.Abs(epsilon))
                    {
                        return new double[] { -absB / (2 * absA), -absB / (2 * absA) }; 
                    }
                    else if (D < epsilon)
                    {
                        return new double[] { };
                    }
                    else
                    {
                        return new double[] { -absB + Math.Sqrt(D) / (2 * absA), -absB - Math.Sqrt(D) / (2 * absA) };
                    }
                }
            }
        }
    }
}
