using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ClienteAOCS.engine.Data
{
    public class GrhData
    {
            
        public static tGrhData[] GrhDat;

        public struct tGrhData
        {
            public short sX, sY;

            public int FileNum;

            public short PixelWidth, PixelHeight;

            public Single TileWidth, TileHeight;

            public short NumFrames;
            public int[] Frames;

            public Single Speed;
        }

        public static bool LoadGrhData()
        {
            int grhCount,Grh,Frame;

            FileStream fs = new FileStream("C:\\Users\\PC\\Desktop\\AOSuite\\ClienteAOCS\\ClienteAOCS\\ClienteAOCS\\bin\\x86\\init\\Graficos.ind", FileMode.Open);
            BinaryReader reader = new BinaryReader(fs);

            reader.ReadInt32(); //fileVersion

            grhCount = reader.ReadInt32();

            GrhDat = new tGrhData[grhCount+1];

            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                Grh = reader.ReadInt32();
                if (Grh != 0)
                {
                    GrhDat[Grh].NumFrames = reader.ReadInt16();

                    if (GrhDat[Grh].NumFrames <= 0)
                        return false;

                    GrhDat[Grh].Frames = new int[GrhDat[Grh].NumFrames +1];

                    if (GrhDat[Grh].NumFrames > 1)
                    {
                        for (Frame = 1; Frame <= GrhDat[Grh].NumFrames; Frame++)
                        {
                            GrhDat[Grh].Frames[Frame] = reader.ReadInt32();

                            if (GrhDat[Grh].Frames[Frame] <= 0 || GrhDat[Grh].Frames[Frame] > grhCount)
                            {
                                return false;
                            }
                        }

                        GrhDat[Grh].Speed = reader.ReadSingle();

                        GrhDat[Grh].PixelHeight = GrhDat[GrhDat[Grh].Frames[1]].PixelHeight;
                        if (GrhDat[Grh].PixelHeight <= 0)
                            return false;

                        GrhDat[Grh].PixelWidth = GrhDat[GrhDat[Grh].Frames[1]].PixelWidth;
                        if (GrhDat[Grh].PixelWidth <= 0)
                            return false;

                        GrhDat[Grh].TileWidth = GrhDat[GrhDat[Grh].Frames[1]].TileWidth;
                        if (GrhDat[Grh].TileWidth <= 0)
                            return false;

                        GrhDat[Grh].TileHeight = GrhDat[GrhDat[Grh].Frames[1]].TileHeight;
                        if (GrhDat[Grh].TileHeight <= 0)
                            return false;
                    }else{
                        GrhDat[Grh].FileNum = reader.ReadInt32();
                        if (GrhDat[Grh].FileNum <= 0)
                            return false;

                        GrhDat[Grh].sX = reader.ReadInt16();
                        if (GrhDat[Grh].sX < 0)
                            return false;

                        GrhDat[Grh].sY = reader.ReadInt16();
                        if (GrhDat[Grh].sY < 0)
                            return false;

                        GrhDat[Grh].PixelWidth = reader.ReadInt16();
                        if (GrhDat[Grh].PixelWidth <= 0)
                            return false;

                        GrhDat[Grh].PixelHeight = reader.ReadInt16();
                        if (GrhDat[Grh].PixelHeight <= 0)
                            return false;

                        GrhDat[Grh].TileWidth = (float)GrhDat[Grh].PixelWidth / 32.0f;
                        GrhDat[Grh].TileHeight = (float)GrhDat[Grh].PixelHeight / 32.0f;

                        GrhDat[Grh].Frames[1] = Grh;

                    }
                }
            }
            return true;
        }

    }
}
