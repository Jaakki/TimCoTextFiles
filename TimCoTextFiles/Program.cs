using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace TimCoTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string filePath = @"D:\FileSystem\SubFolderMonsters\Goblin.txt";
            /*
            List<string> lines = File.ReadAllLines(filePath).ToList();          //reading through a txt file

            foreach (string line in lines)
            {
                Console.WriteLine($"{line}");
            }

            lines.Add("Goblin poop");

            File.WriteAllLines(filePath, lines);                                //writing to a txt file
            */

            List<Person> people = new List<Person>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Person newPerson = new Person();

                newPerson.FirstName = entries[0];
                newPerson.LastName = entries[1];
                newPerson.Money = Convert.ToInt32(entries[2]);

                people.Add(newPerson);
            }

            Console.WriteLine("Read from txt file");

            foreach (var person in people)
            {
                Console.WriteLine($"Goblin name:{person.FirstName} {person.LastName} Coins: {person.Money}");
            }

            people.Add(new Person { FirstName = "Gutstabba", LastName = "Ratsnik", Money = 500 });

            List<string> output = new List<string>();

            foreach (var person in people)
            {
                output.Add($"{person.FirstName},{person.LastName},{person.Money}");
            }

            Console.WriteLine("Writing to txt file");

            File.WriteAllLines(filePath, output);

            Console.WriteLine("Entries writen");

            Console.ReadLine();
        }
    }
}
