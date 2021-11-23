using System;

namespace Task3_3
{
    public class Airplane
    {
        private string name;
        private Wings wings;
        private Engine engine;
        private Chassis chassis;

        public Airplane(string name, Wings wings, Engine engine, Chassis chassis)
        {
            this.name = name;
            this.wings = wings;
            this.engine = engine;
            this.chassis = chassis;
        }
        private string route = null;


        public bool start_fly()
        {
            if (route == null)
                return false;
            else return true;
        }

        public void fly()
        {
            string n;
            if (start_fly() == false)
                n = "Полёт не состоялся!";
            else
                n = "Успешно!";
            Console.WriteLine(n);
        }

        public void set_route(string new_route)
        {
            route = new_route;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Wings wings1 = new Wings("Крылья1");
            Engine engine1 = new Engine("Двигатель1");
            Chassis chassis1 = new Chassis("Шасси1");
            Airplane plane1 = new Airplane("Ласотчка", wings1, engine1, chassis1);
            plane1.set_route("В Париж!");
            plane1.start_fly();
            plane1.fly();
            Console.WriteLine("n");
        }
    }
}
