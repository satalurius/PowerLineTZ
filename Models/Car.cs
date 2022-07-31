using PowerLineTZ.Services;

namespace PowerLineTZ.Models
{
    public abstract class Car : ICar
    {
        private readonly IValueCheckerService valueCheckerService;

        #region Properties
        private double averageFuel;
        public double AverageFuel
        {
            get => averageFuel;
            private set
            {
                averageFuel = valueCheckerService.SetValueIfGreaterThenZero(value);
            }
        }

        private double fuelVolume;
        public double FuelVolume
        {
            get => fuelVolume;
            private set
            {
                fuelVolume = valueCheckerService.SetValueIfGreaterThenZero(value);
            }
        }

        private int speed;
        public int Speed
        {
            get => speed;
            private set
            {
                speed = valueCheckerService.SetValueIfGreaterThenZero(value);
            }
        }
        #endregion

        #region Ctors
        public Car(double averageFuel, int fuelVolume, int speed, IValueCheckerService valueCheckerService)
        {
            this.valueCheckerService = valueCheckerService ?? throw new ArgumentNullException(nameof(valueCheckerService));

            AverageFuel = averageFuel;
            FuelVolume = fuelVolume;
            Speed = speed;

        }
        #endregion

        #region Methods

        public virtual double CalcDistanceByFuel() => fuelVolume / averageFuel;

        public double CalcFuelCountByReserve(CarReserve carReserve)
        {
            // Предполагаем, что один пассажир, увеличивает расход топлива на 0,3.
            // Предполагаем, что 1 кг веса, увеличивает расход топлива на 0,01.
            var fuelAverageWithReserve = averageFuel + carReserve.BaggageWeight * 0.3 + carReserve.PassangerCount * 0.01;

            return Math.Round(fuelVolume / fuelAverageWithReserve, 2);
        }

        public double CalcDistanceTime(double distance) => distance / speed;
        #endregion
    }
}
