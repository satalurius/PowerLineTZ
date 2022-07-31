namespace PowerLineTZ.Services
{
    public interface IValueCheckerService
    {
        double SetValueIfGreaterThenZero(double value);
        int SetValueIfGreaterThenZero(int value);
        int SetValueOfPassangersIfGreaterThenZero(int value, int allowedPassangers);
        double SetCapacityIfGreaterThenMaxCapacity(double value, double maxCapacity);
    }
}
