
namespace PowerLineTZ.Services
{
    public class ExceptionCheckerService : IExceptionCheckerService
    {
        public double SetValueIfGreaterThenZero(double value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Value must be greater then zero");
            else 
                return value;
        }

        public int SetValueIfGreaterThenZero(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Value must be greater then zero");
            else
                return value;
        }
    }
}
