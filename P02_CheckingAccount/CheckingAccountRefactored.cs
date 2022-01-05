using System;
using System.Collections.Generic;
using System.Text;

namespace P02_CheckingAccount
{
    public class Customer
    {
        public string Name { get; set; }

        public string Email { get; private set; }
    }

    public class Address 
    {
        public int ZipCode { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }
    }

    public class SocialSecurity 
    {
        public string SocialSecurityNumber { get; set; }

        public string GetSSNLast4Digits()
        {
            int index = SocialSecurityNumber.LastIndexOf("-", StringComparison.Ordinal);
            return index > 0 && index < SocialSecurityNumber.Length
                ? SocialSecurityNumber.Substring(index + 1, SocialSecurityNumber.Length)
                : SocialSecurityNumber;
        }
    }

    public class CheckingAccountRefactored
    {
        public string AccountNumber { get; set; }

        public Customer Customer { get; set; }

        public Address Address { get; set; }

        public DateTime ActiveDate { get; set; }

        public SocialSecurity SocialSecurity { get; set; }

        public CheckingAccountRefactored(string accountNumber, DateTime activeDate)
        {
            AccountNumber = accountNumber;
            ActiveDate = activeDate;
        }

        public CheckingAccountRefactored(string accountNumber, DateTime activeDate, Customer customer)
            : this(accountNumber, activeDate)
        {
            Customer = customer;
        }

        public CheckingAccountRefactored(string accountNumber, DateTime activeDate, Customer customer, Address address)
            : this(accountNumber, activeDate, customer)
        {
            Address = address;
        }

        public CheckingAccountRefactored(string accountNumber, Customer customer, Address address, DateTime activeDate, SocialSecurity socialSecurity)
            : this(accountNumber, activeDate, customer, address)
        {
            SocialSecurity = socialSecurity;
        }
    }
}
