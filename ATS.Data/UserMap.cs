using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Data
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.UserName).IsRequired();
            entityBuilder.Property(x => x.Email).IsRequired();
            entityBuilder.Property(x => x.Password).IsRequired();
            entityBuilder.HasOne(x => x.Profile).WithOne(x => x.User).HasForeignKey<Profile>(x => x.Id);
        }
    }
}
