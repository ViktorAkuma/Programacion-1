using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Views;

namespace WindowsForms
{
    public partial class ClimaAppView : Form
    {
        private string v;

        public ClimaAppView()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void subMenuSalirdelaApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconToolStripButton2_Click(object sender, EventArgs e)
        {
            NosotrosView nosotrosView = new NosotrosView();
            nosotrosView.ShowDialog();
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            iconToolStripButton2_Click(sender, e);
        }

        private void iconToolStripButton1_Click(object sender, EventArgs e)
        {
            string url = "https://api.open-meteo.com/v1/forecast?latitude=-30.783764985498472&longitude=-60.590981253914215&current=temperature_2m,relative_humidity_2m";
            var clientHttp = new System.Net.Http.HttpClient();
        }
    }
}
