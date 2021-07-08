using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Cabinet.Desktop.ServiceLayer.Person.Concrete
{
    class PersonService : IPersonService
    {
        private WebClient client = new WebClient();
        public PersonModel Get(int id)
        {
            var res = client.DownloadString(Path.Combine(Constants.GET, id.ToString()));
            var model = JsonConvert.DeserializeObject<PersonModel>(res);
            return model;
        }

        public async Task<IList<PersonModel>> GetAllAsync()
        {
            IList<PersonModel> models = new List<PersonModel>();
            await Task.Run(() =>
            {
                var res = client.DownloadString(Constants.GET_ALL);
                models = JsonConvert.DeserializeObject<List<PersonModel>>(res);
            });
            return models;
        }
    }
}
