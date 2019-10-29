using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class MotorcyclePublic
    {
        public const string NamePublic = "Kawasaki Ninja";
        public ushort MaxSpeedPublic = 280;
        public ushort VolumePublic = 600;
        public bool TurbinePublic = true;

        public void EngineTypePublic()
        {
            Console.WriteLine("4-ох тактый");
        }
              

    }

    class MotorcycleInternal
    {
        internal const string NameInternal = "Kawasaki Ninja";
        internal ushort MaxSpeedInternal = 280;
        internal ushort VolumeInternal = 600;
        internal bool TurbineInternal = true;

        internal void EngineTypeInternal()
        {
            Console.WriteLine("4-ох тактый");
        }

    }
}
