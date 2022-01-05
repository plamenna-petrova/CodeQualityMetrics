using System;
using System.Collections.Generic;
using System.Text;

namespace P05_PhoneFormatter
{
    public class PhoneFormatterRefactored
    {
        public class Phone 
        {
            private string unformattedNumber;

            public Phone(string unformattedNumber)
            {
                this.unformattedNumber = unformattedNumber;
            }

            public string GetAreaCode()
            {
                string areaCode = unformattedNumber.Substring(0, 4);
                return areaCode;
            }

            public string GetPrefix()
            {
                string prefix = unformattedNumber.Substring(4, 2);
                return prefix;
            }

            public string GetMiddleDigits()
            {
                string middleDigits = unformattedNumber.Substring(6, 3);
                return middleDigits;
            }

            public string GetLastDigits()
            {
                string lastDigits = unformattedNumber.Substring(9, 4);
                return lastDigits;
            }

            public string FormatPhoneNumber() 
            {
                string formattedNumber = $"{GetAreaCode()} {GetPrefix()} {GetMiddleDigits()} {GetLastDigits()}";
                return formattedNumber;
            }
        }

        public class Customer 
        {
            private Phone phone;

            public Customer(Phone phone)
            {
                this.phone = phone;
            }

            public void GetPhoneNumber() 
            {
                Console.WriteLine(phone.FormatPhoneNumber());
            }
        }
    }
}
