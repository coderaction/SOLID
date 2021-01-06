namespace CE.SOLID.OCP.GOOD
{
    public class GoodExample
    {
        public abstract class Vehicle
        {
            public abstract void Produce();
        }
 
        public class Car : Vehicle
        {
            public override void Produce()
            {
                //Car Produced
            }
        }
     
        public class Bus : Vehicle
        {
            public override void Produce()
            {
                //Bus Produced
            }
        }
 
        public class Truck: Vehicle
        {
            public override void Produce()
            {
                //Truck Produced
            }
        }

        private void Main()
        {
            VehicleFactory vf1 = new VehicleFactory();
            vf1.ProduceVehicle(new Car());
 
            VehicleFactory vf2 = new VehicleFactory();
            vf2.ProduceVehicle(new Bus());
 
            VehicleFactory vf3 = new VehicleFactory();
            vf3.ProduceVehicle(new Truck());
        }
    }
    
    public class VehicleFactory
    {
        public void ProduceVehicle(GoodExample.Vehicle vehicle)
        {
            vehicle.Produce();
        }
    }
}