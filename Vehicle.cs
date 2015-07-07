using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task22 {
    /// <summary>
    /// Перечисление Типы транспортных средств
    /// </summary>
    public enum VehicleType {
        Car, Motorbike, Bicycle
    }

    /// <summary>
    /// Транспортное средство
    /// </summary>
    public class Vehicle {
        private VehicleType _type;  //  Вид транспортного средства
        private int _maxSpeed;  //  Максимальная скорость
        private int _age;   //  Срок эксплуатации
        private int _mileage;   //  Пробег

        /// <summary>
        /// Свойство Вид транспортного средства
        /// </summary>
        public VehicleType Type {
            get { return _type; }
            set { _type = value; }
        }
        /// <summary>
        /// Свойство Максимальная скорость
        /// </summary>
        public int MaxSpeed {
            get { return _maxSpeed; }
            set { _maxSpeed = value; }
        }
        /// <summary>
        /// Свойство Срок эксплуатации
        /// </summary>
        public int Age {
            get { return _age; }
            set { _age = value; }
        }
        /// <summary>
        /// Свойство Пробег
        /// </summary>
        public int Mileage {
            get { return _mileage; }
            set { _mileage = value; }
        }

        /// <summary>
        /// Автосвойство Название транспортного средства
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Метод возвращает русское название типа транспортного средства
        /// </summary>
        /// <returns></returns>
        public string TypeToString() {
            switch (Type) {
                case VehicleType.Car:
                    return "Автомобиль";
                case VehicleType.Motorbike:
                    return "Мотоцикл";
                case VehicleType.Bicycle:
                    return "Велосипед";
                default:
                    return "НЛО";
            }
        }
    }
}
