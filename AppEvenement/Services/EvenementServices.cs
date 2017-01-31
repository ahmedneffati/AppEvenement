using AppEvenement.Models;
using Plugin.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEvenement.Services
{
    class EvenementServices
    {
        RestClient<Evenement> restClient = new RestClient<Evenement>("http://takwira.azurewebsites.net/api/terrains");
        public async Task<List<Evenement>> getEvenementsAsync()
        {


            var Evenements = await restClient.GetAsync();
            return Evenements;

        }


        public async Task PostEvenementsAsync(Evenement e)
        {

            var Evenements = await restClient.PostAsync(e);


        }
        public async Task PutEvenementsAsync(int id, Evenement e)
        {

            var Evenements = await restClient.PutAsync(id, e);


        }
        public async Task DeleteEvenementsAsync(int id)
        {

            var Evenements = await restClient.DeleteAsync(id);


        }

    }

}