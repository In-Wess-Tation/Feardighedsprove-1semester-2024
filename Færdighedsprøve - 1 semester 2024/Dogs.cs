using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Færdighedsprøve___1_semester_2024
{
    public class Dogs
    {

        List<Dog> dogs = new List<Dog>();
      
        public List<Dog> TheDogList { get => dogs; set => dogs = value; }

        public void CreateDog(int id, string name, string race, int yearOfBirth)
        {
            Dog d = new Dog(id, name, race, yearOfBirth);
            TheDogList.Add(d);
        }

        public string PrintDogList()
        {
            string dl = "";
            foreach(Dog d in TheDogList) 
            { 
                dl = dl + d.ToString(); 
            }
            return dl;
        }


        public Dog GetDog(string searchword)
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
        }


        public void UpdateDog(int id, string name, string race, int yearOfBirth)
        {
            bool found = false; 
            int index = 0; 
            while (found == false && index <= TheDogList.Count - 1)
            {
                if (TheDogList[index].Name.Equals(name))
                {
                    found = true;
                    TheDogList[index].Id = id;
                    TheDogList[index].Race = race;
                    TheDogList[index].YearOfBirth = yearOfBirth;
                }
                index++;
            }
            if(found == false) throw new DogNotFoundException();
        }


        public void DeleteDog(string searchWord)
        {
            bool found = false; 
            int index = 0;
            while (found == false && index <= TheDogList.Count - 1)
            {
                if (TheDogList[index].Name.Equals(searchWord))
                {
                    found= true;
                    TheDogList.RemoveAt(index);
                }
                index++;
            }
            if (found == false) throw new DogNotFoundException();
        }






    }
}
