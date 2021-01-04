using System;
using CE.SOLID.OCP.BAD.BadExample;

namespace CE.SOLID.OCP.BAD
{
    namespace BadExample
    {
        public class Vehicle
        {
            public VehicleType VType { get; set; }
        }
 
        public enum VehicleType
        {
            Car,
            Bus
        }
 
        public class Car : Vehicle
        {
            public Car()
            {
                this.VType = VehicleType.Car;
            }
        }
 
        public class Bus : Vehicle
        {
            public Bus()
            {
                this.VType = VehicleType.Bus;
            }
        }
    }
    
    
    public class VehicleFactory
    {
        public void ProduceVehicle(Vehicle vehicle)
        {
            switch (vehicle.VType)
            {
                case VehicleType.Car:
                    ProduceCar((Car)vehicle);
                    break;
                case VehicleType.Bus:
                    ProduceBus((Bus)vehicle);
                    break;
            }
        }
 
        private void ProduceCar(Car car)
        {
            Console.WriteLine("Car Produced\n");
        }
 
        private void ProduceBus(Bus car)
        {
            Console.WriteLine("Bus Produced\n");
        }

        private void Main()
        {
            
            VehicleFactory vf1 = new VehicleFactory();
            vf1.ProduceVehicle(new Car());
  
            VehicleFactory vf2 = new VehicleFactory();
            vf2.ProduceVehicle(new Bus());
        }
    }

}