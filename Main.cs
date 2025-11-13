
namespace laba1_3sem
{
    public class Program
    {
    public static void PrintMenu()
        {
            Console.WriteLine("Меню");
            Console.WriteLine("1. Добавить Транспортное средство");
            Console.WriteLine("2. Добавить Легковой автомобиль");
            Console.WriteLine("3. Добавить Электрический самокат");
            Console.WriteLine("4. Вывод списка устройств.");
            Console.WriteLine("5. Выход");
            Console.Write("Выберите действие: ");
        }
        public static TransVehicle CreateBaseVehicle()
        {
            string company, model; 
            int year;
            Console.Write("Введите производителя: ");
            company = Console.ReadLine();
            Console.Write("Введите модель: ");
            model = Console.ReadLine();
            Console.Write("Введите год выпуска(2000-2025): ");
            year = Convert.ToInt32(Console.ReadLine());
            return new TransVehicle(company,model,year);
        }
        public static PassCar CreatePassCar()
        {
            string company, model;
            int year;
            bool roof;
            Console.Write("Введите производителя: ");
            company = Console.ReadLine();
            Console.Write("Введите модель: ");
            model = Console.ReadLine();
            Console.Write("Введите год выпуска(2000-2025): ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите есть ли у машины крыша(да/нет): ");
            string _roof = Console.ReadLine();
            if (_roof == "Да" || _roof == "да" || _roof == "Нет" || _roof == "нет")
                {
                if (_roof == "Да" || _roof == "да") roof = true;
                else roof = false;
            }
            else throw new Exception("Неверно введено наличие крыши.");
                return new PassCar(company,model,year,roof);
        }
        public static ElecScooter CreateElecScooter()
        {
            string company, model;
            int year;
            bool seat = false;
            Console.Write("Введите производителя: ");
            company = Console.ReadLine();
            Console.Write("Введите модель: ");
            model = Console.ReadLine();
            Console.Write("Введите год выпуска(2000-2025): ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите есть ли у самоката сиденье(да/нет): ");
            string _seat = Console.ReadLine();
            if (_seat == "Да" || _seat == "да" || _seat == "Нет" || _seat == "нет")
            {
                if (_seat == "Да" || _seat == "да") seat = true;
                else seat = false;

            }
            else throw new Exception("Неверно введено наличие сиденья.");
            return new ElecScooter(company, model, year, seat);
        }
        static int Main()
        {
            List<TransVehicle> transVehicles = new List<TransVehicle>();
            
            while (true)
            {
                
                PrintMenu();
                int choiсe = 0;
                if (!int.TryParse(Console.ReadLine(), out choiсe))
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 5");
                    continue;
                }
                Console.Clear();
                try
                {
                    switch (choiсe)
                    {
                        case 1:
                            {
                                TransVehicle transVehicle = CreateBaseVehicle();
                                transVehicles.Add(transVehicle);
                                Console.WriteLine("Базовый транспорт добавлен!");
                                break;
                            }
                        case 2:
                            {
                                PassCar passCar = CreatePassCar();
                                transVehicles.Add(passCar);
                                Console.WriteLine("Легковой автомобиль добавлен!");
                                break;
                            }
                        case 3:
                            {
                                ElecScooter elecScooter = CreateElecScooter();
                                transVehicles.Add(elecScooter);
                                Console.WriteLine("Электрический самокат добавлен!");
                                break;
                            }
                        case 4:
                            Console.WriteLine("Список устройств");
                            int index = 1;
                            foreach (TransVehicle transVehicle in transVehicles)
                            {
                                Console.WriteLine($"Устройство #{index++}");
                                transVehicle.Print();
                                Console.WriteLine();
                            }
                            break;
                        case 5:
                            transVehicles.Clear();
                            Console.WriteLine("Программа завершена. Память освобождена.");
                            return 0;
                        default:
                            {
                                Console.WriteLine("Неверный выбор. Попробуйте снова.");
                                break;
                            }
                    }
                }
                catch (Exception ex) { Console.WriteLine($"Ошибка: {ex.Message}"); }
            }
        }


    }
}