using System;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Ivan";
            int c1 = firstName.Length; //4
            string lastName = "Petrov";
            int c2 = lastName.Length; //6
            string fullName = string.Concat(firstName, " ", lastName); //Ivan Petrov
            int c3 = fullName.Length; //11

        }
    }
}
