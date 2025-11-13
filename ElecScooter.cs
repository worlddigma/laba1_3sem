using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_3sem
{
    public class ElecScooter : TransVehicle
    {
        private bool _Seat;
        public bool Seat  // Есть ли сиденье (True = есть, False = нет)
        {
            get { return _Seat; }
            set
            {
                if (value == false || value == true) _Seat = value;
                else throw new ArgumentException("Сиденье имеет неверное значение.");
            }
        }

        public ElecScooter(string company = "Unknown", string model = "Unknown", int year = 2000, bool seat = true) :
            base(company, model, year)
        {
            Seat = seat;
        }
        
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Имеется ли сиденье: {(Seat == true ? "Да" : "Нет")}");
        }
    }
}
