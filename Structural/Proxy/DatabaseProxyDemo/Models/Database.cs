using DatabaseProxyDemo.Abstractions;

namespace DatabaseProxyDemo.Models;
internal class FakeDatabase : IDatabase {
    private readonly LinkedList<IUser> Users = FakeUsers();

    public void Add(IUser user) {
        Users.AddLast(user);
    }

    public IUser? GetUserByName(string username) {
        return Users.FirstOrDefault(x => x.UserName == username);
    }

    public List<IUser> GetUsers() {
        return [.. Users];
    }

    public static LinkedList<IUser> FakeUsers() {
        LinkedList<IUser> users = [];
        for(uint i = 1 ; i <= 10 ; i++) {
            users.AddLast(new User(i , "UserName_" + i , "Password_" + i , "Name" + i));
        }
        return users;
    }
}
