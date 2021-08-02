using System;
using System.Collections.Generic;
using System.Linq;

namespace RazorHybrid.Repos
{
    public class UserRepo
    {
        private readonly List<User> _users;

        public UserRepo()
        {
            _users = new List<User>();
        }

        public UserRepo(List<User> users)
        {
            _users = users;
        }

        public List<User> GetAll() => _users;

        public User GetById(Guid id) => _users.SingleOrDefault(u => u.Id == id);
    }

    public class User
    {
        public Guid Id { get; set; }
        public string Name => $"{FirstName} {LastName}";
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}