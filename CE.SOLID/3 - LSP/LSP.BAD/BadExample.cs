namespace CE.SOLID.LSP.BAD
{
    public class BadExample
    {
        public void Bad()
        {
            Car car =new Ferrari();
            
            car.Run();
            car.OpenAirConditioning();
            
            
            car = new Murat131();
            
            car.Run();
            //Exception
            car.OpenAirConditioning();
        }
    }
    
    public abstract class Car
    {
        public string Run()
        {
            return "Araba Calistirildi";
        }

        public abstract string OpenAirConditioning();
    }
    

    public class Ferrari: Car
    {
        public override string OpenAirConditioning()
        {
            return "Klima calistirildi";
        }
    }
    
    public class Murat131: Car
    {
        public override string OpenAirConditioning()
        {
            throw new System.NotImplementedException();
        }
    }
}