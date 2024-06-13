using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Færdighedsprøve_semester1
{
    public class Dog
    {
        private int _id;
        private string _name;
        private string _yearOfBirth;
        private string _race;
        private enum DogRaces
        {
            BullDog,
            Terrier,
            Golden_reciver,
        }

        static int IdCounter;

        public Dog(string name, string yearOfBrith, string race)
        {
            _id =+ IdCounter++;
            _name = name;
            _yearOfBirth = yearOfBrith;
            _race = race;
        }

       

        public override string ToString()
        {
            string dogInfo = ($"Navn: {_name} og hundeID: {_id} \nFødt i årstal: {_yearOfBirth} \nRace:{_race}");
            return dogInfo;
           
        }

        //properties
        public int ID { get { return _id; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string YearOfBirth { get { return _yearOfBirth; } }
        public string Race {  get { return _race; } } 

    }
}
