using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Classes
{
    internal class Bike
    {
        //Fields
        string _brand;
        string _type;
        string _color;
        int _wheels;

        public Bike()
        {
        }

        public Bike(string brand, string type, string color, int wheels)
        {
            _brand = brand;
            _type = type;
            _color = color;
            _wheels = wheels;
        }

        //Properties
        string Brand
        {
            get => _brand; set { _brand = value; }
        }

        string Type
        {
            get => _type; set { _type = value; }
        }

        string Color
        {
            get => _color; set { _color = value; }
        }

        int Wheels
        {
            get => _wheels; set { _wheels = value; }
        }

        public static void BikeValues(Bike bike)
        {
            bike.Brand = "Himiway";
            bike.Type = "Electric Mountain Bike";
            bike.Color = "Matte black";
            bike.Wheels = 2;
        }

        public override string ToString()
        {
            return $"Bike brand : {_brand} . Bike type {_type} . Bike color : {_color} . " +
                $"Bike wheels : {_wheels} .";
        }

    }
}
