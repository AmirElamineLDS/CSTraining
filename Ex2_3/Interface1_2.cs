using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_3
{
    class Interface1_2:I1,I2
    {

        string I1.Display()
        {
            return "Display1";
        }

        string I2.Display()
        {
            return "Display2";
        }

    }
}
