using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks; 

namespace API.Dtos; 
    public class ClientesDto : BaseDto
    { 
        public int Id { get; set; }
        public string ? Nombres { get; set; }
        public string ? Apellidos { get; set; }
        public string ? Direccion { get; set; }
        public double NroContacto { get; set; }

        public List<ClienteCompraDto> ? ClienteCompras { get; set; }
        public List<Carrito_ComprasDto> ? CarritoCompras { get; set; }
    } 
