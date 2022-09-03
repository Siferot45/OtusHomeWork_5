using System;

namespace OtusHomeWork_5
{
     class Program
    {
        static void Main(string[] args)
        {
            Quadcopter quadcopter = new();

            quadcopter.Charge();

            quadcopter.GetComponents();
           
            // Преведение к IRobot.
            var robot = quadcopter as IRobot;
            Console.WriteLine(robot.GetRobotType());
            // Преведение к IFlyingRobot
            var flyingRobot = quadcopter as IFlyingRobot;
            Console.WriteLine(flyingRobot.GetRobotType());
        }
    }
}
