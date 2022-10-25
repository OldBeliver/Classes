using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient("Иванов Иван Иванович", 57, 38.5f, "Лень матушка");

            patient.ShowInfo();
        }
    }

    class Patient
    {
        private string _name;
        private int _age;
        private float _bodyTemperature;
        private string _diagnosis;

        public Patient(string name, int age, float temperature, string diagnosis)
        {
            _name = name;
            _age = age;
            _bodyTemperature = temperature;
            _diagnosis = diagnosis;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Пациент {_name}, возраст: {_age} лет, температура тела: {_bodyTemperature}. Диагноз: {_diagnosis}");
        }
    }
}
