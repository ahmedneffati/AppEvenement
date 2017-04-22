using AppEvenement.Models;
using Plugin.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEvenement.Services
{
    class UserServices
    {
        RestClient<User> restClient = new RestClient<User>("http://fdhiha.azurewebsites.net/Admins/");
        public async Task<List<User>> getAdminsAsync()
        {


            var Admins = await restClient.GetAsync();
            return Admins;

        }


        public async Task PostAdminsAsync(User e)
        {

            var Admins = await restClient.PostAsync(e);


        }
        public async Task PutAdminsAsync(int id, User e)
        {

            var Admins = await restClient.PutAsync(id, e);


        }
        public async Task DeleteAdminsAsync(int id)
        {

            var Admins = await restClient.DeleteAsync(id);


        }

    }

}