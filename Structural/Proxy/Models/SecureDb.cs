using Proxy.Abstractions;
using Shared.Services;

namespace Proxy.Models;
internal class SecureDb : ISecureData {
    public List<Person> _people = new() {
        new Person("Person1") ,
        new Person("Person2") ,
        new Person("Person3") ,
    };
    public void GetPersons() {
        uint i = 1;
        foreach (Person person in _people) {
            Logger.Log($"{i} : {person.FullName}");
            i++;
        }
    }

    public void SetPerson(Person person) {
        _people.Add(person);
        Logger.Log($"{person.FullName} was registered.");
    }
}

