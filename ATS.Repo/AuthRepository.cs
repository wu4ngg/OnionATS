using ATS.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Repo
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ApplicationContext context;
        private DbSet<User> entities;
        string errorMessage = string.Empty;
        public AuthRepository(ApplicationContext context)
        {
            this.context = context;
            entities = context.Set<User>();
        }
        public long Login(string username, string password)
        {
            var data = entities.SingleOrDefault<User>(x => x.Email == username && x.Password == password);
            return data == null ? -1 : data.Id;
        }
    }
}
