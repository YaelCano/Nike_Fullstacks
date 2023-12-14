using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ClienteCompra : BaseEntity
    {
        public int IdclienteFk {get; set;}
        public Clientes Clientes {get; set;}
        public int IdCompraFk {get; set;}
        public Compra Compras {get; set;}
        public DateTime FechaTransaccion {get; set;}
        public double ValorTotaltrans {get; set;}
        public int IdMetodoPagoFk {get; set;}
        public Pago Pagos {get; set;}
        public string DireccionCliente {get; set;}
    }
}
