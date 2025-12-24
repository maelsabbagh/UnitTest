using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Customer
    {
        public string Greeting { get; set; }
        public string GreetingAndCombineName(string firstName,string lastName)
        {
            if(string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("Empty first name");
            }

            Greeting = $"Hello, {firstName} {lastName}";
            return Greeting;
        }
    }
}
