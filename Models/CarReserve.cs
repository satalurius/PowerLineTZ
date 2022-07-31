
using PowerLineTZ.Services;

namespace PowerLineTZ.Models
{
    public class CarReserve
    {
        private readonly IValueCheckerService exceptionCheckerService;

        #region Properties
        private int passangerCount;
        public int PassangerCount
        {
            get => passangerCount; 
            private set 
            { 
                passangerCount = exceptionCheckerService.SetValueIfGreaterThenZero(value);
            }
        }

        private double baggageWeight;
        public double BaggageWeight
        {
            get => baggageWeight;
            set
            {
                baggageWeight = exceptionCheckerService.SetValueIfGreaterThenZero(value);
            }
        }
        #endregion

        #region Ctors
        public CarReserve(int passangerCount, double baggageWeight, IValueCheckerService exceptionCheckerService)
        {
            this.passangerCount = passangerCount;
            this.baggageWeight = baggageWeight;

            this.exceptionCheckerService = exceptionCheckerService ?? throw new ArgumentNullException(nameof(exceptionCheckerService));
        }
        #endregion
    }
}
