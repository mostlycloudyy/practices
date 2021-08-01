using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalebEDU1
{
    public class Person
    {
        public static int x = 1;
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string FullName  
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string GetFullName()
        //
        // Summary:
        //     Writes the text representation of the specified object, followed by the current
        //     line terminator, to the standard output stream using the specified format information.
        
        {
            return $"{FirstName} {LastName}";
        }
    }
}
