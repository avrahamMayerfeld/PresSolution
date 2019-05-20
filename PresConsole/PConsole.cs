using PresLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresConsole
{
    class PConsole
    {
        static void Main(string[] args)
        {
            PresFactors p = new PresFactors();

            if (args.Length == 0)
            {

                
                    Console.WriteLine("Are you a natural born citizen?");
                    string yesNo=(Console.ReadLine()).ToLower();
                    Boolean noYes;
                    if (yesNo.Equals("yes"))
                        noYes = true;
                    else
                        noYes = false;
                    p.NaturalBornCitizen = noYes;
                    Console.WriteLine("How old are You?");
                    p.Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How many years have you been living in the US?");
                    p.USResidenceYears = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How many times have you been elected President? Enter 0 if none.");
                    p.TimesElected = Convert.ToInt32(Console.ReadLine());
     
            }
            else
            {
                    string yesNo = (args[0].ToLower());
                    Boolean noYes;
                    if (yesNo.Equals("yes"))
                        noYes = true;
                    else
                        noYes = false;
                    p.NaturalBornCitizen = noYes;
                    
                    p.Age = Convert.ToInt32(args[1]);
                    p.USResidenceYears = Convert.ToInt32(args[2]);
                    p.TimesElected = Convert.ToInt32(args[3]);
                  
                
            }
            p.EligibilityMessage();
            Console.ReadKey();
        }
    }
}
