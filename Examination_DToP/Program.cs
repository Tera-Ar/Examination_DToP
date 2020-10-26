using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_DToP
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonNum();

            //Write MENU / instuctions | YYYYMMDDnnnc (Y = Year, M = Month, D = Day, n = random numbers 000 to 999)

            /* Metode    //userInput... (convert from string to char[arrey])
            //check that "personnummer" has 12Nummbers
            //Check if "personummer"s format is correct (YYYYMMDDnnnc) or wrong
            //Check if year is correct(YYYY) YYYY (1753 - 2020)
            //check if month is correct(MM) (01 - 12)
            //check if days is correct(DD) for designated month.. 
            //And if Feb(02) check if it's a leapyear (see exam_uppgifts text) 
            //Check if (nnn) odd(1,3,5,7,9) or even(0,2,4,6,8). Odd = Male, Even = Female.
            */

            //Write if "personnummer" Correct or Wrong
            //if Wrong write that the "personnummer" was wrong and repeat from start.
            //if Correct write Correct format "personnummer" and gender


            Console.ReadKey(); 
        }
        static void PersonNum()
        {
            int[] personNum = new int[12];
            string userInput = "";            
            Console.Write("Skriv personnumber utan mellanrum YYYYMMDDnnnc: ");
            userInput = Console.ReadLine();
            
            char[] personNummer = userInput.ToCharArray();
            if (personNummer.Length == 12)
            {
                 //if ()
                 Console.WriteLine("the Personnummer is 12");
                for (int i = 0; i < personNum.Length; i++)
                {
                    personNum[i] = personNummer[i];
                    Console.WriteLine(personNum[i]);
                }
            }
            else
            {
                Console.WriteLine("Wrong\r\n");
                
            }          
        }
    }
}
