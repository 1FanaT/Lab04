using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pr = new Parallelepiped(4.8, 3.6, 7.2);
            Console.WriteLine(pr.ToString());
            var ball = new Ball(5);
            Console.WriteLine(ball.ToString());
        }
    }
    abstract class GeometricSolid
    {
        public string Type { get; }
        public double Square { get; } = 0.0;
        public double Volume { get; } = 0.0;
        protected GeometricSolid(string type, double square, double volume)
           => (Type, Square, Volume) = (type, square, volume);

        public override string ToString() => string.Format($"Об'єкт: {Type}, Площа = {Square:0.00} кв.од., Обсяг = {Volume:0.00} кв.од.");
    }

    class Parallelepiped : GeometricSolid
    {
        public Parallelepiped(double a, double b, double c)
            : base("Паралелепіпед", 2 * (a * b + a * c + b * c), a * b * c)
        {
        }
    }

    class Ball : GeometricSolid
    {
        public Ball(double r)
            : base("Куля", 4 * 3.1415925 * r * r, 4.0 / 3 * (Math.PI * Math.Pow(r, 3)))
        {
        }
    }