using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data
{
    public class Nike_FullstacksContext : DbContext
    {
        public Nike_FullstacksContext(DbContextOptions<Nike_FullstacksContext> options) : base(options)
        {
        }

        public DbSet<Carrito_Compras> CarritoCompras { get; set; }
        public DbSet<Categoria_Producto> CategoriaProductos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<ClienteCompra> ClienteCompras { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Detalle_Producto> DetalleProductos { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioRoles> UsuarioRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetEntryAssembly());
        }
    }
}
