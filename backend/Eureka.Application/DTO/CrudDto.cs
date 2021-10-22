using System;

namespace Eureka.Application.DTO
{
    public class CrudDto
    {
        public Guid? Id { get; set; }
        public string Email { get; set; }
        public decimal Value { get; set; }
    }
}
