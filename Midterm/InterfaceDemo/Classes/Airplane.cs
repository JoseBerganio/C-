using System.Runtime.CompilerServices;
using InterfaceDemo.Interfaces;

namespace InterfaceDemo.Classes
{
    class Airplane : IVehicle
    {
        private String Name;

        public Airplane(String name)
        {
            this.Name = name;
        }

        public void Drive()
        {
            Console.WriteLine(this.Name + " is Driving");
        }
        public void Start()
        {
            Console.WriteLine(this.Name+ " is Starting");
        }
        public void Stop()
        {
            Console.WriteLine(this.Name+ " is stopping");
        }
    }
}