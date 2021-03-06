
using Microsoft.EntityFrameworkCore;
namespace Api.Workshop.Models
{
    [Owned]
    public record Address
    {
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }
}