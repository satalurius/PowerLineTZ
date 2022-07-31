
namespace PowerLineTZ.Services
{
    public class ValueCheckerService : IValueCheckerService
    {
        public double SetValueIfGreaterThenZero(double value)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("Value must be greater then zero");

            return value;
        }

        public int SetValueIfGreaterThenZero(int value)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("Value must be greater then zero");

            return value;
        }

        public int SetValueOfPassangersIfGreaterThenZero(int value, int allowedPassangers)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("Value must be greater then zero");
            else if (value > allowedPassangers)
                throw new ArgumentOutOfRangeException($"Value is greater then {nameof(allowedPassangers)}");

            return value;
        }
        public double SetCapacityIfGreaterThenMaxCapacity(double value, double maxCapacity)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("Value must be greater then zero");
            else if (value > maxCapacity)
                throw new ArgumentOutOfRangeException($"Value is greater than {nameof(maxCapacity)}");

            return value;
        }
    }
}
