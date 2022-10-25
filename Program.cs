using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Player
    {
        private string _name;
        private int _age;
        private int _bodyTemperature;
        private string _diagnosis;

        public Player(string name, int age, int weight, string diagnosis)
        {
            _name = name;
            _age = age;
            _bodyTemperature = weight;
            _diagnosis = diagnosis;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Пациент {_name}, возраст: {_age}, температура тела: {_bodyTemperature}. Диагноз {_diagnosis}");
        }
    }
}
