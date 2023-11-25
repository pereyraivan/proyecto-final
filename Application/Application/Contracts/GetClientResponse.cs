using Application.Models;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts
{
    
    public class GetClientResponse
    {
        public List<ClientDto>? ClientList { get; set; }
    }
}
