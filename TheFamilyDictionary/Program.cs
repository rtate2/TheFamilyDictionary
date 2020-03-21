using System;
using System.Collections.Generic;

namespace TheFamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            
            myFamily.Add("twin sister", new Dictionary<string, string>() { { "name", "Brandy" }, { "age", "34" } });
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Michael" }, { "age", "39" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Ramona" }, { "age", "65" } });
            myFamily.Add("father", new Dictionary<string, string>() { { "name", "Randy Sr." }, { "age", "55" } });
            myFamily.Add("oldest sister", new Dictionary<string, string>() { { "name", "LaToya" }, { "age", "44" } });
            myFamily.Add("other sister", new Dictionary<string, string>() { { "name", "Nisea" }, { "age", "37" } });

            foreach (var eachMember in myFamily)
            {
                Console.WriteLine($"{eachMember.Value["name"]} is my {eachMember.Key} and is {eachMember.Value["age"]} years old.");
            }
        }
    }
}
