using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabinet.Desktop.ServiceLayer.Person
{
    interface IPersonService
    {
        Task<IList<PersonModel>> GetAllAsync();
        PersonModel Get(int id);
    }
}
