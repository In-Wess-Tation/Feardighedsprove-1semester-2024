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
            dog.CreateDog(5, "Bob", "Chichauchau", 2016);
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






        }
    }
}
