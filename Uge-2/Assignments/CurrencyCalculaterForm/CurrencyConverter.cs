using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCalculaterForm
{
    public static class CurrencyConverter
    {
        private static float exchange = 7.45f;


        public static float DkkToEuro(float dkk)
        {
            return dkk / exchange;
        }

        public static float EuroToDkk(float euro)
        {
            return euro * exchange;
        }
    }


}
