using System;
using System.Collections.Generic;

namespace Lab5.Data.Repository
{
    public interface IUsersRepository
    {
        
        event Action<List<UserModel>> OnUsersUpdated;

        List<UserModel> GetUsers();

        void AddUser(UserModel user);

        void UpdateUser(UserModel user);

        void DeleteUser(long id);

    }
}
