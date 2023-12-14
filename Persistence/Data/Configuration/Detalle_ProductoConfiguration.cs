using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class Detalle_ProductoConfiguration : IEntityTypeConfiguration<Detalle_Producto>
    {
        public void Configure(EntityTypeBuilder<Detalle_Producto> builder)
        {

        }
    }
}
