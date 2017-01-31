using Plugin.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEvenement.Models;
namespace AppEvenement.Services
{
    class TacheServices
    {
        RestClient<Tache> restClient = new RestClient<Tache>("http://eventahmed.azurewebsites.net/api/Taches1/");

        public async Task<List<Tache>> getTachesOfDayAsync(int i)
        {
            restClient = new RestClient<Tache>("http://eventahmed.azurewebsites.net/api/Taches1/GetTachParDay/"+i);

            var Taches = await restClient.GetAsync();
            return Taches;

        }


        public async Task<List<Tache>> getTachesAsync()
        {


            var Taches = await restClient.GetAsync();
            return Taches;

        }


        public async Task PostTachesAsync(Tache e)
        {

            var Taches = await restClient.PostAsync(e);


        }
        public async Task PutTachesAsync(int id, Tache e)
        {

            var Taches = await restClient.PutAsync(id, e);


        }
        public async Task DeleteTachesAsync(int id)
        {

            var Taches = await restClient.DeleteAsync(id);


        }

    }

}