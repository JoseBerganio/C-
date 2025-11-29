// See https://aka.ms/new-console-template for more information
using InterfaceDemo.Classes;
using InterfaceDemo.Interfaces;


class Program
{
    public static void Main(string[] args)
    {
        IVehicle[] vehicle = new IVehicle[3];

        vehicle[0] = new Car("Mclaren");
        vehicle[1] = new Boat("Ship");
        vehicle[2] = new Airplane("Boeing 777");

        for (int i = 0; i < 3; i++)
        {
            vehicle[i].Start();
            vehicle[i].Drive();
            vehicle[i].Stop();
        }
    }
}