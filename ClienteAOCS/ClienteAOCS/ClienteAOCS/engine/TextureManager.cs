using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System.IO;
using System.Runtime.InteropServices;
using ClienteAOCS.Game;

namespace ClienteAOCS.engine
{
    public static class TextureManager
    {
        
        [DllImport("kernel32", EntryPoint = "GetTickCount")]
        public static extern long GetTickCount();

        private struct AOText
        {
            public Texture2D texture;
            public long lastAccess;
            public long size;

        }

        //TODO: PERFORMANCE: Chau dictionary, hola Array (es alrededor de 2veces mas rapido) ¿Necesario?
        private static Dictionary<string, AOText> textures = new Dictionary<string, AOText>();
        private static GraphicsDevice device;

        private const int Bytes_per_MB = 1048576;
        private const int Max_MB = 128 * Bytes_per_MB;

        private static long UsedBytes;

        /// <summary>
        /// Initialize the texture manager
        /// </summary>
        /// <param name="d">Current GraphicsDevice</param>

        public static bool InitTextureManager(GraphicsDevice d){
            device = d;
            UsedBytes = 0;

            return true;
        }
        /// <summary>
        /// Load a Texture from a file, and put it in a Dictionary
        /// </summary>
        /// <param name="name">Name of the texture to load (whitout the format).</param>
        public static Texture2D LoadTexture(string name)
        {
            AOText Surface;
            Stream fs;

            if (textures.TryGetValue(name, out Surface) == true)
            {
                Surface.lastAccess = GetTickCount();
                return Surface.texture;
            }
            else
            {
                //Load and Set the texture
                fs = File.OpenRead("C:\\Users\\PC\\Desktop\\AOSuite\\ClienteAOCS\\ClienteAOCS\\ClienteAOCS\\bin\\x86\\graficos\\" + name + ".png");
                Surface.texture = Texture2D.FromStream(device, fs);
                Surface.lastAccess = GetTickCount();
                Surface.size = fs.Length;

                //Update usedbytes
                UsedBytes += fs.Length;
                
                //Add the surface to Dictionary
                textures.Add(name, Surface);

                //Check the memory usage
                while (UsedBytes > Max_MB)
                {
                    if (RemoveLRU() == false)
                        break;
                }

                return Surface.texture;
            }
        }

        private static bool RemoveLRU()
        {
            long LRUTime;
            AOText t;
            string index= null;
            long size=0;
            LRUTime = GetTickCount();

            foreach (var item in textures)
            {
                t = item.Value;

                if (LRUTime > t.lastAccess)
                {
                    index = item.Key;
                    LRUTime = t.lastAccess;
                    size = t.size;
                }
            }

            if (index != null)
            {
                UsedBytes = UsedBytes - size;
                textures.Remove(index);

                return true;
            }

            return false;
        }
    }
}
