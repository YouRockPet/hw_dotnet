using System;

namespace HW_06_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
           string text = Console.ReadLine();
            text.Replace("O", "A");
           string[] ar = text.Split(";");
            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }

            //Is this the real life? Is this just fantasy; Caught in a landslide, no escape from reality; Open your eyes, look up to the skies and see; I'm just a poor boy, I need no sympathy; Because I'm easy come, easy go, little high, little low;
        }
    }
}
