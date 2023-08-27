using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiterService.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public List<Product> Products { get; set; }
        public string Status { get; set; }

        public Table Table { get; set; }
        public OrderCard OrderCard { get; set; }
    }
}
