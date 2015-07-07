using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task22 {
    class Program {
        static void Main(string[] args) {
            //  Заполняем коллекцию транспортных средств экземплярами класса
            var vehicles = new List<Vehicle> {
                new Vehicle { Type = VehicleType.Car, Name = "Ford Sierra", Age = 20, MaxSpeed = 220, Mileage = 938215 },
                new Vehicle { Type = VehicleType.Car, Name = "Лада Гранта", Age = 1, MaxSpeed = 190, Mileage = 5856 },
                new Vehicle { Type = VehicleType.Motorbike, Name = "Honda Shadow", Age = 18, MaxSpeed = 160, Mileage = 13486 },
                new Vehicle { Type = VehicleType.Car, Name = "BMW X5", Age = 7, MaxSpeed = 220, Mileage = 85671 },
                new Vehicle { Type = VehicleType.Bicycle, Name = "Cube Analog", Age = 3, MaxSpeed = 40, Mileage = 28612 },
            };

            Console.WriteLine("Все траспортные средства в списке:");
            foreach (var car in vehicles) {
                Console.WriteLine("> {0} {1} (возраст: {2} лет, Пробег: {4} км, макс. скорость: {3} км/ч)", car.TypeToString(), car.Name, car.Age, car.MaxSpeed, car.Mileage);
            }

            Console.WriteLine();
            Console.WriteLine("Выводим все машины в списке транспортных средств (VehicleType = Car):");
            foreach (var car in vehicles.Where(t => t.Type == VehicleType.Car)) {
                Console.WriteLine("> {0} {1} (возраст: {2} лет, Пробег: {4} км, макс. скорость: {3} км/ч)", car.TypeToString(), car.Name, car.Age, car.MaxSpeed, car.Mileage);
            }

            Console.WriteLine();
            Console.WriteLine("Выводим все транспортные средства с сортировкой по пробегу, по возрастанию:");
            foreach (var car in vehicles.OrderBy(t => t.Mileage)) {
                Console.WriteLine("> {0} {1} (возраст: {2} лет, Пробег: {4} км, макс. скорость: {3} км/ч)", car.TypeToString(), car.Name, car.Age, car.MaxSpeed, car.Mileage);
            }

            //  Добавляем в конец списка транспортное средство
            var newVehicle = new Vehicle { Type = VehicleType.Motorbike, Name = "Yamaha YBR 125", Age = 6, MaxSpeed = 120, Mileage = 23697 };
            vehicles.Add(newVehicle);
            Console.WriteLine();
            Console.WriteLine("Добавили в конец списка транспортное средство:");
            foreach (var car in vehicles) {
                Console.ForegroundColor = newVehicle.Equals(car) ? ConsoleColor.White : ConsoleColor.Gray;
                Console.WriteLine("> {0} {1} (возраст: {2} лет, Пробег: {4} км, макс. скорость: {3} км/ч)", car.TypeToString(), car.Name, car.Age, car.MaxSpeed, car.Mileage);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            //  Добавляем в конец списка транспортное средство
            newVehicle = new Vehicle { Type = VehicleType.Motorbike, Name = "CF Moto 155", Age = 1, MaxSpeed = 120, Mileage = 3497 };
            vehicles.Insert(1, newVehicle);
            Console.WriteLine();
            Console.WriteLine("Вставили во вторую позицию списка транспортное средство:");
            foreach (var car in vehicles) {
                Console.ForegroundColor = newVehicle.Equals(car) ? ConsoleColor.White : ConsoleColor.Gray;
                Console.WriteLine("> {0} {1} (возраст: {2} лет, Пробег: {4} км, макс. скорость: {3} км/ч)", car.TypeToString(), car.Name, car.Age, car.MaxSpeed, car.Mileage);
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            //  Удаляем ранее добавленные транспортные средства из списка
            vehicles.RemoveAll(t => t.Name == "Yamaha YBR 125" || t.Name == "CF Moto 155");
            Console.WriteLine();
            Console.WriteLine("Удалили из списка Ямаху и Китайца:");
            foreach (var car in vehicles) {
                Console.WriteLine("> {0} {1} (возраст: {2} лет, Пробег: {4} км, макс. скорость: {3} км/ч)", car.TypeToString(), car.Name, car.Age, car.MaxSpeed, car.Mileage);
            }

            //  Удаляем ранее добавленные транспортные средства из списка
            var foundVehicle = vehicles.FirstOrDefault(t => t.Name == "Ford Sierra");
            Console.WriteLine();
            Console.WriteLine("Найденный в списке автомобиль по полю Name и значению 'Ford Sierra':");
            Console.WriteLine("{0} {1} (возраст: {2} лет, Пробег: {4} км, макс. скорость: {3} км/ч)", foundVehicle.TypeToString(), foundVehicle.Name, foundVehicle.Age, foundVehicle.MaxSpeed, foundVehicle.Mileage);

            //  Список очищен
            vehicles.Clear();
            Console.WriteLine();
            Console.WriteLine("Список транспортных средств очищен методом vehicles.Clear(){0}Кол-во ТС в списке: {1}", Environment.NewLine, vehicles.Count);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую кнопку для завершения программы...");
            Console.ReadKey();
        }
    }
}
