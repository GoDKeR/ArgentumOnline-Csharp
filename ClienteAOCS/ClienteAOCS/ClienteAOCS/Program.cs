using System;
using System.Windows.Forms;
using ClienteAOCS.Game;
using ClienteAOCS.engine;
using ClienteAOCS.engine.Data;
using ClienteAOCS.map;

namespace ClienteAOCS
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            if (GrhData.LoadGrhData() == false || HeadData.LoadHead() == false || BodyData.LoadBody() == false || FxData.LoadFxs() == false || ShieldData.LoadShield() == false || WeaponData.LoadWeapons() == false || HelmetData.LoadHelmets() == false)
            {
                MessageBox.Show("Se Produjo un error durante la carga de INITS");
                Application.Exit();
            }

            TileEngine.InitTileEngine(32, 32, 17, 13, 9);
            Map.LoadMap(1);

            using (gui.Main lForm = new gui.Main())
            {
                lForm.Show();
                lForm.gameEntry = new Game1(lForm.Render.Handle, lForm, lForm.Render);
                lForm.gameEntry.Run();
            }
        }
#endif
    }
}

