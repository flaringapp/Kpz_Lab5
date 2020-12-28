using System;
using System.Collections.Generic;
using System.Linq;

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
            var maxId = 1L;
            if (_users.Count > 0)
            {
                maxId = _users.Max(u => u.Id);
            }
            user.Id = maxId + 1;
            _users.Add(user);
            ProcessUsersUpdated();
        }

        public void UpdateUser(UserModel user)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].Id == user.Id)
                {
                    _users[i] = user;
                    ProcessUsersUpdated();
                    return;
                }
            }
        }

        public void DeleteUser(long id)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].Id == id)
                {
                    _users.RemoveAt(i);
                    ProcessUsersUpdated();
                    return;
                }
            }
        }

        private void ProcessUsersUpdated()
        {
            SaveUsers();
            OnUsersUpdated?.Invoke(_users);
        }

        private void SaveUsers()
        {
            new DataModel { Users = _users }.Save();
        }
    }
}
