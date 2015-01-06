using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClienteAOCS.engine;
using ClienteAOCS.engine.Data;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace ClienteAOCS.map
{
    public static class Map
    {

        public static short minY, maxY, minX, maxX;
        public static short ScreenMinY, ScreenMinX, ScreenMaxY, ScreenMaxX;
        public static short ScreenX, ScreenY;
        public static short LastTileX, LastTileY;

        public static tMapInfo MapInfo;
        public static tMapBlock[,] MapData;

        public static tTileLayer[] Tiles;

        public struct tTile
        {
            public byte TileX;
            public byte TileY;
            public short PixelPosX;
            public short PixelPosY;
        }

        public struct tTileLayer
        {
            public tTile[] Tile;
            public short NumTiles;
        }

        public struct tMapBlock
        {
            public Grh[] Graphic;
            public Grh ObjGrh;
            public short CharIndex;
            public short NpcIndex;
            public tObj ObjInfo;
            public tWorldPos TileExit;
            public byte Blocked;
            public short Trigger;
        }

        public struct tObj
        {
            public short ObjIndex;
            public short Amount;
        }

        public struct tWorldPos
        {
            public short Map;
            public short X;
            public short Y;
        }

        public struct tMapInfo
        {
            public String Music;
            public String Name;
            public tWorldPos StartPos;
            public short Version;

        }

        public static void LoadMap(short Map)
        {
            int x, y;
            byte ByFlags;

            FileStream fs = new FileStream("C:\\Users\\PC\\Desktop\\AOSuite\\ClienteAOCS\\ClienteAOCS\\ClienteAOCS\\bin\\x86\\maps\\Mapa" + Map + ".map",FileMode.Open);
            BinaryReader reader = new BinaryReader(fs);

            MapInfo.Version = reader.ReadInt16();

            MapData = new tMapBlock[101, 101];
            reader.ReadBytes(255);
            reader.ReadInt32();
            reader.ReadInt32();

            reader.ReadDouble();

            for (y = 1; y <= 100; y++)
            {
                for (x = 1; x <= 100; x++)
                {

                    ByFlags = reader.ReadByte();
                    MapData[x, y].Blocked = (byte)(ByFlags & 1);

                    MapData[x, y].Graphic = new Grh[5];
                    MapData[x, y].Graphic[1] = new Grh(reader.ReadInt16());

                    if ((ByFlags & 2)>0)
                        MapData[x, y].Graphic[2] = new Grh(reader.ReadInt16());
                    else
                        MapData[x, y].Graphic[2] = new Grh();

                    if ((ByFlags & 4) > 0)
                        MapData[x, y].Graphic[3] = new Grh(reader.ReadInt16());
                    else
                        MapData[x, y].Graphic[3] = new Grh();

                    if ((ByFlags & 8) > 0)
                        MapData[x, y].Graphic[4] = new Grh(reader.ReadInt16());
                    else
                        MapData[x, y].Graphic[4] = new Grh();

                    if ((ByFlags & 16) > 0)
                        MapData[x, y].Trigger = reader.ReadInt16();
                    else
                        MapData[x, y].Trigger = 0;

                    if (MapData[x, y].CharIndex > 0)
                        Char.EraseChar(MapData[x, y].CharIndex);

                    MapData[x, y].ObjGrh = new Grh();

                }
            }

            MapInfo.Name = null;
            MapInfo.Music = null;
            Tiles = new tTileLayer[5];
        }


        public static bool InMapBounds(short X, short Y)
        {
            if (X < 1 || X > 100 || Y < 1 || Y > 100)
                return false;
            else
                return true;
        }

        public static void CreateTileLayers()
        {
            byte Layer;
            int X, Y;
            int px, py;

            for (Layer = 1; Layer <= 4; Layer++)
            {

                Tiles[Layer].NumTiles = 0;

                Tiles[Layer].Tile = new tTile[((maxY - minY + 1) * (maxX - minX + 1))];

                ScreenY = -8;
                for (Y = minY; Y <= maxY; Y++)
                {
                    ScreenX = -8;
                    for (X = minX; X <= maxX; X++)
                    {
                        if (InMapBounds((short)X, (short)Y) == true)
                        {
                            px = TileEngine.Engine_PixelPosX(ScreenX);
                            py = TileEngine.Engine_PixelPosY(ScreenY);

                            if (MapData[X, Y].Graphic[Layer].GrhIndex > 0)
                            {

                                if (px > -GrhData.GrhDat[MapData[X, Y].Graphic[Layer].GrhIndex].PixelWidth)
                                    if (px <= 800 + GrhData.GrhDat[MapData[X, Y].Graphic[Layer].GrhIndex].PixelWidth)
                                        if (py > -GrhData.GrhDat[MapData[X, Y].Graphic[Layer].GrhIndex].PixelHeight)
                                            if (py < 600 + GrhData.GrhDat[MapData[X, Y].Graphic[Layer].GrhIndex].PixelHeight)
                                            {
                                                Tiles[Layer].NumTiles++;

                                                Tiles[Layer].Tile[Tiles[Layer].NumTiles].TileX = (byte)X;
                                                Tiles[Layer].Tile[Tiles[Layer].NumTiles].TileY = (byte)Y;

                                                Tiles[Layer].Tile[Tiles[Layer].NumTiles].PixelPosX = (short)px;
                                                Tiles[Layer].Tile[Tiles[Layer].NumTiles].PixelPosY = (short)py;

                                            }
                            }
                        }
                        ScreenX++;
                    }
                    ScreenY++;
                }

                if (Tiles[Layer].NumTiles > 0)
                    Array.Resize(ref Tiles[Layer].Tile, Tiles[Layer].NumTiles +1);
                else
                    Tiles[Layer].Tile = null;
            }
        }

        public static void RenderMap(SpriteBatch sb, short PixelOffsetX, short PixelOffsetY)
        {
            int X, Y;
            short PixelOffsetXTemp, PixelOffsetYTemp;
            short minYOffset=0, minXOffset=0;

            short TileX, TileY;

            //byte Layer;

            TileX = (short)(TileEngine.UserPos.X - TileEngine.AddToUserPos.X);
            TileY = (short)(TileEngine.UserPos.Y - TileEngine.AddToUserPos.Y);

            if ((TileX != LastTileX) || (TileY != LastTileY))
            {
                ScreenMinY = (short)(TileY - TileEngine.HalfWindowTileHeight);
                ScreenMaxY = (short)(TileY + TileEngine.HalfWindowTileHeight);
                ScreenMinX = (short)(TileX - TileEngine.HalfWindowTileWidth);
                ScreenMaxX = (short)(TileX + TileEngine.HalfWindowTileWidth);

                minY = (short)(ScreenMinY - TileEngine.TileBufferSize);
                maxY = (short)(ScreenMaxY + TileEngine.TileBufferSize);
                minX = (short)(ScreenMinX - TileEngine.TileBufferSize);
                maxX = (short)(ScreenMaxX + TileEngine.TileBufferSize);

                LastTileX = TileX;
                LastTileY = TileY;

                CreateTileLayers();
            }

            /*//Make sure mins and maxs are allways in map bounds
            if (minY < 1)
            {
                minYOffset = (short)(1 - minY);
                minY = 1;
            }

            if (maxY > 100)
                maxY = 100;

            if (minX < 1)
            {
                minXOffset = (short)(1 - minX);
                minX = 1;
            }

            if (maxX > 100)
                maxX = 100;

            //If we can, we render around the view area to make it smoother
            if (ScreenMinY > 1)
            {
                ScreenMinY--;
            }
            else
            {
                ScreenMinY = 1;
                ScreenY = 1;
            }

            if (ScreenMaxY < 100)
                ScreenMaxY++;
            else if (ScreenMaxY > 100)
            {
                ScreenMaxY = 100;
            }

            if (ScreenMinX > 1)
                ScreenMinX--;
            else
            {
                ScreenMinX = 1;
                ScreenX = 1;
            }

            if (ScreenMaxX < 100)
                ScreenMaxX++;
            else if (ScreenMaxX > 100)
            {
                ScreenMaxX = 100;
            }
            */

            for (int j = 1; j <= 4; j++)
            {
                for (int i = 1; i <= Tiles[j].NumTiles; i++)
                {
                    TileEngine.Draw(sb, MapData[Tiles[j].Tile[i].TileX, Tiles[j].Tile[i].TileY].Graphic[j], (int)Tiles[j].Tile[i].PixelPosX, (int)Tiles[j].Tile[i].PixelPosY,1);
                }
            }
        }
    }
}
