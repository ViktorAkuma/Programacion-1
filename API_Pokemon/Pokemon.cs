using System.Security.Policy;

namespace API_Pokemon
{
    public partial class Pokemon : Form
    {
        HttpClient clientHttp = new HttpClient();
        string url = "";
        public Pokemon()
        {
            InitializeComponent();
            PokemonesGuardados();
        }
        private async void PokemonesGuardados()
        {
            var response = await clientHttp.GetAsync(url);
            if (response != null)
            {
                List<Pokemon> pokemones = await
                    response.Con
            }
        }
        private void GridPokedex_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridPokedex.RowCount > 0 && GridPokedex.SelectedRows.Count > 0)
            {
                Pokemon pokemon = (Pokemon)GridPokedex.SelectedRows[0].DataBoundItem;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelNom_Click(object sender, EventArgs e)
        {

        }
    }
}
