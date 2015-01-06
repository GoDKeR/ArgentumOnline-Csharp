using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClienteAOCS.engine.Data
{
    public class ShieldData
    {
        public static ShieldAnimData[] Shields;

        public struct ShieldAnimData
        {
            public short[] ShieldWalk;

        }

        public static bool LoadShield()
        {
            short NumShields;
            FileStream fs = new FileStream("C:\\Users\\PC\\Desktop\\AOSuite\\ClienteAOCS\\ClienteAOCS\\ClienteAOCS\\bin\\x86\\init\\escudos.ind", FileMode.Open);
            BinaryReader reader = new BinaryReader(fs);

            NumShields = reader.ReadInt16();

            Shields = new ShieldAnimData[NumShields + 1];

            for (int i = 1; i <= NumShields; i++)
            {
                Shields[i].ShieldWalk = new short[4];

                Shields[i].ShieldWalk[0] = reader.ReadInt16();
                Shields[i].ShieldWalk[1] = reader.ReadInt16();
                Shields[i].ShieldWalk[2] = reader.ReadInt16();
                Shields[i].ShieldWalk[3] = reader.ReadInt16();
            }

            return true;
        }
    }
}
