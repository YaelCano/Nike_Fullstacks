using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;

namespace Domain.Entities
{
    public class Producto : BaseEntity
    {
        public string Nombre {get; set;}
        public double  Precio {get; set;}
        public int IdcategoriaFk {get; set;}
        public Categoria_Producto Categoria_Productos {get; set;}
        public string Marca {get; set;}
        public string UrlImagen {get; set;}
        public int StockDisponible {get; set;}
        public ICollection<Carrito_Compras> Carrito_Compras {get; set;}
        public ICollection<Compra> Compras {get; set;}
        public ICollection<Detalle_Producto> Detalle_Productos {get; set;}
    }
}
