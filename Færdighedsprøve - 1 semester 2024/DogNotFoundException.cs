using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Færdighedsprøve___1_semester_2024
{
    public class DogNotFoundException : Exception
    {

        public DogNotFoundException() : base("Dog not found")
        { 
        
        }

        public DogNotFoundException(string message) : base(message)
        {

        }


    }
}
