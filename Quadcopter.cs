using System;
using System.Collections.Generic;
using System.Threading;

namespace OtusHomeWork_5
{
    public class Quadcopter : IFlyingRobot , IChargeable
    {
        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }
        public List<string> GetComponents()
        {
            var _components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };

            return _components;
        }
        public string GetInfo()
        {
            var info = "Robot";
            return info;
        }
    }
}
