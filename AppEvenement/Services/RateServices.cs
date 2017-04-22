using AppEvenement.Models;
using Plugin.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEvenement.Services
{
    class RateServices
    {
        RestClient<Rate> restClient = new RestClient<Rate>("http://fdhiha.azurewebsites.net/Admins/");
        public async Task<List<Rate>> getAdminsAsync()
        {


            var Admins = await restClient.GetAsync();
            return Admins;

        }


        public async Task PostAdminsAsync(Rate e)
        {

            var Admins = await restClient.PostAsync(e);


        }
        public async Task PutAdminsAsync(int id, Rate e)
        {

            var Admins = await restClient.PutAsync(id, e);


        }
        public async Task DeleteAdminsAsync(int id)
        {

            var Admins = await restClient.DeleteAsync(id);


        }

    }

}