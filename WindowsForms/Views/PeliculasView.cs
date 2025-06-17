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
using WindowsForms.Services;
using MessageBox = System.Windows.Forms.MessageBox;

namespace WindowsForms.Views
{
    public partial class PeliculasView : Form
    {
        HttpClient clientHttp = new HttpClient();
        string url = "https://cinesoftware-2930.restdb.io/rest/peliculas?apikey=7aee3ab585afc8cd5fe64627767c0998584b4";
        PeliculaService peliculaService = new PeliculaService();
        Peliculas peliculaModificada;
        List<Peliculas> peliculas;

        public PeliculasView()
        {
            InitializeComponent();
            ObtenemosPeliculas();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TabPagesLista.SelectTab("TabPageAgregar");
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
        private async void ObtenemosPeliculas()
        {
            GridPeliculas.DataSource = await peliculaService.GetAllAsync();
        }

        private async void btnEliminar_Click_1(object sender, EventArgs e)
        {
            //Chequeamos que haya peliculas en la grilla
            if (GridPeliculas.RowCount > 0 && GridPeliculas.SelectedRows.Count > 0)
            {
                Peliculas peliSeleccionada = (Peliculas)GridPeliculas.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Está seguro que desea eliminar la película seleccionada {peliSeleccionada.titulo}?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {

                    if (await peliculaService.DeleteAsync(peliSeleccionada._id))
                    {
                        LabelStatusMessage.Text = $"Película {peliSeleccionada.titulo} eliminada correctamente";
                        TimerStatusBar.Start(); // Iniciar el temporizador para borrar el mensaje después de 5 segundos
                        ObtenemosPeliculas();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una película para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TabPagesLista.SelectTab("TabPageLista");
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            Peliculas PeliculaAGuardar = new Peliculas
            {
                _id = peliculaModificada?._id??null, // Si es una modificación, usamos el ID existente
                titulo = labelTitulo.Text,
                duracion = (int)NumericDuracion.Value,
                portada = labelPortada.Text,
                calificacion = (double)NumericCalificacion.Value
            };

            bool response;
            if (peliculaModificada != null)
            {
                response = await peliculaService.UpdateAsync(PeliculaAGuardar);
            }
            else
            {
                response = await peliculaService.AddAsync(PeliculaAGuardar);
            }
            if (response)
            {
                peliculaModificada = null; // Limpiamos la variable para que no se use en futuras modificaciones
                LabelStatusMessage.Text = "Película guardada correctamente";
                TimerStatusBar.Start(); // Iniciar el temporizador para borrar el mensaje después de 5 segundos
                ObtenemosPeliculas();
                TabAgregarEditar
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void toolStripStatusLabel5_Click(object sender, EventArgs e)
        {

        }
        private void TimerStatusBar_Tick(object sender, EventArgs e)
        {
            LabelStatusMessage.Text = string.Empty;
            TimerStatusBar.Stop(); // Detenemos el temporizador para que el mensaje no se borre inmediatamente

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1_TextChanged))
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void TabAgregarEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
