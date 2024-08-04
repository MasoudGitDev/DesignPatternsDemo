namespace DatabaseProxyDemo.Abstractions;
internal interface IDatabase {
    List<IUser> GetUsers();
    IUser? GetUserByName(string username);
    void Add(IUser user);
}
