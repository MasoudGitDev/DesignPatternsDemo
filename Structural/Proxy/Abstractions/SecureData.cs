using Proxy.Models;

namespace Proxy.Abstractions;
internal interface ISecureData {
    void GetPersons();
    void SetPerson(Person person);
}
