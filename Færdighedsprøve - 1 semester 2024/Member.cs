using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Færdighedsprøve___1_semester_2024
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string BirthDate { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public List<Dog> Dogs { get; set; }


        public Member(int id, string name, string address, string birthDate, int phone, string email, Dog dog) {
            Dogs = new List<Dog>();

            Id = id;
            Name = name;
            Address = address;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
            Dogs.Add(dog);
        }


        public override string ToString()
        {
            return "ID: " + Id + ", Members name: " + Name + ", Address: " + Address + ", Birth Date: " + BirthDate + ", Phonenumber: " + Phone + ", Email: " + Email +  ", Members dog: " + Dogs + Environment.NewLine;
        }


    }
}
