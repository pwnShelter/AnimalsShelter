using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsShelter
{
    class Program
    {
        static bool quit = true;

        static void Main(string[] args)
        {
            string input = String.Empty;
            Shelter sh = new Shelter(5);

            while (quit)
            {
                Menu(ref input, sh);
                input = Console.ReadLine();
            }

            Console.Read();
        }

        static void Menu(ref string input, Shelter shelter)
        {
            Console.Clear();
            switch (input)
            {
                case "1":
                    {
                        AddAnimalMenu(shelter);
                        break;
                    }
                case "2":
                    {
                        RemoveAnimalMenu(shelter);
                        break;
                    }
                case "status":
                    {
                        ShelterStatus(shelter);
                        break;
                    }
                case "q":
                    {
                        quit = false;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Welcome in Animal's Shelter App!\n");
                        Console.WriteLine("1 - Add new animal");
                        Console.WriteLine("2 - Remove animal");
                        Console.WriteLine("status - count animals in shelter");
                        Console.WriteLine("q - quit");
                        break;
                    }
            }
        }

        static void AddAnimalMenu(Shelter s)
        {
            Console.Write("Set an animal name: ");
            s.AddAnimal(new Animal(Console.ReadLine()));
        }

        static void RemoveAnimalMenu(Shelter s)
        {
            Console.Write("Remove an animal at position: ");
            s.RemoveAnimal(int.Parse(Console.ReadLine()));
        }

        static void ShelterStatus(Shelter s)
        {
            foreach(var a in s)
                Console.WriteLine(a);

            int empty = s.EmptyPlaces;
            if(empty > 1)
                Console.WriteLine("There are {0} empty places in Animal's Shelter.", empty);
            else if (empty > 0)
                Console.WriteLine("There is last empty place in Animal's Shelter!");
            else
                Console.WriteLine("Animal's Shelter if full!");
        }
    }
}
