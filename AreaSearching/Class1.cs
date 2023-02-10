using System;
using System.IO;
using System.Collections.Generic;


namespace AreaSearching
{
    public class Class1
    {
        Figure figure = new Circle();
        
    }

    public abstract class Figure
    {
        public abstract int AreaValue { get; protected set; }
        public abstract int CalculatedArea();
    }
    public class Circle : Figure
    {
        public override int AreaValue { get; protected set; }
        public override int CalculatedArea()
        {
            return AreaValue;
        }
    }



    public class Triangle : Figure
    {
        public override int AreaValue { get; protected set; }
        public override int CalculatedArea()
        {
            return AreaValue;
        }
        
        
    }

    
    //Каким образом в этом узле сделать собственную реализацию для каждого производного класса?
















    public class MainClassExample
    {
        //Главный класс, главный метод - отсюда стартует прога
        private int _averageSpeed { get; set; }
        private string? _model { get; set; }
        private Vehicle? _vehicle { get; set; }
        public MainClassExample(int averageSpeed, string model)
        {
            //Перегрузка конструктора в зависимости от принимаемых параметров пользователя
            //Присваеваем свойствам полученных параметров и создаем экземпляр нужного типа
            //Присваеваем объекту базового типа экземпляра нужного типа
            //Вызываем метод базового класса из конструктора, передавая ему объект абстрактного типа, а метод в свою очередь возвращает значение пользователю
            _averageSpeed = averageSpeed;
            _model = model;
            Vehicle transport = new ;
            switch (transport)
            {
                case Car car:
                    break;
                case Train train:
                    break;
                case Bicycle bicycle:
                    break;
                case Motocycle motocycle:
                    break;
                default:
                    break;
            }
        }


        public int GetMaxSpeed(Vehicle vehicle)
        {
            
            int maxSpeed = vehicle.AverageSpeed;
            return maxSpeed;
        }
    }
    public abstract class Vehicle //имею в виду транспортное средство
    {
        public abstract int AverageSpeed { get; protected set; }
        public abstract void Move();
    }

    public class Car : Vehicle
    {
        public override int AverageSpeed { get; protected set; }
        public Car(int averageSpeed)
        {
            AverageSpeed = averageSpeed;
        }
        public override void Move()
        {
            Console.WriteLine($"Передвигается по асфальту со скоростью {AverageSpeed}");
        }
    }
    public class Train : Vehicle
    {
        public override int AverageSpeed { get; protected set; }
        public Train(int averageSpeed)
        {
            AverageSpeed = averageSpeed;
        }
        public override void Move()
        {
            //другая реализация по сравнению с классом Car
            Console.WriteLine($"Передвигается по железной дороге со скоростью {AverageSpeed}");
        }
    }
    //Это другой "узел". "Байки" могут быть разные, но все они являются в любом случае транспортом
    public abstract class Bike : Vehicle
    {
        public abstract string? BikeModel { get; protected set; }
    }
    public class Motocycle : Bike
    {
        public override string? BikeModel { get; protected set; }
        public override int AverageSpeed { get; protected set; }
        public Motocycle(int averageSpeed)
        {
            AverageSpeed = averageSpeed;
        }
        public override void Move()
        {
            Console.WriteLine($"Я мотоцикл и я делаю Врум-Врум на скорости {AverageSpeed}");
        }
    }
    public class Bicycle : Bike
    {
        public override string? BikeModel { get; protected set; }
        public override int AverageSpeed { get; protected set; }
        public Bicycle(int averageSpeed)
        {
            AverageSpeed = averageSpeed;
        }
        public override void Move()
        {
            Console.WriteLine($"Я велосипед и я еду на скорости {AverageSpeed}");
        }
    }



}