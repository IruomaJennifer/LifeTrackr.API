﻿using LifeTrackr.API.Application;
using System.Reflection.Metadata.Ecma335;

namespace LifeTrackr.API.Infrastructure
{
    public class UserRepository
    {
        public static List<User> _users = [];

        public UserRepository()
        {
            PopulateUsers();
        }

        public int CreateUser(CreateUserDto newUser)
        {
            var userId = _users.OrderBy(u => u.Id).Last().Id++;
            _users.Add(new User { Email = newUser.Email, FullName = newUser.FullName, CreatedAt = DateTime.UtcNow, Id = userId });
            return userId;
        }

        public void DeleteUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            _users.Remove(user!);
        }

        public void UpdateUser(UpdateUserDto userDto)
        {
            var user = _users.FirstOrDefault(u => u.Id == userDto.Id);
            user!.FullName = userDto.FullName;
            
        }

        public List<User> GetAllUsers() => _users;
        public User GetUserById(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            return user!;
        }
        private void PopulateUsers()
        {

            _users.Add(new User { Email = "peter.parker@gmail.com", FullName = "Peter Parker", Id = 1, CreatedAt = DateTime.UtcNow });
            _users.Add(new User { Email = "jane.sanders@gmail.com", FullName = "Jane Sanders", Id = 2, CreatedAt = DateTime.UtcNow });
            _users.Add(new User { Email = "john.mcvein@gmail.com", FullName = "John Mcvein", Id = 3, CreatedAt = DateTime.UtcNow });
            _users.Add(new User { Email = "joel.vermont@gmail.com", FullName = "Joel Vermont", Id = 4, CreatedAt = DateTime.UtcNow });
            _users.Add(new User { Email = "anthonia.rivera@gmail.com", FullName = "Anthonia Rivera", Id = 5, CreatedAt = DateTime.UtcNow });
            
        }
    }
}
