using PowerLineTZ.Services;

namespace PowerLineTZ.Models
{
    public class SportCar : Car
    {
        private readonly IValueCheckerService valueCheckerService;
        #region Properties
        #endregion

        #region Ctors
        public SportCar(double averageFuel, int fuelVolume, int speed, IValueCheckerService valueCheckerService) : base(averageFuel, fuelVolume, speed, valueCheckerService)
        {
            this.valueCheckerService = valueCheckerService;
        }
        #endregion

        #region Methods
        #endregion
    }
}
