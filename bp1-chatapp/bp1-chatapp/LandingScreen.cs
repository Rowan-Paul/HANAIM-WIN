using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bp1_chatapp
{
    public partial class LandingScreen : Form
    {
        public LandingScreen()
        {
            InitializeComponent();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            ClientScreen client = new ClientScreen();
            client.Show();
        }

        private void serverButton_Click(object sender, EventArgs e)
        {
            ServerScreen server = new ServerScreen();
            server.Show();
        }
    }
}