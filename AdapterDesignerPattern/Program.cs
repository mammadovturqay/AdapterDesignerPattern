public interface ICar
{
    void Suretlen();
    void Tormuzla();
}

public class AdiCar : ICar
{
    public void Suretlen()
    {
        Console.WriteLine("Masin suretlendi ");
    }

    public void Tormuzla()
    {
        Console.WriteLine("Masin tormuzladi ");
    }
}

public interface IElectricCar
{
    void Suret();
    void Yavasla();
}

public class ElectricCarAdapter : IElectricCar
{
    private readonly ICar regularCar;

    public ElectricCarAdapter(ICar car)
    {
        regularCar = car;
    }

    public void Suret()
    {
        regularCar.Suretlen();
    }

    public void Yavasla()
    {
        regularCar.Tormuzla();
    }
}

class Program
{
    static void Main()
    {
        ICar regularCar = new AdiCar();

        IElectricCar electricCar = new ElectricCarAdapter(regularCar);

        electricCar.Suret();
        electricCar.Yavasla();
    }
}
