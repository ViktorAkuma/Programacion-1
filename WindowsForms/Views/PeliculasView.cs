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
using MessageBox = System.Windows.Forms.MessageBox;

namespace WindowsForms.Views
{
    public partial class PeliculasView : Form
    {
        HttpClient clientHttp = new HttpClient();
        string url = "https://cinesoftware-2930.restdb.io/rest/peliculas?apikey=7aee3ab585afc8cd5fe64627767c0998584b4";
        Peliculas peliSeleccionada = new Peliculas();

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
        private async void ObtenemosPeliculas()
        {

            var response = await clientHttp.GetAsync(url);
            if (response != null)
            {
                List<Peliculas> peliculas = await response.Content.ReadFromJsonAsync<List<Peliculas>>();
                GridPeliculas.DataSource = peliculas;
            }
        }

        private async void btnEliminar_Click_1(object sender, EventArgs e)
        {
            //Chequeamos que haya peliculas en la grilla
            if (GridPeliculas.RowCount > 0 && GridPeliculas.SelectedRows.Count > 0)
            {
                Peliculas peliculasSeleccionada = (Peliculas)GridPeliculas.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Está seguro que desea eliminar la película seleccionada {peliSeleccionada._id}?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    string url = $"https://cinesoftware-2930.restdb.io/rest/peliculas/{peliculasSeleccionada}?apikey=7aee3ab585afc8cd5fe64627767c0998584b4";
                    var response = await clientHttp.DeleteAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Película eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ObtenemosPeliculas();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una película para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void PeliculasView_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridPeliculas_SelectionChanged(object sender, EventArgs e)
        { 
            if (GridPeliculas.RowCount > 0 && GridPeliculas.SelectedRows.Count > 0)
            {
                Peliculas peliSeleccionada = (Peliculas)GridPeliculas.SelectedRows[0].DataBoundItem;
                FilmPicture.ImageLocation = peliSeleccionada.portada;
            }
           
        }
    }
}
