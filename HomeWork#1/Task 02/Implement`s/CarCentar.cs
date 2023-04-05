using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_02.Interfaces;
using Task_02.Moduls;

namespace Task_02.Implement_s
{
    class CarCenter : ICarWash, IGasPump, IRepairService
    {
        private CarWash carWash;
        private GasPump gasPump;
        private RepairService repairService;

        public CarCenter()
        {
            this.carWash = new CarWash();
            this.gasPump = new GasPump();
            this.repairService = new RepairService();
        }

        public void WashCar(Car car)
        {
            this.carWash.WashCar(car);
        }

        public void WashTrailer(Truck truck)
        {
            this.carWash.WashTrailer(truck);
        }

        public void PumpGas(Vehicle vehicle)
        {
            this.gasPump.PumpGas(vehicle);
        }

        public void CheckVehicle(Vehicle vehicle)
        {
            this.repairService.CheckVehicle(vehicle);
        }

        public void FixVehicle(Vehicle vehicle)
        {
            this.repairService.FixVehicle(vehicle);
        }
    }
}