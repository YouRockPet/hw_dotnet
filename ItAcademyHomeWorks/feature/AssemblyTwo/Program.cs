using System;

namespace AssemblyTwo
{
    class Program
    {
        class SportBike : MotorcyclePublic
        {

        }

        class Bike : MotorcycleInternal
        {

        }
        static void Main(string[] args)
        {
            SportBike Kavasaki = new SportBike();
            Kavasaki.EngineTypePublic();
            Console.WriteLine(Kavasaki.MaxSpeedPublic);
            Console.WriteLine(Kavasaki.VolumePublic);
            Console.WriteLine(Kavasaki.TurbinePublic);

            Bike KavasakiNinja = new Bike();
            KavasakiNinja.EngineTypeInternal();
            Console.WriteLine(KavasakiNinja.MaxSpeedInternal);
            Console.WriteLine(KavasakiNinja.VolumeInternal);
            Console.WriteLine(KavasakiNinja.TurbineInternal);
        }
    }
}
