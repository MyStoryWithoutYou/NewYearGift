using System;

namespace NewYearGift
{
    public class Sweetness
    {
        private string name;
        private int weight;
        private int caloricValue;
        private int price;

        public string Name//properties for field name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Trim().Length == 0)//deletes all the blankspaces from the string and then compare it's length to zero
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                    name = value;
                }
            }
        }
        
        public int Weight//properties for field weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value <= 0)//checks if the inputed value is above zero
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                    weight = value;
                }
            }
        }
        
        public int CaloricValue//properties for field caloric value
        {
            get
            {
                return caloricValue;
            }
            set
            {
                if (value <= 0)//checks if the inputed value is above zero
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                    caloricValue = value;
                }
            }
        }
        
        public int Price//properties for field price
        {
            get
            {
                return price;
            }
            set
            {
                if (value <= 0)//checks if the inputed value is above zero
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                    price = value;
                }
            }
        }

        public Sweetness(string name, int weight, int caloricValue, int price)//constructor of the class
        {
            this.name = name;
            this.weight = weight;
            this.caloricValue = caloricValue;
            this.price = price;
        }

        public Sweetness()//empty constructor
        {
        }
        
        public override string ToString()//overriden method ToString(), that is used to convert objects into the string
        {
            return "\nSweetness " + Name + ", weight: " + Weight + ", caloric value: " + CaloricValue + ", price: " + Price;
        }
    }
}