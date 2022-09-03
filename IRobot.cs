using System.Collections.Generic;

namespace OtusHomeWork_5
{
    public interface IRobot
    {
        string GetInfo();
        List<string> GetComponents();
        string GetRobotType() => "I am a simple robot.";

    }
}
