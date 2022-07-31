using PowerLineTZ.Services;

namespace PowerLineTZ.Models
{
    public class Truck : Car
    {
        private readonly IValueCheckerService valueCheckerService;

        private readonly double capacityDecrease = 0.04;
        private readonly double maxCapacity;
        private readonly double capacityDecreaser = 200;

        #region Properties
        private double currentCapacity;
        public double CurrentCapacity
        {
            get => currentCapacity;
            private set
            {
                currentCapacity = valueCheckerService.SetCapacityIfGreaterThenMaxCapacity(value, maxCapacity);
            }
        }
        #endregion

        #region Ctors
        public Truck(double averageFuel, int fuelVolume, int speed, IValueCheckerService valueCheckerService, double maxCapacity, double currentCapacity) : base(averageFuel, fuelVolume, speed, valueCheckerService)
        {
            this.valueCheckerService = valueCheckerService;

            this.maxCapacity = maxCapacity;
            this.currentCapacity = currentCapacity;
        }
        #endregion

        #region Methods
        public override double CalcDistanceByFuel()
        {
            return base.CalcDistanceByFuel() * (1 - currentCapacity * (capacityDecrease / capacityDecreaser));
        }
        #endregion
    }
}
