
namespace OtusHomeWork_5
{
    public interface IFlyingRobot : IRobot
    {
        new string GetRobotType() => "I am a flying robot.";
    }
}
