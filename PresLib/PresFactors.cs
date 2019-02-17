using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresLib
{
    public class PresFactors
    {
        //be a natural-born U.S.citizen of the United States;
        // be at least thirty-five years old;
        //be a resident in the United States for at least fourteen years.
        // no person can be elected president more than twice.

        public Boolean NaturalBornCitizen
        { get; set; }

        public int Age
        { get; set; }

        public int USResidenceYears
        { get; set; }

        public int TimesElected
        { get; set; }


    public Boolean DetermineEligibility()
        {
            Boolean eligible;
            if (NaturalBornCitizen = true && Age >= 35 && USResidenceYears >= 14 && TimesElected < 2)
                eligible = true;
            else
                eligible = false;
            return eligible;
        }

    public String ReturnEligibility()
        {


            String e; 
            

            if (DetermineEligibility().Equals(true))
                e= "Congratulations! You are eligible for U.S. Presidency!";
            else
                e= "Sorry, You may not be a U.S.President.";


            return e;
            
        }

    public void EligibilityMessage()
        {
            String msg = (ReturnEligibility());
            Console.WriteLine(msg);
        }


    

        

    }

}
