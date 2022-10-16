using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MLANE_WCF_Assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        //stackoverflow suggestion for finding a Prime
        public string PrimeNumber(int number)
        {
            if (number > 1 && Enumerable.Range(1, number).Where(x => number % x == 0).SequenceEqual(new[] { 1, number }))
            {
                return "Prime Number";
            }
            return "Not A Prime Number";

        }

        public int SumOfDigits(int number)
        {
            string stringNumber = number.ToString();
            int sum = 0;

            foreach (var i in stringNumber)
            {
                sum += int.Parse(i.ToString());
            }

            return sum;
        }

        public string ReverseString(string inputString)
        {
            return new string(inputString.Reverse().ToArray());
        }

        //Old HTML text to show how to display a proper format HTML in a string
        public string PrintHtmlTags(string tag, string data)
        {
            return string.Format("<{0}>{1}</{0}>", tag, data);
        }

        public int[] SortNumbers(string type, int[] data)
        {
            switch (type.ToLower())
            {
                case "Ascending":
                    var ordered = data.OrderBy(x => x);
                    return ordered.ToArray();
                case "Descending":
                    var orderedDescending = data.OrderByDescending(x => x);
                    return orderedDescending.ToArray();
                default:
                    throw new Exception("Invalid Option");
            }

        }
    }
}
