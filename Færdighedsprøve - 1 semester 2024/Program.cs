namespace Færdighedsprøve___1_semester_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dogs dog = new Dogs();

            Console.WriteLine("List of dogs: ");

            dog.CreateDog(0, "Roxie", "Bulldog", 2011);
            dog.CreateDog(1, "Stolas", "Poodle", 2005);
            dog.CreateDog(2, "Blitz", "Corgi", 2014);
            dog.CreateDog(3, "Luna", "Werewolf", 2018);
            dog.CreateDog(4, "Moxie", "Pug", 2021);
            dog.CreateDog(5, "Bob", "Retriever", 2016);
            dog.CreateDog(6, "Tim", "Bulldog", 2013);
            dog.CreateDog(7, "Pepper", "Corgi", 2007);
            dog.CreateDog(8, "Bones", "Goldenretriever", 2012);
            Console.WriteLine(dog.PrintDogList());


            try
            {
                Dog d = dog.GetDog("Moxie");
                Console.WriteLine("Dog searched: ");
                Console.WriteLine(d.ToString());
            }
            catch (DogNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }


            dog.DeleteDog("Luna");
            Console.WriteLine("");
            Console.WriteLine("List of dogs, Updated: ");
            Console.WriteLine(dog.PrintDogList());


            dog.UpdateDog(5, "Bob", "Chichauchau", 2022);
            Console.WriteLine("List of Dogs, updated: ");
            Console.WriteLine(dog.PrintDogList());








            Members member = new Members();

            Console.WriteLine("List of Members: ");

            member.CreateMember(0, "Bella", "Andreasvej 52", "12/12/1950", 20115675, "RandomEmail1@gmail.com", dog.TheDogList[0]);
            member.CreateMember(1, "Luna", "Hovedgaden 20", "03/04/1995", 20057413, "RandomEmail2@gmail.com", dog.TheDogList[1]);
            member.CreateMember(2, "Adam", "Sandrevej 10", "09/06/1997", 20149512, "RandomEmail3@gmail.com", dog.TheDogList[2]);
            member.CreateMember(3, "Anders", "Søndrevejsgade 08", "26/02/1987", 20184713, "RandomEmail4@gmail.com", dog.TheDogList[4]);
            member.CreateMember(4, "Mathias", "Lærkevej 98", "18/09/2001", 20213174, "RandomEmail5@gmail.com", dog.TheDogList[7]);
            member.CreateMember(5, "Bob", "Mortensvej 44", "15/07/2005", 20167954, "RandomEmail6@gmail.com", dog.TheDogList[6]);
            Console.WriteLine(member.PrintMemberList());


            try
            {
                Member m = member.GetMember("Anders");
                Console.WriteLine("Member searched: ");
                Console.WriteLine(m.ToString());
            }
            catch (MemberNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }


            member.DeleteMember("Bella");
            Console.WriteLine("");
            Console.WriteLine("List of Members, Updated: ");
            Console.WriteLine(member.PrintMemberList());


            member.UpdateMember(5, "Bob", "Mortensvej 44", "15/08/1999", 20167954, "RandomEmail6@gmail.com");
            Console.WriteLine("List of Members, updated: ");
            Console.WriteLine(member.PrintMemberList());






        }
    }
}
