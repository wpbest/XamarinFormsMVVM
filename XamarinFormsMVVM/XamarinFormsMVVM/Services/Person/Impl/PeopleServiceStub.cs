using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinFormsMVVM.Utils;

namespace XamarinFormsMVVM.Services.Person.Impl
{
    public class PeopleServiceStub : IPeopleService
    {
        public Task<IEnumerable<Model.Person>> GetPeople()
        {
            const int numberOfPeopleToGenerate = 100;
            return Task.Run(() => GeneratePeople(numberOfPeopleToGenerate));
        }
        static public IEnumerable<Model.Person> GeneratePeople(int personCount)
        {
            var people = new List<Model.Person>(personCount);

            for (int i = 0; i < personCount; ++i)
            {
                people.Add(new Model.Person(NameGenerator.GenRandomFirstName(), NameGenerator.GenRandomLastName()));
            }

            return people;
        }
    }
}
