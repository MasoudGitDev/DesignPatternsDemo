using DatabaseProxyDemo.Abstractions;
using Shared.Services;

namespace DatabaseProxyDemo.Models;


internal class DatabaseProxy(IDatabase database , Login login) {  

    public void Add(IUser user) {
        DoIfValidUser(login , () => {
            database.Add(user);
            Logger.Log($"The new user with userName : <{user.UserName}> has been added successfully.");
        });       
    }

    public void GetUserByName(string username) {
        DoIfValidUser(login , () => {
            var findUser = database.GetUserByName(username);
            if(findUser is null) {
                Logger.Log($"The user with userName : <{username}> not found.");
            }
            else {
                Logger.Log($"(Id : {findUser.Id}) : (userName : {findUser.Name})\n");
            }
        });     
    }

    public void GetUsers() {
        DoIfValidUser(login , () => {
            var findUsers = database.GetUsers();
            Logger.Log($"{findUsers.Count} users :\n");
            foreach(var user in findUsers) {
                Logger.Log($"(Id : {user.Id}) : (userName : {user.UserName}) : (name : {user.Name})\n");
            }
        });       
    }

    private static void DoIfValidUser(Login login , Action action) {
        if(login.UserName == "UserName_1" && login.Password == "Password_1") {
            Logger.Log("You are a valid user.");
            action();
            return;
        }
        Logger.Log("You are not a valid user.");
    }
}
