using System;

namespace Eureka.Domain.Model
{
    public class Crud
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public decimal Value { get; set; }

        public Crud() { }
    }
}
