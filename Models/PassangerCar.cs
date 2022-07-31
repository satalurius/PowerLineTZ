using PowerLineTZ.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLineTZ.Models
{
    public class PassangerCar : Car
    {
        private readonly IValueCheckerService valueCheckerService;

        private readonly int allowedPassangers = 4;
        private readonly double fuelDecreaseByOnePassanger = 0.06;
        #region Properties
        private int passangers;

        public int Passangers
        {
            get => passangers;
            private set
            {
                passangers = valueCheckerService.SetValueOfPassangersIfGreaterThenZero(value, allowedPassangers);
            }
        }

        #endregion

        #region Ctors
        public PassangerCar(double averageFuel, int fuelVolume, int speed, IValueCheckerService valueCheckerService, int passangers) : base(averageFuel, fuelVolume, speed, valueCheckerService)
        {
            this.valueCheckerService = valueCheckerService;

            this.passangers = passangers;
        }
        #endregion

        #region Methods
        public override double CalcDistanceByFuel()
        {
            return base.CalcDistanceByFuel() * (1 - fuelDecreaseByOnePassanger * passangers);
        }
        #endregion

    }
}
