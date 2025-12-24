using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Customer
    {
        public string GreetingAndCombineName(string firstName,string lastName)
        {
            return $"Hello, {firstName} {lastName}";
        }
    }
}
