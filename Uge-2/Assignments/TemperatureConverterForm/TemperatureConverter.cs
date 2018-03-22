using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverterForm
{
    public static class TemperatureConverter
    {
        public static float CelciusToFarenheit(float degreeCelcius)
        {
           return (degreeCelcius*1.8f) + 32f;
        }

        public static float FarenheitToCelcius(float degreeFarenheit)
        {
            return (degreeFarenheit-32f)/1.8f;
        }
    }
}
