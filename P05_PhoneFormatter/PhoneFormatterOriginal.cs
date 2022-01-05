using System;
using System.Collections.Generic;
using System.Text;

namespace P05_PhoneFormatter
{
    public class PhoneFormatterOriginal
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
                string formattedNumber =  $"{phone.GetAreaCode()} {phone.GetPrefix()} {phone.GetMiddleDigits()} {phone.GetLastDigits()}";
                Console.WriteLine(formattedNumber);
            }
        }
    }
}
