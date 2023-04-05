using Task_02.Implement_s;
using Task_02.Moduls;

CarCenter carCenter = new CarCenter();

Car car = new Car();
carCenter.WashCar(car);
carCenter.PumpGas(car);
carCenter.CheckVehicle(car);
car.Drive();

Truck truck = new Truck();
carCenter.WashTrailer(truck);
carCenter.PumpGas(truck);
carCenter.CheckVehicle(truck);