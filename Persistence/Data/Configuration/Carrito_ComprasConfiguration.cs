using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class Carrito_ComprasConfiguration : IEntityTypeConfiguration<Carrito_Compras>
    {
        public void Configure(EntityTypeBuilder<Carrito_Compras> builder)
        {

        }
    }
}
