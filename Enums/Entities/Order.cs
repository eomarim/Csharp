using System;
using Enums.Entities.Enums;

namespace Enums.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Momment  { get; set; }
        public OrderStatus Status {get; set;}


        public override string ToString()
        {
            return $"Id: {Id}, Momment: {Momment}, Status: {Status}";
        }

 
    }
}