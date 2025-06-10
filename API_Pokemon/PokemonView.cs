using API_Pokemon.Models;
using System.Net.Http.Json;
using System.Security.Policy;

namespace API_Pokemon.Views
{
    public partial class PokemonView : Form
    {
        HttpClient clientHttp = new HttpClient();
        string url = "https://pokeapi.co/api/v2/pokemon/";
        
        public PokemonView()
        {
            InitializeComponent();
            ObtenerPokemon();
        }
        private async void ObtenerPokemon()
        {
            var response = await clientHttp.GetAsync(url);
            if (response != null)
            {
                QueryPokemon query = await response.Content.ReadFromJsonAsync<QueryPokemon>();
                GridPokemon.DataSource = query.results;
            }
        }
        private void labelNom_Click(object sender, EventArgs e)
        {

        }
        private void textBoxBuscar_Enter(object sender, EventArgs e)
        {

        }

        private void GridPokemon_CellContentClick(object sender, EventArgs e)
        {
            if (GridPokemon.RowCount > 0 && GridPokemon.SelectedRows.Count > 0)
            {
                PokemonView PokemonSeleccionado = (PokemonView)GridPokemon.SelectedRows[0].DataBoundItem;
            }
        }
    }
}
