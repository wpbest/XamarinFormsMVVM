using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinFormsMVVM.Services.Person
{
    public interface IPeopleService
    {
        Task<IEnumerable<Model.Person>> GetPeople();
    }
}
