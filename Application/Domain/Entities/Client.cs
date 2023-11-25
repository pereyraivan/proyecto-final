using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Client
    {
        public int id_cliente { get; set; }
        public string? nombre { get; set; }
        public string? direccion { get; set; }
        public string? ciudad { get; set; }
        public string? provincia { get; set; }
        public string? zona { get; set; }
    }
}
