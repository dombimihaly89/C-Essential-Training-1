using SchoolLibrary.ElementarySchool;
using SchoolLibrary.HighSchool;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        private string _twitterAddress;
        public string TwitterAddress
        {
            get { return _twitterAddress; }
            // make sure the twitter address starts with @
            set
            {
                if (value.StartsWith("@")) {
                    _twitterAddress = value;
                } else
                {
                    throw new Exception("The twitter address must start with @ symbol");
                }
            }
        }

        // you can generate constuctor with typing 'ctor' and press 2 tabs.
        public School()
        {
            Name = "untitled";
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

        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;
        public static int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(this.Address);
            sb.Append(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append("  ");
            sb.Append(Zip);
            return sb.ToString();
        }

    }
}
