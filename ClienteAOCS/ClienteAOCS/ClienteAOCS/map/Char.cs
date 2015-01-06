using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteAOCS.engine;
using ClienteAOCS.engine.Data;
using ClienteAOCS.map;

namespace ClienteAOCS.map
{
    public static class Char
    {

        public static tChar[] charList;
        public static int LastChar;
        public static int NumChars;

        public struct tChar
        {
            public byte Active;
            public TileEngine.E_Heading Heading;
            public TileEngine.Position Pos;

            public short iHead, iBody;

            public BodyData.tBodyData Body;
            public HeadData.tHead Head;
            public HelmetData.tHelmet Casco;
            public WeaponData.WeaponAnimData Arma;
            public ShieldData.ShieldAnimData Escudo;

            public bool UsandoArma;

            public Grh fX;
            public short FxIndex;

            public byte Criminal;
            public bool Atacable;

            public String nombre;

            public short ScrollDirectionX, ScrollDirectionY;

            public byte Moving;
            public Single MoveOffsetX, MoveOffsetY;

            public bool pie, muerto, invisible;

            public byte priv;
        }

        public static void MakeChar(short CharIndex, short Body, short Head, TileEngine.E_Heading Heading, short X, short Y, short Arma, short Escudo, short Casco)
        {
            if (CharIndex > LastChar)
                LastChar = CharIndex;

            Array.Resize(ref charList, LastChar + 1);

            if (charList[CharIndex].Active == 0)
                NumChars++;

            if (Arma == 0)
                Arma = 2;

            if (Escudo == 0)
                Escudo = 2;

            if (Casco == 0)
                Casco = 2;

            charList[CharIndex].iBody = Body;
            charList[CharIndex].iHead = Head;
            charList[CharIndex].Head = HeadData.Heads[Head];
            charList[CharIndex].Body = BodyData.Bodys[Body];

            charList[CharIndex].Arma = WeaponData.Weapons[Arma];
            charList[CharIndex].Escudo = ShieldData.Shields[Escudo];
            charList[CharIndex].Casco = HelmetData.Helmets[Casco];

            charList[CharIndex].Heading = Heading;

            charList[CharIndex].Moving = 0;

            charList[CharIndex].MoveOffsetX = 0.0f;
            charList[CharIndex].MoveOffsetY = 0.0f;

            charList[CharIndex].Pos.X = X;
            charList[CharIndex].Pos.Y = Y;

            charList[CharIndex].Active = 1;

            Map.MapData[X, Y].CharIndex = CharIndex;

        }

        public static void ResetCharInfo(short CharIndex)
        {
            charList[CharIndex].Active = 0;
            charList[CharIndex].Criminal = 0;
            charList[CharIndex].Atacable = false;
            charList[CharIndex].FxIndex = 0;
            charList[CharIndex].invisible = false;
            charList[CharIndex].Moving = 0;
            charList[CharIndex].muerto = false;
            charList[CharIndex].nombre = null;
            charList[CharIndex].pie = false;
            charList[CharIndex].Pos.X = 0;
            charList[CharIndex].Pos.Y = 0;
            charList[CharIndex].UsandoArma = false;
        }

        public static void EraseChar(short CharIndex)
        {
            charList[CharIndex].Active = 0;

            if (CharIndex == LastChar)
            {
                while (charList[LastChar].Active != 1)
                {
                    LastChar--;
                    if (LastChar == 0) break;
                }

                Map.MapData[charList[CharIndex].Pos.X, charList[CharIndex].Pos.Y].CharIndex = 0;

                //Dialogs line

                ResetCharInfo(CharIndex);

                NumChars--;
            }
        }
    }
}
