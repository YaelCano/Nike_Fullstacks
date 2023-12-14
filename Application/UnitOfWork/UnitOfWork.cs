using Application.Repository;
using Core.Interfaces;
using Domain.Interfaces;
using Persistence.Data;
namespace Application.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly Nike_FullstacksContext _context;
    public UnitOfWork(Nike_FullstacksContext context)
    {
        _context = context;
    }
    public void Dispose()
    {
        _context.Dispose();
    }
    private ICarrito_Compras _carrito_compras;
    private ICategoria_Producto _categoria_productos;
    private IClienteCompra _clientecompras;
    private IClientes _clientes;
    private ICompra _compras;
    private IDetalle_Producto _detalle_productos;
    private IPago _pagos;
    private IProducto _productos;
    private IRefreshToken _refreshtokens;
    private IRol _roles;
    private IUsuario _usuarios;
    private IUsuarioRoles _usuarioroles;
    public ICarrito_Compras Carrito_Compras {
        get
        {
            if(_carrito_compras == null) 
            {
                _carrito_compras = new Carrito_ComprasRepository(_context);
            }
            return _carrito_compras;
        }
    }
    public ICategoria_Producto Categoria_Productos {
        get
        {
            if(_categoria_productos == null) 
            {
                _categoria_productos = new Categoria_ProductoRepository(_context);
            }
            return _categoria_productos;
        }
    }
    public IClienteCompra ClienteCompras {
        get
        {
            if(_clientecompras == null) 
            {
                _clientecompras = new ClienteCompraRepository(_context);
            }
            return _clientecompras;
        }
    }
    public IClientes Clientes {
        get
        {
            if(_clientes == null) 
            {
                _clientes = new ClientesRepository(_context);
            }
            return _clientes;
        }
    }
    public ICompra Compras {
        get
        {
            if(_compras == null) 
            {
                _compras = new CompraRepository(_context);
            }
            return _compras;
        }
    }
    public IDetalle_Producto Detalle_Productos {
        get
        {
            if(_detalle_productos == null) 
            {
                _detalle_productos = new Detalle_ProductoRepository(_context);
            }
            return _detalle_productos;
        }
    }
    public IPago Pagos {
        get
        {
            if(_pagos == null) 
            {
                _pagos = new PagoRepository(_context);
            }
            return _pagos;
        }
    }
    public IProducto Productos {
        get
        {
            if(_productos == null) 
            {
                _productos = new ProductoRepository(_context);
            }
            return _productos;
        }
    }
    public IRefreshToken RefreshTokens {
        get
        {
            if(_refreshtokens == null) 
            {
                _refreshtokens = new RefreshTokenRepository(_context);
            }
            return _refreshtokens;
        }
    }
    public IRol Roles {
        get
        {
            if(_roles == null) 
            {
                _roles = new RolRepository(_context);
            }
            return _roles;
        }
    }
    public IUsuario Usuarios {
        get
        {
            if(_usuarios == null) 
            {
                _usuarios = new UsuarioRepository(_context);
            }
            return _usuarios;
        }
    }
    public IUsuarioRoles UsuarioRoles {
        get
        {
            if(_usuarioroles == null) 
            {
                _usuarioroles = new UsuarioRolesRepository(_context);
            }
            return _usuarioroles;
        }
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
