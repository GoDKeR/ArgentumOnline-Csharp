using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClienteAOCS.engine.Data
{
    public class HeadData
    {

        public static tHead[] Heads;

        public struct tHead
        {
           public short[] Head;
        }


        public static bool LoadHead()
        {
            short numHeads;
            FileStream fs = new FileStream("C:\\Users\\PC\\Desktop\\AOSuite\\ClienteAOCS\\ClienteAOCS\\ClienteAOCS\\bin\\x86\\init\\Cabezas.ind", FileMode.Open);
            BinaryReader reader = new BinaryReader(fs);

            numHeads = reader.ReadInt16();

            Heads = new tHead[numHeads + 1];

            for (int i = 1; i <= numHeads; i++)
            {
                Heads[i].Head = new short[4];
                Heads[i].Head[0] = reader.ReadInt16();
                Heads[i].Head[1] = reader.ReadInt16();
                Heads[i].Head[2] = reader.ReadInt16();
                Heads[i].Head[3] = reader.ReadInt16();
            }
            return true;
        }
    }
}
