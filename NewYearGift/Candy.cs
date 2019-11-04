using System;

namespace NewYearGift
{
    public class Candy : Sweetness
    {
        private int cocoaPercentage;
        private string filling;
        
        public int CocoaPercentage//properties for field cocoa percentage
        {
            get
            {
                return cocoaPercentage;
            }
            set
            {
                if (value <= 0)//checks if the inputed value is above zero
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                     cocoaPercentage= value;
                }
            }
        }
        
        public string Filling//properties for field filling
        {
            get
            {
                return filling;
            }
            set
            {
                if (value.Trim().Length == 0)//deletes all the blankspaces from the string and then compare it's length to zero
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                    filling = value;
                }
            }
        }

        public Candy(string name, int weight, int caloricValue, int price, int cocoaPercentage, string filling) : base(name, weight, caloricValue, price)//constructor of the class, that uses constructor of the parent class
        {
            this.cocoaPercentage = cocoaPercentage;
            this.filling = filling;
        }

        public Candy()//empty constructor
        {
        }
        
        public override string ToString()//overriden method ToString(), that is used to convert objects into the string
        {
            return Name + ", weight: " + Weight + ", caloric value: " + CaloricValue + ", price: " + Price + ", percentage of cocoa: " + CocoaPercentage + ", filling: " + Filling;
        }
    }
}