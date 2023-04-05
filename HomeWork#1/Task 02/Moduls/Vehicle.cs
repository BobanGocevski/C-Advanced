

namespace Task_02.Moduls
{
    public  abstract class Vehicle
    {
        public bool IsGasFull { get; internal set; }
        public bool IsBroken { get; internal set; }

        public abstract void Drive();
    }
}
