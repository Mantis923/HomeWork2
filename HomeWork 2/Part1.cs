/// Lab-Week2(Graded Assignment)    
/// File Name: HomeWork2
/// Student: Samuel Peppetta
/// Miracosta college fall 2021
/// Professor Mark Akola
///
/// This is a program that starts with the string variable first set to  first name and the string variable last set to  last
/// name.Both names should be all lowercase.The program should then create a new string that contains the full name in pig
/// latin with the first letter capitalized for the first and last name.The pig latin rule of moving the first letter to the
/// end of the word and adding “ay”. The pig latin name to the screen should be outputted. ToUpper methods to construct the new name is used





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String FirstName = "Samuel", LastName = "Peppetta";
            String pigLatinFirstName, pigLatinLastName;


            FirstName = FirstName.ToLower();
            LastName = LastName.ToLower();

            pigLatinFirstName = FirstName.Substring(1, FirstName.Length - 1) + FirstName.Substring(0, 1) + "ay";

            pigLatinFirstName = pigLatinFirstName.Substring(0, 1).ToUpper() + pigLatinFirstName.Substring(1, pigLatinFirstName.Length - 1);

            pigLatinLastName = LastName.Substring(1, LastName.Length - 1) + LastName.Substring(0, 1) + "ay";

            pigLatinLastName = pigLatinLastName.Substring(0, 1).ToUpper() + pigLatinLastName.Substring(1, pigLatinLastName.Length - 1);

            Console.WriteLine(pigLatinFirstName);
            Console.WriteLine(pigLatinLastName);

            Console.ReadLine();

        }
    }
}
