using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_1
{
    public class Values
    {
        public double xstart { get; set; }
        public double xstop { get; set; }
        public double step { get; set; }
        public int n
        {
            get { return nn; }
            set
            {
                if (value <= 5)
                    throw new ArgumentException("Значение должно быть больше 5");
                nn = value;
            }
        }
        int nn;
    }
}
