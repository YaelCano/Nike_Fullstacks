using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Carrito_Compras : BaseEntity
    {
        public int IdClienteFk{get; set;}
        public Clientes ? Clientes {get; set;}
        public int IdproductoFk {get; set;}
        public Producto ? Productos {get; set;}
        public string ? ProductoEnCarrito {get; set;}
        public int CantidadProductosEnCarrito {get; set;}
        public double PrecioTotalCarrito {get; set;}

    }
}
