using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClienteAOCS.engine.Data
{
    public class BodyData
    {

        public static tBodyData[] Bodys;

        public struct tBodyData
        {
            public short[] Walk;
            public tHeadOffset HeadOffset;
            public struct tHeadOffset
            {
                public short x, y;
            }
        }

        public static bool LoadBody()
        {
            short numCuerpos;

            FileStream fs = new FileStream("C:\\Users\\PC\\Desktop\\AOSuite\\ClienteAOCS\\ClienteAOCS\\ClienteAOCS\\bin\\x86\\init\\Personajes.ind", FileMode.Open);
            BinaryReader reader = new BinaryReader(fs);

            numCuerpos = reader.ReadInt16();

            Bodys = new tBodyData[numCuerpos + 1];

            for (int i = 1; i <=numCuerpos ; i++)
            {
                Bodys[i].Walk = new short[4];
                Bodys[i].Walk[0] = reader.ReadInt16();
                Bodys[i].Walk[1] = reader.ReadInt16();
                Bodys[i].Walk[2] = reader.ReadInt16();
                Bodys[i].Walk[3] = reader.ReadInt16();

                Bodys[i].HeadOffset.x = reader.ReadInt16();
                Bodys[i].HeadOffset.y = reader.ReadInt16();
            }

            return true;
        }
    }
}
