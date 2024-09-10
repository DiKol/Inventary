using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mbr.Inventary.Infrastructure.Database.Entity
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
        public string Cost { get; set; } = string.Empty;

    }
}
