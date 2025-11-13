using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_3sem
{
    public class PassCar : TransVehicle
    {
        private bool _Roof;
        public bool Roof  // Есть ли крыша (True = есть, False = нет)
        {
            get { return _Roof; }
            set
            {
                if (value == false || value == true) _Roof = value;
                else throw new ArgumentException("Крыша имеет неверное значение.");
            }
        }
        public PassCar(string company = "Unknown", string model = "Unknown", int year = 2000, bool roof = true):
            base(company,model,year)
        {
            Roof = roof;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Имеется ли крыша: {(Roof == true ? "Да" : "Нет")}");
        }
    }
}
