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
    [Table("ProductTypes")]
    public class ProductType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;      

    }
}
