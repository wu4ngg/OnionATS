using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Data
{
    public class ProfileMap
    {
        public ProfileMap(EntityTypeBuilder<Profile> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Name);
            entityBuilder.Property(x => x.SurName);
            entityBuilder.Property(x => x.Address);
        }
    }
}
