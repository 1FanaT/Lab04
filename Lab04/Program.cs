using System;

namespace lab4
{
    class Program
    {
        public static void Main(string[] args)
        {
            var plane = new Airplane("МС-21");
            var en = new Engine("Двигун: Турбовентиляторний двигун 870 км/год");
            var wi = new Wing("Крила: з полімерних композитних матеріалів, розмах 36 м");
            var cha = new Chassis("Шасі: звичайні!");
            plane.AddRoute("Київ - Чехiя");
            plane.DisplayRoute();
            plane.Fly();
        }
    }


    class Airplane
    {
        public Airplane(string name)
        {
            this.name = name;
        }
        private static string route;
        private string name;
        private Engine engine;
        private Chassis chassis;
        private Wing wings;
        public void setWing(Wing wings)
        {
            this.wings = wings;
        }

        public void setChassis(Chassis chassis)
        {
            this.chassis = chassis;
        }

        public void setEngine(Engine engine)
        {
            this.engine = engine;
        }
        private void StartFlight()
        {
            Console.WriteLine("Лiтак летить");
        }
        public bool Fly()
        {
            if (route == null) return false;
            StartFlight();
            return true;
        }

        public void AddRoute(string newRoute)
        {
            route = newRoute;
        }
        public void DisplayRoute()
        {
            Console.WriteLine(route);
        }
    }
    class Wing
    {
        private string name;
        public Wing(string name)
        {
            this.name = name;
        }
        public string getInfo()
        {
            return name;
        }
    }
    class Chassis
    {
        private string name;
        public Chassis(string name)
        {
            this.name = name;
        }
        public string getInfo()
        {
            return name;
        }
    }
    class Engine
    {
        private string name;
        public Engine(string name)
        {
            this.name = name;
        }
        public string getInfo()
        {
            return name;
        }
    }
}