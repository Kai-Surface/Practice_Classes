using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Classes
{
    internal class Dog
    {
        //Fields
        string _type;
        string _sex;
        string _coatColor;
        string _breed;

        public Dog()
        {
        }

        public Dog(string type, string sex, string coatColor, string breed)
        {
            type = type;
            sex = sex;
            coatColor = coatColor;
            breed = breed;
        }

        //Properties
        public string Type { get => _type; set => _type = value; }
        public string Sex { get => _sex; set => _sex = value; }
        public string CoatColor { get => _coatColor; set => _coatColor = value; }
        public string Breed { get => _breed; set => _breed = value; }

        public static void DogValues(Dog dog)
        {
            dog.Type = "Working line";
            dog.Sex =  "Male";
            dog.CoatColor = "Black and tan";
            dog.Breed = "European dobermann";
        }

        public override string ToString()
        {
            return $"Type of bloodline : {_type} . Sex : {_sex} . Coat color : {_coatColor} . " +
                $"Breed : {_breed} .";
        }
    }
}
