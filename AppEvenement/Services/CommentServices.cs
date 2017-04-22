using AppEvenement.Models;
using Plugin.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEvenement.Services
{
    class CommentServices
    {
        RestClient<Commentaire> restClient = new RestClient<Commentaire>("http://fdhiha.azurewebsites.net/Commentaires/");
        public async Task<List<Commentaire>> getAdminsAsync()
        {


            var Admins = await restClient.GetAsync();
            return Admins;

        }


        public async Task PostAdminsAsync(Commentaire e)
        {

            var Admins = await restClient.PostAsync(e);


        }
        public async Task PutAdminsAsync(int id, Commentaire e)
        {

            var Admins = await restClient.PutAsync(id, e);


        }
        public async Task DeleteAdminsAsync(int id)
        {

            var Admins = await restClient.DeleteAsync(id);


        }

    }

}