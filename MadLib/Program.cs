using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentColor = Console.ForegroundColor;
            string activeVerb, adjective1, adjective2, pluralNoun, adjective3, personInRoom, pluralNoun2, place, adjective4, celebrity, noun, pluralNoun3, adjective5, pluralNoun4, pluralNoun5, noun2, pluralNoun6;
            Console.WriteLine("Enter a verb ending in ing: ");
            activeVerb = Console.ReadLine();
            Console.WriteLine("Enter an adjective: ");
            adjective1 = Console.ReadLine();
            Console.WriteLine("Enter an adjective: ");
            adjective2 = Console.ReadLine();
            Console.WriteLine("Enter a plural noun:");
            pluralNoun = Console.ReadLine();
            Console.WriteLine("Enter an adjective:");
            adjective3 = Console.ReadLine();
            Console.WriteLine("Enter the name of a person in the room:");
            personInRoom = Console.ReadLine();
            Console.WriteLine("Enter a plural noun:");
            pluralNoun2 = Console.ReadLine();
            Console.WriteLine("Enter the name of a Place:");
            place = Console.ReadLine();
            Console.WriteLine("Enter an adjective");
            adjective4 = Console.ReadLine();
            Console.WriteLine("Enter a celebrity");
            celebrity = Console.ReadLine();
            Console.WriteLine("Enter a noun:");
            noun = Console.ReadLine();
            Console.WriteLine("Enter a plural noun:");
            pluralNoun3 = Console.ReadLine();
            Console.WriteLine("Enter an adjective:");
            adjective5 = Console.ReadLine();
            Console.WriteLine("Enter a plural noun:");
            pluralNoun4 = Console.ReadLine();
            Console.WriteLine("Enter a plural Noun:");
            pluralNoun5 = Console.ReadLine();
            Console.WriteLine("Enter a noun:");
            noun2 = Console.ReadLine();
            Console.WriteLine("Enter a plural noun:");
            pluralNoun6 = Console.ReadLine();


            Console.WriteLine("The Art Of Espionage\n");


            Console.Write("Espionage is the formal word for ");
            ColorChange(activeVerb);
            Console.WriteLine(".");

            Console.Write("In the shadowy work of spies, a/an ");
            ColorChange(adjective1);
            Console.Write(" organization like the US government use spies to inflitrate ");
            ColorChange(adjective2);
            Console.WriteLine(" groups for the purpose of obtaing top secret ");
            ColorChange(pluralNoun);
            Console.WriteLine(".");
            Console.Write("For example, spies might have to crack the code for accessing confidential, ");
            ColorChange(adjective3);
            Console.Write(" files, or their mission could be far more dangerous- like stealing the key ingredients for making ");
            ColorChange(personInRoom);
            Console.Write("'s awardwinning Explosive Fudgy ");
            ColorChange(pluralNoun2);
            Console.WriteLine(".");
            Console.Write("Spies are found all over (the) ");
            ColorChange(place);
            Console.Write(" - but they are not allowed to reveal their ");
            ColorChange(adjective4);
            Console.WriteLine(" identities.");
            Console.Write("A teacher, ");
            ColorChange(celebrity);
            Console.Write(", or even the little old ");
            ColorChange(noun);
            Console.Write(" with the cane and fifteen pet ");
            ColorChange(pluralNoun3);
            Console.WriteLine(".");
            Console.Write("The world of spying might seem glamorous and ");
            ColorChange(adjective5);
            Console.Write(" - but it's filled with risks and ");
            ColorChange(pluralNoun4);
            Console.WriteLine("!");
            Console.Write("Sure, spies have a never-ending supply of supercool electronic ");
            ColorChange(pluralNoun5);
            Console.Write(", but they can't trust any ");
            ColorChange(noun2);
            Console.Write("- which is why the number one rule of spies is to keep friends close- and ");
            ColorChange(pluralNoun6);
            Console.Write(" closer!");



            Console.ReadLine();


        }

        public static void ColorChange(string text)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(text);
            Console.ForegroundColor = originalColor;
        }

    }
}
