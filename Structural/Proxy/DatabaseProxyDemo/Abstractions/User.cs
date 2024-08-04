namespace DatabaseProxyDemo.Abstractions;
internal interface IUser {
    uint Id { get; init; }
    string UserName { get; init; }
    string Password { get; init; }
    string Name { get; init; }

}
