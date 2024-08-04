using DatabaseProxyDemo.Abstractions;

namespace DatabaseProxyDemo.Models;
internal record User(uint Id , string UserName , string Password , string Name) : IUser {
}
