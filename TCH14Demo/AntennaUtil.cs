using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TM200Demo
{
    public class AntennaUtil
    {
       public static void InitalPower(ComboBox value)
        {
            for (int i = 13; i <= 33; i++)
            {
                value.Items.Add(i);
            }
        }


        public static void InitalWorkTime(ComboBox value){
            for (int i = 20; i <= 10000; i+=10)
            {
                if (i > 500)
                {
                    break;
                }
                value.Items.Add(i);
            }
        }

        public static void InitalGapTime(ComboBox value)
        {
            for (int i = 0; i <= 10000; i+=10)
            {
                if (i > 500)
                {
                    break;
                }
                value.Items.Add(i);
            }
        }
    }

}
