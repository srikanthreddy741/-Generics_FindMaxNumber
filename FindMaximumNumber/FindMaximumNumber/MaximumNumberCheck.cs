using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    internal class MaximumNumberCheck
    {
        public int MaximumIntegerNumber(int firstvalue, int secondvalue, int thirdvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue;
            }
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0)
            {
                return secondvalue;
            }
            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0)
            {
                return thirdvalue;
            }
            throw new Exception("first value,second value, & third value are same");
        }
        public double MaximumFloatNumber(double firstvalue, double secondvalue, double thirdvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue;
            }
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0)
            {
                return secondvalue;
            }
            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0)
            {
                return thirdvalue;
            }
            throw new Exception("first value,second value, & third value are same");
        }
        public string MaximumStringNumber(string firststring, string secondstring, string thirdstring)
        {
            if (firststring.CompareTo(secondstring) > 0 && firststring.CompareTo(thirdstring) > 0 ||
                firststring.CompareTo(secondstring) >= 0 && firststring.CompareTo(thirdstring) > 0 ||
                firststring.CompareTo(secondstring) > 0 && firststring.CompareTo(thirdstring) >= 0)
            {
                return firststring;
            }
            if (secondstring.CompareTo(firststring) > 0 && secondstring.CompareTo(thirdstring) > 0 ||
                secondstring.CompareTo(firststring) >= 0 && secondstring.CompareTo(thirdstring) > 0 ||
                secondstring.CompareTo(firststring) > 0 && secondstring.CompareTo(thirdstring) >= 0)
            {
                return secondstring;
            }
            if (thirdstring.CompareTo(firststring) > 0 && thirdstring.CompareTo(secondstring) > 0 ||
                thirdstring.CompareTo(firststring) >= 0 && thirdstring.CompareTo(secondstring) > 0 ||
                thirdstring.CompareTo(firststring) > 0 && thirdstring.CompareTo(secondstring) >= 0)
            {
                return thirdstring;
            }
            throw new Exception("first string,second string, & third string are same");
        }
    }
}
