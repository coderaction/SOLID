namespace CE.SOLID.LSP.GOOD
{
    public class GoodExample
    {
        public void Bad()
        {
            Ferrari f= new Ferrari();
            f.Run();
            f.OpenAirConditioning();
            
            Murat131 m = new Murat131();
            m.Run();
        }
    }
    
    public abstract class Car
    {
        public string Run()
        {
            return "Araba Calistirildi";
        }
    }
    
    public interface IAirConditionable
    {
        string OpenAirConditioning();
    }
    
    
    public class Ferrari: Car,IAirConditionable
    {
        public string OpenAirConditioning()
        {
            return "Klima calistirildi";
        }
    }
    
    public class Murat131: Car
    {
       
    }
}