using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr1 = new ArrayList();
            ArrayList arr2 = new ArrayList();
            arr1.Add("Apple");
            arr1.Add("Orange");
            arr1.Add("Coconat");
            arr1.Add("Watermelon");
            arr1.Add("Strawbary");
            foreach (string fruit in arr1)
            {
                Console.WriteLine(fruit);
            }
            arr1.Sort();
            foreach (string fruit in arr1)
            {
                Console.WriteLine(fruit);
            }
            arr2.AddRange(new int[]{7,5,3,7,1});
            foreach (int number in arr2)
            {
                Console.WriteLine(number);
            }
            arr2.Sort();
            foreach (int number in arr2)
            {
                Console.WriteLine(number);
            }
            Stack changes = new Stack();
            changes.Push("did x");
            changes.Push("deleted y");
            changes.Push("added z");
            changes.Push("changed y");
            changes.Push("added y");
            foreach (string change in changes)
            {
                Console.WriteLine(change);
            }
        }
    }
}
