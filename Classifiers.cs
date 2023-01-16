using System;

namespace cstoolbox
{
    public class Classifiers
    {
        public string ClassifyAge(int age)
        {            
            switch (age)
            {
                case var expression when age < 0:
                    return "Invalid age value: 'age' is less than zero.";
                    break;
                case var expression when age < 18:
                    return "Minor";
                    break;
                case var expression when age < 30:
                    return "Adult under 30";
                    break;
                case var expression when age < 65:
                    return "Adult 31 - 64";
                    break;
                case var expression when age <= 120:
                    return "Adult 65+";
                    break;
                default:
                    return "Invalid age value";
                    break;
            }
        }
    }        
}