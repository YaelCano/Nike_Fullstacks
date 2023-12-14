using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Domain.Entities;

namespace API.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Carrito_Compras, Carrito_ComprasDto>().ReverseMap();
            CreateMap<Categoria_Producto, Categoria_ProductoDto>().ReverseMap();
            CreateMap<ClienteCompra, ClienteCompraDto>().ReverseMap();
            CreateMap<Clientes, ClientesDto>().ReverseMap();
            CreateMap<Compra, CompraDto>().ReverseMap();
            CreateMap<Detalle_Producto, Detalle_ProductoDto>().ReverseMap();
            CreateMap<Pago, PagoDto>().ReverseMap();
            CreateMap<Producto, ProductoDto>().ReverseMap();
            CreateMap<Rol, RolDto>().ReverseMap();
            CreateMap<Usuario, UsuarioDto>().ReverseMap();
        }
    }
}
