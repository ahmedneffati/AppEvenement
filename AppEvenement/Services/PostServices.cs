using AppEvenement.Models;
using Plugin.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEvenement.Services
{
    class PostServices
    {
        RestClient<Post> restClient = new RestClient<Post>("http://fdhiha.azurewebsites.net/Posts/");
        public async Task<List<Post>> getAdminsAsync()
        {


            var Admins = await restClient.GetAsync();
            return Admins;

        }


        public async Task PostAdminsAsync(Post e)
        {

            var Admins = await restClient.PostAsync(e);


        }
        public async Task PutAdminsAsync(int id, Post e)
        {

            var Admins = await restClient.PutAsync(id, e);


        }
        public async Task DeleteAdminsAsync(int id)
        {

            var Admins = await restClient.DeleteAsync(id);


        }
        public async Task<List<Post>> getTachesOfDayAsync(int i)
        {
            restClient = new RestClient<Post>("http://fdhiha.azurewebsites.net/api/posts/cat/" + i);

            var Taches = await restClient.GetAsync();
            return Taches;

        }
    }

}