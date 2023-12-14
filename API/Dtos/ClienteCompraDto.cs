using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks; 

namespace API.Dtos; 
    public class ClienteCompraDto : BaseDto
    { 
        public int Id { get; set; }
        public int IdClienteFk { get; set; }
        public int IdCompraFk { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public double ValorTotalTransaccion { get; set; }
        public int IdMetodoPagoFk { get; set; }
        public string ? DireccionCliente { get; set; }
    } 
