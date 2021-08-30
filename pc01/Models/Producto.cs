using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pc01.Models
{
    [Table("t_producto")]
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int id { get; set; }
        [Column("name")]
        public string name { get; set; }
        [Column("categoria")]
        public string categoria { get; set; }
        [Column("precio")]
        public Double precio {get; set;}
        [Column("descuento")]
        public Double descuento {get; set; }     
        
    }
}