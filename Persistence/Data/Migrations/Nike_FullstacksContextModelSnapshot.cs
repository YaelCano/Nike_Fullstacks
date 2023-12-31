﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Data;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(Nike_FullstacksContext))]
    partial class Nike_FullstacksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Carrito_Compras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CantidadProductosEnCarrito")
                        .HasColumnType("int");

                    b.Property<int?>("ClientesId")
                        .HasColumnType("int");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int");

                    b.Property<int>("IdproductoFk")
                        .HasColumnType("int");

                    b.Property<double>("PrecioTotalCarrito")
                        .HasColumnType("double");

                    b.Property<string>("ProductoEnCarrito")
                        .HasColumnType("longtext");

                    b.Property<int?>("ProductosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientesId");

                    b.HasIndex("ProductosId");

                    b.ToTable("CarritoCompras");
                });

            modelBuilder.Entity("Domain.Entities.Categoria_Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("CategoriaProductos");
                });

            modelBuilder.Entity("Domain.Entities.ClienteCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClientesId")
                        .HasColumnType("int");

                    b.Property<int?>("ComprasId")
                        .HasColumnType("int");

                    b.Property<string>("DireccionCliente")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FechaTransaccion")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdCompraFk")
                        .HasColumnType("int");

                    b.Property<int>("IdMetodoPagoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdclienteFk")
                        .HasColumnType("int");

                    b.Property<int?>("PagosId")
                        .HasColumnType("int");

                    b.Property<double>("ValorTotaltrans")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ClientesId");

                    b.HasIndex("ComprasId");

                    b.HasIndex("PagosId");

                    b.ToTable("ClienteCompras");
                });

            modelBuilder.Entity("Domain.Entities.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellidos")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombres")
                        .HasColumnType("longtext");

                    b.Property<double>("NroContacto")
                        .HasColumnType("double");

                    b.Property<string>("direccion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Domain.Entities.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdProductoFk")
                        .HasColumnType("int");

                    b.Property<int?>("ProductosId")
                        .HasColumnType("int");

                    b.Property<double>("ValorUnit")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ProductosId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("Domain.Entities.Detalle_Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DetallesAdicionalesPro")
                        .HasColumnType("longtext");

                    b.Property<int>("IdProductoFk")
                        .HasColumnType("int");

                    b.Property<int?>("ProductosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductosId");

                    b.ToTable("DetalleProductos");
                });

            modelBuilder.Entity("Domain.Entities.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Categoria_ProductosId")
                        .HasColumnType("int");

                    b.Property<int>("IdcategoriaFk")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<double>("Precio")
                        .HasColumnType("double");

                    b.Property<int>("StockDisponible")
                        .HasColumnType("int");

                    b.Property<string>("UrlImagen")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Categoria_ProductosId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Domain.Entities.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Token")
                        .HasColumnType("longtext");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Rols");
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Domain.Entities.UsuarioRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("UsuarioRoles");
                });

            modelBuilder.Entity("RolUsuario", b =>
                {
                    b.Property<int>("RolesId")
                        .HasColumnType("int");

                    b.Property<int>("UsuariosId")
                        .HasColumnType("int");

                    b.HasKey("RolesId", "UsuariosId");

                    b.HasIndex("UsuariosId");

                    b.ToTable("RolUsuario");
                });

            modelBuilder.Entity("Domain.Entities.Carrito_Compras", b =>
                {
                    b.HasOne("Domain.Entities.Clientes", "Clientes")
                        .WithMany("Carrito_Compras")
                        .HasForeignKey("ClientesId");

                    b.HasOne("Domain.Entities.Producto", "Productos")
                        .WithMany("Carrito_Compras")
                        .HasForeignKey("ProductosId");

                    b.Navigation("Clientes");

                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Domain.Entities.ClienteCompra", b =>
                {
                    b.HasOne("Domain.Entities.Clientes", "Clientes")
                        .WithMany("ClienteCompras")
                        .HasForeignKey("ClientesId");

                    b.HasOne("Domain.Entities.Compra", "Compras")
                        .WithMany("ClienteCompras")
                        .HasForeignKey("ComprasId");

                    b.HasOne("Domain.Entities.Pago", "Pagos")
                        .WithMany("ClienteCompras")
                        .HasForeignKey("PagosId");

                    b.Navigation("Clientes");

                    b.Navigation("Compras");

                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("Domain.Entities.Compra", b =>
                {
                    b.HasOne("Domain.Entities.Producto", "Productos")
                        .WithMany("Compras")
                        .HasForeignKey("ProductosId");

                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Domain.Entities.Detalle_Producto", b =>
                {
                    b.HasOne("Domain.Entities.Producto", "Productos")
                        .WithMany("Detalle_Productos")
                        .HasForeignKey("ProductosId");

                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.HasOne("Domain.Entities.Categoria_Producto", "Categoria_Productos")
                        .WithMany("Productos")
                        .HasForeignKey("Categoria_ProductosId");

                    b.Navigation("Categoria_Productos");
                });

            modelBuilder.Entity("Domain.Entities.RefreshToken", b =>
                {
                    b.HasOne("Domain.Entities.Usuario", "Usuario")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.Entities.UsuarioRoles", b =>
                {
                    b.HasOne("Domain.Entities.Rol", "Rol")
                        .WithMany("UsuarioRoles")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Usuario", "Usuarios")
                        .WithMany("UsuarioRoles")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("RolUsuario", b =>
                {
                    b.HasOne("Domain.Entities.Rol", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UsuariosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Categoria_Producto", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Domain.Entities.Clientes", b =>
                {
                    b.Navigation("Carrito_Compras");

                    b.Navigation("ClienteCompras");
                });

            modelBuilder.Entity("Domain.Entities.Compra", b =>
                {
                    b.Navigation("ClienteCompras");
                });

            modelBuilder.Entity("Domain.Entities.Pago", b =>
                {
                    b.Navigation("ClienteCompras");
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Navigation("Carrito_Compras");

                    b.Navigation("Compras");

                    b.Navigation("Detalle_Productos");
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Navigation("UsuarioRoles");
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.Navigation("RefreshTokens");

                    b.Navigation("UsuarioRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
