using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WindowsForms.Models;

namespace WindowsForms.Services
{
    public class PeliculaService
    {
        HttpClient clientHttp = new HttpClient();
        string url = "https://cinesoftware-2930.restdb.io/rest/peliculas?apikey=7aee3ab585afc8cd5fe64627767c0998584b4";
        public async Task<List<Peliculas>>? GetAllAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<Peliculas>>();
                }
                else
                {
                    throw new Exception("Error al obtener las películas");
                }
            }
        }
        public async Task<bool> DeleteAsync(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://cinesoftware-2930.restdb.io/rest/peliculas/{id}?apikey=7aee3ab585afc8cd5fe64627767c0998584b4";

                var response = await clientHttp.DeleteAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al eliminar la película");
                }
            }
        }
        public async Task<bool> UpdateAsync(Peliculas pelicula)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://cinesoftware-2930.restdb.io/rest/peliculas/{pelicula._id}?apikey=7aee3ab585afc8cd5fe64627767c0998584b4";
                var response = await clientHttp.PutAsJsonAsync(url, pelicula);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al actualizar la película");
                }
            }
        }
        public async Task<bool> AddAsync(Peliculas pelicula)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await clientHttp.PostAsJsonAsync(url, pelicula);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al agregar la película");
                }
            }
        }
    }
}
