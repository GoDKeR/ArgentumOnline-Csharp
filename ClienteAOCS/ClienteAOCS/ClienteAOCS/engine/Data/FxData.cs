using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClienteAOCS.engine.Data
{
    public class FxData

    {
        public static IndiceFx[] Fxs;

        public struct IndiceFx
        {
            public short Animacion;
            public short OffsetX, OffsetY;
        }

        public static bool LoadFxs()
        {
            short numFxs;

            FileStream fs = new FileStream("C:\\Users\\PC\\Desktop\\AOSuite\\ClienteAOCS\\ClienteAOCS\\ClienteAOCS\\bin\\x86\\init\\Fxs.ind", FileMode.Open);
            BinaryReader reader = new BinaryReader(fs);

            numFxs = reader.ReadInt16();

            Fxs = new IndiceFx[numFxs + 1];

            for (int i = 1; i <= numFxs; i++)
            {
                Fxs[i].Animacion = reader.ReadInt16();
                Fxs[i].OffsetX = reader.ReadInt16();
                Fxs[i].OffsetY = reader.ReadInt16();
            }

            return true;
        }
    }
}
