using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_Assignment
{
    // Create class for InvalidCastException
    internal class CastingException
    {
        // Declaring Constructor
        public CastingException()
        {
            try
            {
                // Create character
                char name = 'J';

                // Try to cast character to boolean 
                bool convertToBool = Convert.ToBoolean(name);

            }
            catch (InvalidCastException IcExc)
            {
                Console.WriteLine("InvalidCastException has occured here");

                // Print Exception Message
                Console.WriteLine(IcExc.Message);
            }
        }
    }
}
