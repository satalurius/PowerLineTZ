namespace PowerLineTZ.Models
{
    interface ICar
    {
        double CalcDistanceByFuel();
        double CalcFuelCountByReserve(CarReserve carReserve);
        double CalcDistanceTime(double distance);
    }
}
