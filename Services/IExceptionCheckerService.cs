namespace PowerLineTZ.Services
{
    interface IExceptionCheckerService
    {
        double SetValueIfGreaterThenZero(double value);
        int SetValueIfGreaterThenZero(int value);
    }
}
