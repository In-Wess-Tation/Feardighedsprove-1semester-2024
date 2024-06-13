using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Færdighedsprøve___1_semester_2024
{
    public class Members
    {
   

        List<Member> members = new List<Member>();

        public List<Member> TheMemberList { get => members; set => members = value; }

     /*   public void AddNewDog(int id, string name, string race, int YearOfBirth)
        {
            Dog d = new Dog(id, name, race, YearOfBirth);
            TheMemberList.Add(d);
           
        }*/
        public void CreateMember(int id, string name, string address, string birthDate, int phone, string email, Dog dog)
        {
            Member m = new Member(id, name, address, birthDate, phone, email, dog);
            TheMemberList.Add(m);
        }

        public string PrintMemberList()
        {
            string ml = "";
            foreach (Member m in TheMemberList)
            {
                ml = ml + m.ToString();
            }
            return ml;
        }


        public Member GetMember(string searchword)
        {
            bool found = false;
            int index = 0;
            Member foundMember = null;
            while (found == false && index <= TheMemberList.Count - 1)
            {
                if (TheMemberList[index].Name.Equals(searchword))
                {
                    found = true;
                    foundMember = TheMemberList[index];
                }
                index++;
            }
            if (found == false) throw new MemberNotFoundException();

            return foundMember;
        }

        /*public Dog AddDog(string searchword)
        {
            bool found = false;
            int index = 0;
            Dog foundDog = null;
            while (found == false && index <= TheDogList.Count - 1)
            {
                if (TheDogList[index].Name.Equals(searchword))
                {
                    found = true;
                    foundDog = TheDogList[index];
                }
                index++;
            }
            if (found == false) throw new DogNotFoundException();

            return foundDog;
        }*/


        public void UpdateMember(int id, string name, string address, string birthDate, int phone, string email, Dog dog)
        {
            bool found = false;
            int index = 0;
            while (found == false && index <= TheMemberList.Count - 1)
            {
                if (TheMemberList[index].Name.Equals(name))
                {
                    found = true;
                    TheMemberList[index].Id = id;
                    TheMemberList[index].Address = address;
                    TheMemberList[index].BirthDate = birthDate;
                    TheMemberList[index].Phone = phone;
                    TheMemberList[index].Email = email;
                    TheMemberList[index].Dog = dog;
                }
                index++;
            }
            if (found == false) throw new MemberNotFoundException();
        }


        public void DeleteMember(string searchWord)
        {
            bool found = false;
            int index = 0;
            while (found == false && index <= TheMemberList.Count - 1)
            {
                if (TheMemberList[index].Name.Equals(searchWord))
                {
                    found = true;
                    TheMemberList.RemoveAt(index);
                }
                index++;
            }
            if (found == false) throw new MemberNotFoundException();
        }


      public void RegisterDog()
        {
            new Dog { Id = 9, Name = "Futte", Race = "Blanding", YearOfBirth = 2010 };
        }




      /*  public void AddDog()
        {
            TheMemberList.Add(new Dog) {
                Name = name;
            }
        }*/






    }
}
