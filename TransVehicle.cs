using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_3sem
{
    public class TransVehicle
    {
       private string _Company;
        public string Company // Название компании (максимум 20 символов)
        { get { return _Company; }
                set { if (value.Length < 20 && value.Length > 0) _Company = value;
                else throw new ArgumentException("Длина названия компании неверно(от 0 до 20 символов).");
                    }
        }
        private string _Model;
        public string Model // Модель транспорта (максимум 20 символов)
        {
            get { return _Model; }
            set
            {
                if (value.Length < 20 && value.Length > 0) _Model = value;
                else throw new ArgumentException("Длина названия модели неверно(от 0 до 20 символов).");
            }
        }
        private int _Year;
        public int Year // Год выхода (2000 - 2025)
        {
            get { return _Year; }
            set
            {
                if (value < 2026 && value > 1999) _Year = value;
                else throw new ArgumentException("Дата введена неверно(от 2000 до 2025).");
            }
        }
        public TransVehicle(string company = "Unknown", string model = "Unknown", int year = 2000)
        {
            Company = company;
            Model = model;
            Year = year;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Компания: {Company}");
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Год выпуска: {Year}");
        }
    }
}
