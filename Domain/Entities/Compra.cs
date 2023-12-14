using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Compra : BaseEntity
    {
        public int IdProductoFk {get; set;}
        public Producto Productos {get; set;}
        public int Cantidad {get; set;}
        public double ValorUnit {get; set;}
        public ICollection<ClienteCompra> ClienteCompras {get; set;} 
    }
}
