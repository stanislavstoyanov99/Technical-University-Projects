namespace EnginesLibrary
{
    public interface IFunctionable
    {
        void RotateClockwize(int voltage, int rpm);
        void RotateCounterClockwize(int voltage, int rpm);
        void CalculateKPD(double capacity, int voltage, int amperage);
    }
}
