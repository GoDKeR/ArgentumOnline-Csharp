using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteAOCS.Game;

namespace ClienteAOCS.gui
{
    public partial class Main : Form
    {
        public Game1 gameEntry;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Game1.b == 1)
                Game1.b = 0;
            else
                Game1.b = 1;

        }
    }
}
