using ATS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Service
{
    public interface IProfileService
    {
        Profile GetUserProfile(long id);
    }
}
