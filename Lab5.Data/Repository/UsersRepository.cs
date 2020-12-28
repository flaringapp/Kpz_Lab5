using System;
using System.Collections.Generic;

namespace Lab5.Data.Repository
{
    public class UsersRepository : IUsersRepository
    {

        private static IUsersRepository _instance = null;

        public static IUsersRepository Instance
        {
            get
            {
                if (_instance == null) _instance = new UsersRepository();
                return _instance;
            }
        }

        public event Action<List<UserModel>> OnUsersUpdated;

        private readonly List<UserModel> _users = DataModel.Load().Users;

        public List<UserModel> GetUsers()
        {
            return _users;
        }

        public void AddUser(UserModel user)
        {
            _users.Add(user);
            OnUsersUpdated?.Invoke(_users);
        }

        public void UpdateUser(UserModel user)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].Id == user.Id)
                {
                    _users[i] = user;
                    OnUsersUpdated?.Invoke(_users);
                    return;
                }
            }
        }

        public void DeleteUser(string id)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].Id == id)
                {
                    _users.RemoveAt(i);
                    OnUsersUpdated?.Invoke(_users);
                    return;
                }
            }
        }
    }
}
