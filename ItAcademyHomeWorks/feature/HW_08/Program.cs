using System;

namespace HW_08
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string x = null;

            Console.WriteLine("Hello! What is your name?");
            CheckIn Person = new CheckIn(Console.ReadLine());

            void Hello(string a)
            {
                System.TimeSpan str = DateTime.Now.TimeOfDay;
                int hours = str.Hours;
                if (hours >= 9 && hours < 12)
                    Console.WriteLine("Good morning, " + a);
                if (hours >= 12 && hours < 15)
                    Console.WriteLine("Good day, " + a);
                if (hours >= 15 && hours < 22)
                    Console.WriteLine("Good evening, " + a);
                if (hours >= 22 && hours < 9)
                    Console.WriteLine("Good night, " + a);
            }

            Hello(Person.Name);

            Console.WriteLine("Do you have a ticket or wanna bay them?");
            string ansver = Console.ReadLine();
            ansver.ToLower();
            

            if (ansver.Contains("yes"))
                x = "yes";
            else if (ansver.Contains("no"))
                x = "no";
           
                switch (x)
                {
                    case "yes":
                        Console.WriteLine("Come to security.");
                        break;

                    case "no":
                        Console.WriteLine("Okay, let's come to counter.");
                        break;

                    default:
                        Console.WriteLine("Try more");
                        break;
                }
            Console.WriteLine("Good afternoon, this is a security service.Plese, describe your luggage");
            Console.WriteLine("To stop press \"/\"");
            string bag = null;
            do
            {
                bag = Console.ReadLine();
                if (Search(bag) == true)
                    break;
            } while (bag != "/");

            Console.WriteLine("All right, come to pasport control.");
            Console.WriteLine("Write your pasport number");
            string pasport = Console.ReadLine();
            pasport.Replace(" ", pasport);
            if (pasport.Length == 9)
                Console.WriteLine("Nice travel, mr." + Person.Name + "!");



        }

    }
}
