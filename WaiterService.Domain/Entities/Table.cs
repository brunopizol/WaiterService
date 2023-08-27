using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiterService.Domain.Entities
{
    public class Table
    {
        public int Id { get; set; }
        public bool Status { get; set; }

        public List<Order> Order { get; set; }
        public OrderCard OrderCard { get; set; }
    }
}
