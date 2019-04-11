using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Race
{
    abstract class Car
    {
        public delegate void Message();
        public event Message Notification;
        public void Winner(string name)
        {
            Console.WriteLine($"{name} приехал к финишу");
        }
        public int Speed(Random rnd, int minSpeed, int maxSpeed)
        {
            int speed = rnd.Next(minSpeed, maxSpeed);
            return speed;
        }
        public void Start(string name, int speed)
        {
            int distance = 0;
            Notification += () => Winner(name);
            for (int i = 0; i <= 100; i += 10)
            {
                distance += 10;
                Thread.Sleep(speed);
                if (distance == 100)
                {
                    Notification();
                }

            }
        }
    }
}
