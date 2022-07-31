using PowerLineTZ.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLineTZ.Models
{
    public class Car
    {
        private readonly IExceptionCheckerService exceptionCheckerService;

        #region Properties
        private double averageFuel;
        public double AverageFuel
        {
            get => averageFuel; 
            private set 
            {
                averageFuel = exceptionCheckerService.SetValueIfGreaterThenZero(value);
            }
        }

        private int fuelVolume;
        public int FuelVolume
        {
            get => fuelVolume;
            private set 
            {
                fuelVolume = exceptionCheckerService.SetValueIfGreaterThenZero(value); 
            }
        }

        private int speed;
        public int Speed
        {
            get => speed;
            private set
            {
                speed = exceptionCheckerService.SetValueIfGreaterThenZero(value);
            }
        }
        #endregion

        #region Ctors
        public Car(double averageFuel, int fuelVolume, int speed)
        {
            AverageFuel = averageFuel;
            FuelVolume = fuelVolume;
            Speed = speed;

            exceptionCheckerService = new ExceptionCheckerService();
        }
        #endregion
    }
}
