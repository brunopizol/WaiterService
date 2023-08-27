using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiterService.Domain.Entities
{
    public class OrderCard
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
        

        public Table Table { get; set; }
        public List<Order> Orders { get; set; }
    }
}
