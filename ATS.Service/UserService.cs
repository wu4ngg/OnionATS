using ATS.Data;
using ATS.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Service
{
    public class UserService : IUserService
    {
        private IRepository<User> userRepository;
        private IRepository<Profile> profileRepository;
        private IAuthRepository authRepository;
        public UserService(IRepository<User> userRepository, IRepository<Profile> profileRepository, IAuthRepository authRepository)
        {
            this.userRepository = userRepository;
            this.profileRepository = profileRepository;
            this.authRepository = authRepository;
        }
        public long Login(string username, string password)
        {
            return authRepository.Login(username, password);
        }
        public IEnumerable<User> GetUsers()
        {
            return userRepository.GetAll();
        }

        public User GetUser(long id)
        {
            return userRepository.Get(id);
        }

        public void InsertUser(User user)
        {
            userRepository.Insert(user);
        }
        public void UpdateUser(User user)
        {
            userRepository.Update(user);
        }

        public void DeleteUser(long id)
        {
            Profile userProfile = profileRepository.Get(id);
            profileRepository.Remove(userProfile);
            User user = GetUser(id);
            userRepository.Remove(user);
            userRepository.SaveChanges();
        }
    }
}
