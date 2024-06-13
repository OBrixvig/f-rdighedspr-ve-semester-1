using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Threading.Channels;
using System.Runtime.ExceptionServices;

namespace Færdighedsprøve_semester1
{
    public class Member
    {
        //instances
        private int _id;
        private string _name;
        private string _address;
        private DateTime _birthDate;
        private int _phone;
        private string _email;
        private int _dogPrices;
        private int _age;
        static int idcounter;

        private List<Dog> ownedDog;


        public Member(string name, string adresse,
                            DateTime birthDate, int phone, string email)
        {
            _id += ++idcounter;
            _name = name;
            _address = adresse;
            _birthDate = birthDate;
            _phone = phone;
            _email = email;
            ownedDog = new List<Dog>();
            _dogPrices = 0;

            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int born = int.Parse(_birthDate.ToString("yyyyMMdd"));
            int age = (now - born) / 10000;
            _age = age;

        }
        //Methods
        public void RegisterDog(Dog dog)
        {
            ownedDog.Add(dog);        
        }
        public void RemoveDog(Dog dog)
        {
            ownedDog.Remove(dog);

        }
        public void UpdateDogName(Dog dog, string newName)
        {
            dog.Name = newName;
        }
        public void GetAllDogs()
        {
            foreach (Dog dogs in ownedDog)
            {
                Console.WriteLine(dogs);
            }
        }

        public void CalculateMemberFee()
        {
            if (ownedDog.Count == 0)
            {
                _dogPrices = 0;
            }
            if (ownedDog.Count == 1)
            {
                _dogPrices += 1000;
            }
            if (ownedDog.Count > 1) 
            {
        //        ownedDog.Count + _dogPrices += 1000;      Er nået her til
            }
        }
        public string GetAge()
        {
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int born = int.Parse(_birthDate.ToString("yyyyMMdd"));
            int age = (now - born) / 10000;
            return age.ToString();
        }



        public override string ToString()
        {
            StringBuilder sB = new StringBuilder();
            sB.AppendLine("\n" + "Dine personlige informationer ");
            sB.AppendLine($"Navn: {_name} og medlemsID {_id} \nFødselsdag: {_birthDate} " +
                $"\nTelefon: {_phone}\nAddresse: {_address}\nEmail: {_email}\nPris for hundemedlmer {_dogPrices},- ");
            sB.AppendLine("Dine hunde informationer");
            foreach (Dog dogs in ownedDog)
            {
                sB.AppendLine(dogs.ToString());
            }
            //returner all the strings i have put in my sB
            return sB.ToString();
        }


        // making properties
        public int ID { get { return _id; } }
        public string Name { get { return _name; } }
        public string Address { get { return _address; } }
        public DateTime BirthDate { get { return _birthDate; } }
        public int Phone { get { return _phone; } }
        public string Email { get { return _email; } }
        public int Age { get { return _age; } }
        public int DogPrices { get { return _dogPrices; } }
        public List<Dog> OwnedDog { get { return ownedDog; } }
    }
}
