using ATS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Repo
{
    public interface IAuthRepository
    {
        long Login(string username, string password);
    }
}
