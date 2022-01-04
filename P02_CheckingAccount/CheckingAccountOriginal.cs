using System;
using System.Collections.Generic;
using System.Text;

namespace P02_CheckingAccount
{
    public class CheckingAccountOriginal
    {
        public int AccountNumber { get; set; }

        public string CustomerName { get; set; }

        public string Email { get; private set; }

        public string Address { get; set; }

        public int ZipCode { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string SocialSecurityNumber { get; set; }

        public DateTime ActiveDate { get; set; }

        public string GetSSNLast4Digits()
        {
            int index = SocialSecurityNumber.LastIndexOf("-", StringComparison.Ordinal);
            return index > 0 && index < SocialSecurityNumber.Length
                ? SocialSecurityNumber.Substring(index + 1, SocialSecurityNumber.Length)
                : SocialSecurityNumber;
        }

        public CheckingAccountOriginal(int accountNumber, string customerName, string email, string address, int zipCode, string city, string state, string country, string socialSecuriyNumber, DateTime activeDate)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
            Email = email;
            Address = address;
            ZipCode = zipCode;
            City = city;
            State = state;
            Country = country;
            SocialSecurityNumber = socialSecuriyNumber;
            ActiveDate = activeDate;
        }
    }
}
