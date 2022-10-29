using System;
using UpcastindvsDowncastingforPractise.Models;

namespace UpcastindvsDowncastingforPractise {
    class Program {
        static void Main(string[] args)
        {
            //upcasting, implicit, boxing

            #region MyPractice

            //Maltese maltese = new Maltese();
            //Dog dog = new Maltese();

            //Dog dog = maltese;

            //Console.WriteLine(dog.GetType());

            //Animal mlts = new Maltese();

            //Animal lionfish = new LionFish();

            //LionFish lion = (LionFish)lionfish;

            //lion = mlts as LionFish;
            //Console.WriteLine(lion==null);
            //lion.Poison = "Deadly";
            //if(mlts is LionFish)
            //{
            //	lion = (LionFish)mlts;
            //}
            //else
            //{
            //	Console.WriteLine("Error");
            //}        


            #endregion


            #region ClassTaskPracting
            //Eagle eagle1 = new Eagle();

            //Animal animal = eagle1;

            //Animal animal2 = new Eagle();

            //animal2.Eat();

            //int num1 = 15;
            //byte num2 = (byte)num1;

            //byte num3 = 5;
            //int num4 = num3;

            //int a = 10;
            //object b = a;

            //int c = (int)b;

            //Console.WriteLine(b);

            //Eagle eagle1 = new Eagle();
            //Animal eagle2 = new Eagle();

            //Shark shark1 = new Shark();
            //Animal shark2 = new Shark();

            //Shark shark3 = (Shark)shark2;

            //Animal[] animals = { eagle1, eagle2, shark1, shark2 };

            //foreach (var item in animals)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Animal shark1 = new Shark();
            //Animal shark2 = new Shark();

            //object[] objects = { 1, 2, "P414", shark1, shark2 };

            //foreach (var item in objects)
            //{
            //Animal animal = item as Animal;

            //string result = animal == null ? "Can't cast" : "Success";

            //bool isCast = animal == null ? true : false;

            //if (!isCast)
            //{
            //    string result = animal.Name ?? "Lucky";
            //    Console.WriteLine(result);
            //}

            //if (animal == null)
            //{
            //    Console.WriteLine("Can't cast");
            //}
            //else
            //{
            //    animal.Name = "test";
            //    Console.WriteLine(animal.Name);

            //    Console.WriteLine("Success");
            //}




            //if (item is Animal l)
            //{
            //    l.Name = "Lionfish";
            //    Console.WriteLine(l.Name);
            //}
            //else
            //{
            //    //Console.WriteLine("Can't cast");
            //    //Console.WriteLine(item);
            //}
            //}

            #endregion




        }
    }

}