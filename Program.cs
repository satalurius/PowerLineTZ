
using PowerLineTZ.Models;
using PowerLineTZ.Services;
using PowerLineTZ.View;

var cars = new List<Car>
{
    new PassangerCar(5.0, 30, 130, new ValueCheckerService(), 10),
    new Truck(10.0, 500, 70, new ValueCheckerService(), 600, 200),
    new SportCar(8.0, 20, 300, new ValueCheckerService())
};

try
{
    var displayView = new DisplayView(cars);

    displayView.DisplayFuel();
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.ToString());
}

