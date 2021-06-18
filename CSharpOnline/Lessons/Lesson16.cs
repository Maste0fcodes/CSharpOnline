using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{
    /*This class goes over lesson 16 content 
     Collections & LINQ*/
    class Lesson16
    {
        public void MyArrayListExample()
        {
            ArrayList myList = new ArrayList();
            myList.Add("Hello");
            myList.Add(42);
            myList.Add(true);
            myList.Add('T');
            PrintValues(myList);
        }

        private void PrintValues(IEnumerable myListing)
        {
            foreach (Object item in myListing)
            {
                Console.WriteLine("Values: {0}", item);
            }
        }

        public void MyHashTableExamples()
        {
            Hashtable myHash = new Hashtable();
            myHash.Add(10, "CSharp");
            myHash.Add(20, 24);
            myHash.Add(30, "Rocks");
            myHash.Add(40, 'J');

            foreach (DictionaryEntry item in myHash)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
        }

        public void MyListExample()
        {
            List<string> myList = new List<string>();
            myList.Add("Alpha");
            myList.Add("Bravo");
            myList.Add("Charlie");
            myList.Add("Delta");

            foreach (string item in myList)
            {
                Console.WriteLine(item);
            }
        }

        public void MyHouseListExample()
        {
            List<House> myHouseList = new List<House>();
            myHouseList.Add(new House(24, "concrete"));
            myHouseList.Add(new House());
            myHouseList.Add(new House(36, "brick", "shingle", "red" ));

            foreach(House item in myHouseList)
            {
                Console.WriteLine(item.DoorColor + " " + item.RoofType);
            }
        }

        public void MyDictionaryExample()
        {
            Dictionary<int, string> myList = new Dictionary<int, string>();
            myList.Add(10, "CSharp");
            myList.Add(20, "Rocks");
            myList.Add(30, "Happy");
            myList.Add(40, "Coding");

            // A single value we use TryGetValue
            string temp = "";
            if (myList.TryGetValue(20, out temp))
            {
                Console.WriteLine("Key 20 {0}", temp);
            }
        

            // Use foreach to get all values using KeyValuePair
            foreach (KeyValuePair<int,string> item in myList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

        }
    } // end class
} // end namespace
