using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ClienteAOCS.engine.Data
{
    public class HelmetData
    {
        public static tHelmet[] Helmets;

        public struct tHelmet
        {
            public short[] Head;
        }
        public static bool LoadHelmets()
        {
            short numHelmets;
            FileStream fs = new FileStream("C:\\Users\\PC\\Desktop\\AOSuite\\ClienteAOCS\\ClienteAOCS\\ClienteAOCS\\bin\\x86\\init\\Cascos.ind", FileMode.Open);
            BinaryReader reader = new BinaryReader(fs);

            numHelmets = reader.ReadInt16();

            Helmets = new tHelmet[numHelmets + 1];

            for (int i = 1; i <= numHelmets; i++)
            {
                Helmets[i].Head = new short[4];
                Helmets[i].Head[0] = reader.ReadInt16();
                Helmets[i].Head[1] = reader.ReadInt16();
                Helmets[i].Head[2] = reader.ReadInt16();
                Helmets[i].Head[3] = reader.ReadInt16();
            }
            return true;

        }
    }
}
