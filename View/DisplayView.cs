using PowerLineTZ.Models;

namespace PowerLineTZ.View
{
    public class DisplayView
    {
        private List<Car> cars;

        public DisplayView(List<Car> cars)
        {
            this.cars = cars;
        }

        public void DisplayFuel()
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"Current fuel is {Math.Round(car.CalcDistanceByFuel(), 2)}");
            }
        }

    }
}
