using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteAOCS.engine.Data;
using ClienteAOCS.Game;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ClienteAOCS.engine
{
    public static class TileEngine
    {

        public static Position UserPos;
        public static Position AddToUserPos;

        public static short TilePixelWidth, TilePixelHeight;
        public static short WindowTileWidth, WindowTileHeight;
        public static short HalfWindowTileWidth, HalfWindowTileHeight;

        public static byte TileBufferSize;

        public static Rectangle MainDestRect;

        public enum E_Heading
        {
            North = 1,
            East = 2,
            South = 3,
            West = 4
        }

        public struct Position
        {
            public int X;
            public int Y;
        }


        public static void InitTileEngine(short setTilePixelWidth, short setTilePixelHeight,short setWindowTileWidth, short setWindowTileHeight, byte setTileBufferSize)
        {
            TilePixelWidth = setTilePixelWidth;
            TilePixelHeight = setTilePixelHeight;
            WindowTileWidth = setWindowTileWidth;
            WindowTileHeight = setWindowTileHeight;
            TileBufferSize = setTileBufferSize;

            HalfWindowTileWidth = (short)(WindowTileWidth / 2);
            HalfWindowTileHeight = (short)(WindowTileHeight / 2);

            UserPos.X = 50;
            UserPos.Y = 50;

            MainDestRect = new Rectangle(0, 0, 544, 416);
        }

        public static short Engine_PixelPosX(short X)
        {
            return (short)((X - 1) * 32);
        }

        public static short Engine_PixelPosY(short Y)
        {
            return (short)((Y - 1) * 32);
        }

        public static void Draw(SpriteBatch sb, Grh Grh, int X, int Y, byte center)
        {
            short CurrentGrhIndex;
            Rectangle SourceRect;

            if (Grh.GrhIndex != 0)
            {
                //animate

                CurrentGrhIndex = (short)GrhData.GrhDat[Grh.GrhIndex].Frames[(int)Grh.FrameCounter];

                if (center == 1)
                {
                    if (GrhData.GrhDat[CurrentGrhIndex].TileWidth != 1)
                        X = X - (short)((GrhData.GrhDat[CurrentGrhIndex].TileWidth * TilePixelWidth / 2)+ (short)(TilePixelWidth/2));

                    if (GrhData.GrhDat[CurrentGrhIndex].TileHeight != 1)
                        Y = Y - (short)(GrhData.GrhDat[CurrentGrhIndex].TileHeight * TilePixelHeight) + TilePixelHeight;

                }

                SourceRect = new Rectangle(GrhData.GrhDat[CurrentGrhIndex].sX, GrhData.GrhDat[CurrentGrhIndex].sY, GrhData.GrhDat[CurrentGrhIndex].sX + GrhData.GrhDat[CurrentGrhIndex].PixelWidth, GrhData.GrhDat[CurrentGrhIndex].sY + GrhData.GrhDat[CurrentGrhIndex].PixelHeight);

                Texture_Render(sb, X, Y, GrhData.GrhDat[CurrentGrhIndex].FileNum, SourceRect);
            }

        }

        static void Texture_Render(SpriteBatch sb,int X, int Y, long FileNum, Rectangle srcRect)
        {
            sb.Draw(TextureManager.LoadTexture(FileNum.ToString()), new Rectangle(X,Y,srcRect.Width,srcRect.Height), srcRect, Color.White);
        }


    }
}
