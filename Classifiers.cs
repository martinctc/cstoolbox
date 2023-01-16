using System;

namespace cstoolbox
{
    public class Classifiers
    {
        public void ClassifyAge(int age)
        {            
            switch (age)
            {
                case var expression when age < 0:
                    Console.WriteLine("Invalid age value: 'age' is less than zero.");
                    break;
                case var expression when age < 18:
                    Console.WriteLine("Minor");
                    break;
                case var expression when age < 30:
                    Console.WriteLine("Adult under 30");
                    break;
                case var expression when age < 65:
                    Console.WriteLine("Adult 31 - 64");
                    break;
                case var expression when age <= 120:
                    Console.WriteLine("Adult 65+");
                    break;
                default:
                    Console.WriteLine("Invalid age value");
                    break;
            }
        }
    }        
}