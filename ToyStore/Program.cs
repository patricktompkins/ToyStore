using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] toyArray = { "action figure", "dool", "Legos" };

            List<string> toyList = new List<string>() { "action figure", "stuffed animal", "Legos" };


            toyList.Add("Barbie");
            toyList.Add("remote control car");
            toyList.Add("Yo-yo");

            /*foreach(string toy in toyList)
            {
                Console.WriteLine(toy);
            }
           
            
            Console.WriteLine(toyList[0]); */

            //Properties and methods which we will use the mist are 
            //.count
            //.Insert
            //.Add
            //.Remove

            Console.WriteLine(toyList.Count);

            toyList.Remove("Barbie");

            Console.WriteLine(toyList.Count);

            //Insert allow us to put a new element in the list, and specify which index you want for that element.

           toyList.Insert(0, "kite");
           toyList.Insert(2, "Baby doll");
           toyList.Insert(1, "plastic dinosaur");

            /*foreach (string toy in toyList)
            /{
                Console.WriteLine(toy);
            } */

            //Another Method we will use often is .Contain()
            //It returns a Boolean value

            if (toyList.Contains("plastic dinosaur"))
            {
                Console.WriteLine("Daniel wold never buy the dino.");
            }

            else
            {
                Console.WriteLine("daniel might buy any of these toys.");
            }

            List<bool> shelfStatus = new List<bool>() { true, false, true, true, false };

            for (int i = 0; i < shelfStatus.Count; i++)
            {
                if (shelfStatus[i] == true)
                {
                    Console.WriteLine("there are toy on this shelf.");
                }

                else if (shelfStatus[i] == false)
                {
                    Console.WriteLine("This shelf is empty.");
                }

                else
                {
                    Console.WriteLine("You broke the code.");
                }


                //Creat a list. add five stuffed aninmals to you your list.
                //Print each stufgged animal in your list.


                List<string> stuffAnimals = new List<string>() {"Goofy", "Minnie Mouse",};
                stuffAnimals.Insert(5, "Barney");
                stuffAnimals.Insert(1, "Mickey Mouse");
                stuffAnimals.Insert(2, "Donald Duck");

              



                List<string> employeeNames = new List<string>();





            }
        }
    }
}
