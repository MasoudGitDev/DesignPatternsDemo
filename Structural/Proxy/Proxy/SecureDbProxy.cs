using Proxy.Models;
using Shared.Services;

namespace Proxy.Proxy;
internal class SecureDbProxy {

    private readonly SecureDb _secureDb = new();

    public void GetPersonsByToken(string token) {
       if(CheckToken(token)) {
            _secureDb.GetPersons();
       }      
    }

    public void CreatePerson(string token , Person person) {
        if(CheckToken(token)) {
            _secureDb.SetPerson(person);
        }
    }

    private bool CheckToken(string token) {
        if(String.IsNullOrWhiteSpace(token) || token != "token") {
            Logger.Log($"The Token : <{token}> is invalid");
            return false;
        }
        return true;
    }
}
