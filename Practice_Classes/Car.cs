using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Classes
{
    internal class Car
    {
        //Fields
        string _make;
        string _model;
        int _year;
        string _color;
        int _mileage;

        // I needed to add this extra field to be able to reference it in Program.cs
        public Car()
        {
        }

        public Car(string make, string model, int year, string color, int mileage)
        {
            _make = make;
            _model = model;
            _year = year;
            _color = color;
            _mileage = mileage;
        }

        //Properties
        string Make
        {
            get => _make; set { _make = value; }
        }

        string Model
        {
            get => _model; set { _model = value; }
        }

        int Year
        {
            get => _year; set { _year = value; }
        }

        string Color
        {
            get => _color; set { _color = value; }
        }

        int Mileage
        {
            get => _mileage; set { _mileage = value; }
        }

        public static void CarValues(Car car)
        {
            car.Make = "Audi";
            car.Model = "Q5";
            car.Year = 2018;
            car.Color = "grey";
            car.Mileage = 22000;
        }

        public override string ToString()
        {
            return $"Car make : {_make} . Car model {_model} . Car year : {_year} . " +
                $"Car color : {_color} . Car mileage : {_mileage} .";
        }
    }
}
