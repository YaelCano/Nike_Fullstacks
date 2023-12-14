using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks; 

namespace API.Dtos; 
    public class CompraDto : BaseDto
    { 
        public int Id { get; set; }
        public int IdProductoFk { get; set; }
        public int Cantidad { get; set; }
        public double ValorUnitUSD { get; set; }

        public List<ClienteCompraDto> ? ClienteCompras { get; set; }
    } 
