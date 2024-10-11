using ATS.Data;
using ATS.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Service
{
    public class ProfileService : IProfileService
    {
        private IRepository<Profile> profileRepository;

        public ProfileService(IRepository<Profile> profileRepository)
        {
            this.profileRepository = profileRepository;
        }
        public Profile GetUserProfile(long id)
        {
            return this.profileRepository.Get(id);
        }
    }
}
