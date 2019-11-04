using System;

namespace NewYearGift
{
    public class Fruit : Sweetness
    {
        private int vitaminC;
        private int vitaminA;
        
        public int VitaminC//properties for field percentage of vitamin C
        {
            get
            {
                return vitaminC;
            }
            set
            {
                if (value <= 0)//checks if the inputed value is above zero
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                    vitaminC = value;
                }
            }
        }
        
        public int VitaminA//properties for field percentage of vitamin A
        {
            get
            {
                return vitaminA;
            }
            set
            {
                if (value <= 0)//checks if the inputed value is above zero
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                    vitaminA = value;
                }
            }
        }

        public Fruit(string name, int weight, int caloricValue, int price, int vitaminC, int vitaminA) : base(name, weight, caloricValue, price)//constructor of the class, that uses constructor of the parent class
        {
            this.vitaminC = vitaminC;
            this.vitaminA = vitaminA;
        }

        public Fruit()//empty constructor
        {
        }
        
        public override string ToString()//overriden method ToString(), that is used to convert objects into the string
        {
            return Name + ", weight: " + Weight + ", caloric value: " + CaloricValue + ", price: " + Price + ", percentage of vitamin C: " + VitaminC + ", percentage of vitamin A: " + VitaminA;
        }
    }
}