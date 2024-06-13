using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Færdighedsprøve___1_semester_2024
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public int YearOfBirth { get; set; }


        public Dog(int id, string name, string race, int yearOfBirth)
        {
            Id = id;
            Name = name;
            Race = race;
            YearOfBirth = yearOfBirth;
        }

        public override string ToString()
        {
            return "ID " + Id + " Dogs name: " + Name + " Race: " + Race + " Birth year: " + YearOfBirth;
        }



    }
}
