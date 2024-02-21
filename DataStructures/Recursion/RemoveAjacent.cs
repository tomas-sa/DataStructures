using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Recursion
{
    public class numberIncrease
    {

        public static string Printer(int numero)
        {
            if(numero == 1) 
            {
                return numero.ToString();
            }
            return  Printer(numero - 1) + " " + numero.ToString();

        }
    }
}
