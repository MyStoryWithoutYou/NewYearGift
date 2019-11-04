using System;

namespace NewYearGift
{
    public class Waffle : Sweetness
    {
        private string taste;
        private bool isGlazeUsed;
        
        public string Taste//properties for field taste
        {
            get
            {
                return taste;
            }
            set
            {
                if (value.Trim().Length == 0)//deletes all the blankspaces from the string and then compare it's length to zero
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                    taste = value;
                }
            }
        }
        
        public bool IsGlazeUsed//properties for field is glaze used
        {
            get
            {
                return isGlazeUsed;
            }
            set
            {
                isGlazeUsed = value;
            }
        }

        public Waffle(string name, int weight, int caloricValue, int price, string taste, bool isGlazeUsed) : base(name, weight, caloricValue, price)//constructor of the class, that uses constructor of the parent class
        {
            this.taste = taste;
            this.isGlazeUsed = isGlazeUsed;
        }

        public Waffle()//empty constructor
        {
        }
        
        public override string ToString()//overriden method ToString(), that is used to convert objects into the string
        {
            return Name + ", weight: " + Weight + ", caloric value: " + CaloricValue + ", price: " + Price + ", taste: " + taste + ", is glaze used: " + IsGlazeUsed;
        }
    }
}