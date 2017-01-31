using AppEvenement.Models;
using Plugin.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEvenement.Services
{
    class AdminServices
    {
        RestClient<Admin> restClient = new RestClient<Admin>("http://takwira.azurewebsites.net/api/Admins/");
        public async Task<List<Admin>> getAdminsAsync()
        {


            var Admins = await restClient.GetAsync();
            return Admins;

        }


        public async Task PostAdminsAsync(Admin e)
        {

            var Admins = await restClient.PostAsync(e);


        }
        public async Task PutAdminsAsync(int id, Admin e)
        {

            var Admins = await restClient.PutAsync(id, e);


        }
        public async Task DeleteAdminsAsync(int id)
        {

            var Admins = await restClient.DeleteAsync(id);


        }

    }

}