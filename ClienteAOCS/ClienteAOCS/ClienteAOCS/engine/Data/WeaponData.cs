using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClienteAOCS.engine.Data
{
    public class WeaponData
    {
        public static WeaponAnimData[] Weapons;
        public struct WeaponAnimData
        {
            public short[] WeaponWalk;
        }

        public static bool LoadWeapons()
        {
            short NumWeapons;
            FileStream fs = new FileStream("C:\\Users\\PC\\Desktop\\AOSuite\\ClienteAOCS\\ClienteAOCS\\ClienteAOCS\\bin\\x86\\init\\armas.ind", FileMode.Open);
            BinaryReader reader = new BinaryReader(fs);

            NumWeapons = reader.ReadInt16();

            Weapons = new WeaponAnimData[NumWeapons + 1];

            for (int i = 1; i <= NumWeapons; i++)
            {
                Weapons[i].WeaponWalk = new short[4];

                Weapons[i].WeaponWalk[0] = reader.ReadInt16();
                Weapons[i].WeaponWalk[1] = reader.ReadInt16();
                Weapons[i].WeaponWalk[2] = reader.ReadInt16();
                Weapons[i].WeaponWalk[3] = reader.ReadInt16();

            }

            return true;
        }
    }
}
