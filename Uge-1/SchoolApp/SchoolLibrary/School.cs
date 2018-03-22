using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class School
    {
        //Properties (get and set)
        public string Name { get; set; }
        public string Adress { get; set;  }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        
        private string _twitterAddress; //A private field to hold the value
        public string TwitterAddress
        {
            //make sure the twitter adress starts with @
            get { return _twitterAddress; }
            set
            {
                if(value.StartsWith("@"))
                {
                    _twitterAddress = value;
                } else
                {
                    throw new Exception("The twitter address must begin with @");
                }
            }
        }

        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "11111111";
        }

        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }

        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        //Example of function bodied expression
        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;

        //Example of overloading
        public static int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        //Overriding ToString()
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine(this.Adress);
            sb.Append(this.City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append(" ");
            sb.Append(Zip);

            return sb.ToString();
        }
    }
}
