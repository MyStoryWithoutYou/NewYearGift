using System;
using System.IO;

namespace NewYearGift
{
    public class Services
    {
        public int totalWeight;
        public int totalPrice;
        
        Candy candy = new Candy();//creating an instance of a class
        Waffle waffle = new Waffle();//creating an instance of a class
        Fruit fruit = new Fruit();//creating an instance of a class
        
        Sweetness[] gift = new Sweetness[3];//creating an array of instances

        public void readFromFile()
        {
            using (FileStream fstream = File.OpenRead($"/Users/aliakseihudyma/RiderProjects/NewYearGift/input.txt"))//starting the stream of reading from the file
            {
                byte[] array = new byte[fstream.Length];//transforming the line from the file into bytes
                fstream.Read(array, 0, array.Length);//reading data
                string textFromFile = System.Text.Encoding.Default.GetString(array);//decoding bytes into string
                string[] words = textFromFile.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries);//spliting the string, separating by the comma
                
                int j = 0;
                candy.Name = words[j];//attaching the value from the file to the instance of the class
                candy.Weight = int.Parse(words[j += 1]);
                candy.CaloricValue = int.Parse(words[j += 1]);
                candy.Price = int.Parse(words[j += 1]);
                candy.CocoaPercentage = int.Parse(words[j += 1]);
                candy.Filling = words[j += 1];

                waffle.Name = words[j += 1];
                waffle.Weight = int.Parse(words[j += 1]);
                waffle.CaloricValue = int.Parse(words[j += 1]);
                waffle.Price = int.Parse(words[j += 1]);
                waffle.Taste = words[j += 1];
                waffle.IsGlazeUsed = bool.Parse(words[j += 1]);

                fruit.Name = words[j += 1];
                fruit.Weight = int.Parse(words[j += 1]);
                fruit.CaloricValue = int.Parse(words[j += 1]);
                fruit.Price = int.Parse(words[j += 1]);
                fruit.VitaminA = int.Parse(words[j += 1]);
                fruit.VitaminC = int.Parse(words[j += 1]);
                
                if (fstream != null)
                {
                    fstream.Close();//closing the stream of reading from the file
                }
            }
        }

        public void createArrayOfSweetness()
        {
            gift[0] = candy;//putting the instances of the classes into the array
            gift[1] = waffle;
            gift[2] = fruit;
        }

        public void printUnsortedArray()
        {
            Console.WriteLine("***** Unsorted gift *****");
            foreach (Sweetness s in gift)
            {
                Console.WriteLine(s);//printing the unsorted array
            }
        }

        public string countTotalWeight()
        {
            foreach (Sweetness s in gift)
            {
                totalWeight += s.Weight;//counting total weight of a gift
            }

            return "\nTotal weight of gift is " + totalWeight;
        }

        public void sortArray()// bubble sorting of the array(if two elements are in the wrong order, they swap their positions)
        {
            Sweetness temp;
            for (int i = 0; i < gift.Length - 1; i++)
            {
                bool f = false;
                for (int j = 0; j < gift.Length - i - 1; j++)
                {
                    if (gift[j+1].CaloricValue < gift[j].CaloricValue)
                    {
                        f = true;
                        temp = gift[j+1];
                        gift[j+1] = gift[j];
                        gift[j] = temp;
                    }                   
                }
                if(!f) break;
            }
        }

        public void printSortedArray()
        {
            Console.WriteLine("***** Sorted gift *****");
            foreach (Sweetness s in gift)
            {
                Console.WriteLine(s);//printing the sorted array
            }
        }

        public string countTotalPrice()
        {
            totalPrice = candy.Price / 2 + waffle.Price / 4 + fruit.Price / 4;// counting the total price of the gift
            return "\nTotal price of the gift is " + totalPrice;
        }

        public void writeResultIntoFile()
        {
            string str1 = candy.ToString();//transforming instances of the classes into string
            string str2 = waffle.ToString();
            string str3 = fruit.ToString();
            string str = str1 + str2 + str3 + "\nTotal weight of the gift is " + totalWeight + "\nTotal price of the gift is " + totalPrice;//joining everything into the one string
            
            using (FileStream fstream = new FileStream($"/Users/aliakseihudyma/RiderProjects/NewYearGift/output.txt", FileMode.OpenOrCreate))//starting a stream of writing into a file
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(str);//transforming string into bytes
                fstream.Write(array, 0, array.Length);//writing bytes into the file
                Console.WriteLine("\nText is written into the file");
            }
        }
    }
}