using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arrayofInts;
            arrayofInts = new int [] {0,1,2,3,4,5,6,7,8,9};
            Console.WriteLine(arrayofInts[1]);

            string[] names = new string[4] { "Tim", "Martin", "Nikki", "Sara"};
            Console.WriteLine(names[2]);

            bool[] truefalse = new bool[10] {true, false, true, false, true, false, true, false, true, false};
            int[,] multiplicationTable = new int[10,10];
            for(int i = 0; i <= 10; i++){
                for(int j = 0; j <= 10; j++){
                    multiplicationTable[i,j]=i*j;
                }
            }
            //creating a new dictionary with adding a new profile 
            Dictionary<string,dynamic> profile = new Dictionary<string,dynamic>();
            profile.Add("Name", "Cindy");
            profile.Add("Favorite Sport", "Lifting");
            profile.Add("Num of Pets", 1);
            profile.Add("Ice Cream", true);
    

            Dictionary<string,dynamic> profile2 = new Dictionary<string,dynamic>();
            profile2.Add("Name", "Tim");
            profile2.Add("Favorite Sport", "Hiking");
            profile2.Add("Num of Pets", 0);
            profile2.Add("Ice Cream", false);

            Dictionary<string,dynamic> profile3 = new Dictionary<string,dynamic>();
            profile3.Add("Name", "Martin");
            profile3.Add("Favorite Sport", "Skiing");
            profile3.Add("Num of Pets", 10);
            profile3.Add("Ice Cream", true);

            Dictionary<string,dynamic> profile4 = new Dictionary<string,dynamic>();
            profile4.Add("Name", "Nikki");
            profile4.Add("Favorite Sport", "Swimming");
            profile4.Add("Num of Pets", 2);
            profile4.Add("Ice Cream", true);

            //adding all of the profiles of dictionaries into a list
        var profiles = new List<Dictionary<string,dynamic>>();
               profiles.Add(profile);
               profiles.Add(profile2);
               profiles.Add(profile3);
               profiles.Add(profile4);

               //iterating through the list of dictionaries and grabbing the key value pairs
           for(int i = 0; i < profiles.Count; i++) {
               foreach (var entry in profiles[i]) {
                   Console.WriteLine(entry.Key + " - " + entry.Value);
               }
           }
        }
    }
}
