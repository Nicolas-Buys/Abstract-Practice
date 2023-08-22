using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        enum Menu
        {
            Dog = 1,
            Cat, 
            Bird,
            Show,
            Exit
        }
        static void Main(string[] args)
        {
            List < Dog > DogList = new List<Dog>();
            List<Cat> CatList = new List<Cat>();
            List<Bird> BirdList = new List<Bird>();
            while (true)
            {
                Console.WriteLine("1. Dog");
                Console.WriteLine("2. Cat");
                Console.WriteLine("3. Bird");
                Console.WriteLine("4. Show");
                Console.WriteLine("5. Exit");
                int choice = Convert.ToInt16( Console.ReadLine());

                switch ((Menu)choice)
                {
                    case Menu.Dog:
                        CreateDog(DogList);
                        break;
                    case Menu.Cat:
                        CreateCat(CatList);
                        break;
                    case Menu.Bird:
                        CreateBird(BirdList);
                        break;
                    case Menu.Show:
                        Show(BirdList, CatList, DogList);
                        
                        break;
                    case Menu.Exit:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static string[] Add()
        {
            string[] Details = new string[3];
            Console.WriteLine("Name: ");
            Details[0] = Console.ReadLine();
            Console.WriteLine("Sex: ");
            Details[1] = Console.ReadLine();
            Console.WriteLine("Age: ");
            Details[2] = Console.ReadLine();
            return Details;

        }
        static void Display(string name, string sex, int age)
        {
            Console.WriteLine("Name: " + name);
            
            Console.WriteLine("Sex: " + sex);
            
            Console.WriteLine("Age: "+age);
        }
        static List<Dog> CreateDog(List<Dog> Doggies)
        {
            string[] Details = new string[3];
            Details = Add();
            Dog DogAdd = new Dog(Details[0], Details[1], Convert.ToInt16(Details[2]));
            Doggies.Add(DogAdd);
            return Doggies;
        }

        static List<Cat> CreateCat(List<Cat> Kitties)
        {
            string[] Details = new string[3];
            Details = Add();
            Cat CatAdd = new Cat(Details[0], Details[1], Convert.ToInt16(Details[2]));
            Kitties.Add(CatAdd);
            return Kitties;
        }
        static List<Bird> CreateBird(List<Bird> Birdies)
        {
            string[] Details = new string[3];
            Details = Add();
            Bird BirdAdd = new Bird(Details[0], Details[1], Convert.ToInt16(Details[2]));
            Birdies.Add(BirdAdd);
            return Birdies;
        }
        static void Show(List<Bird> Birdies, List<Cat> Kitties, List<Dog> Doggies)
        {
            foreach (var item in Doggies)
            {
                Display(item.Name, item.Sex, item.Age);
                item.MakeSound();
            }
            foreach (var item in Kitties)
            {
                Display(item.Name, item.Sex, item.Age);
                item.MakeSound();
            }
            foreach (var item in Birdies)
            {
                Display(item.Name, item.Sex, item.Age);
                item.MakeSound();
            }
            Console.ReadKey();

        }
    }
}