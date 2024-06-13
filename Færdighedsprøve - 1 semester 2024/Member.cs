using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Færdighedsprøve___1_semester_2024
{
    public class Member
    {
        static int idCounter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int BirthDate { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }


        public Member(int id, string name, string address, int birthDate, int phone, string email) {
        
            Id = id;
            idCounter++;
            Name = name;
            Address = address;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
        
        }





    }
}
