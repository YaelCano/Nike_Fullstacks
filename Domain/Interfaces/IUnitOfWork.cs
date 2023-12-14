using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        ICarrito_Compras Carrito_Compras  { get; }
        ICategoria_Producto Categoria_Productos {get;}
        IClienteCompra ClienteCompras {get;}
        IClientes Clientess {get;}
        ICompra Compras {get;}
        IDetalle_Producto Detalle_Productos {get;}
        IPago Pagos {get;}
        IProducto Productos  {get;}
        IRol Roles  {get;}
        IUsuario Usuarios  {get;}
        IUsuarioRoles UsuarioRoless  {get;}

        Task<int> SaveAsync();
    }
}
