namespace Færdighedsprøve_semester1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //first member
            Member firstMember = new Member("John John", "JohnsonVej 12", new DateTime(2000,06,13), 20202020, "johnjohn@mail.com");
            Dog firstDog = new Dog("Max", "2020","Terrier");
            Dog SecoundDog = new Dog("Sigurd", "2023", "Bulldog");
            firstMember.RegisterDog(firstDog);
            firstMember.RegisterDog(SecoundDog);
            Console.WriteLine(firstMember);
            Console.ReadKey();
            firstMember.RemoveDog(firstDog);
            Console.WriteLine(firstMember);

            




            Console.WriteLine(firstMember.GetAge());
            Console.WriteLine(firstDog);
            firstMember.UpdateDogName(firstDog, "Jason");
            Console.WriteLine(firstDog);


        }
    }
}
