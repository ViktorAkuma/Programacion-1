using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using WindowsForms.Models;

namespace WindowsForms.Views
{
    public partial class PeliculasView : Form
    {
        public PeliculasView()
        {
            InitializeComponent();
            ObtenemosPeliculas();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void ObtenemosPeliculas()
        {
            string url = "https://cinesoftware-2930.restdb.io/rest/peliculas?apikey=7aee3ab585afc8cd5fe64627767c0998584b4";
            var clientHttp = new HttpClient();
            var response = await clientHttp.GetAsync(url);
            if (response != null)
            {
                List<Peliculas> peliculas = await response.Content.ReadFromJsonAsync<List<Peliculas>>();
                dataGridView1.DataSource = peliculas;
            }
        }
    }
}
