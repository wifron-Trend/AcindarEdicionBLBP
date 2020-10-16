using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_LaminacionBLBP.Models
{
    public class LamblbpDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column ( TypeName = "nvarchar(4000)")]
        public string Planta { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime EstampaTiempo { get; set; }
        [Required]
        [Column(TypeName = "smallint")]
        public int LaminadorPalanquillaslaminadasUltimahora { get; set; }
        [Required]
        [Column(TypeName = "real")]        
        public float LaminadorBarrasperdidasUltimahora { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(4000)")]
        public string Plantel { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(4000)")]
        public string Turno { get; set; }
        [Required]
        [Column(TypeName = "tinyint")]        
        public int Cantidadturnos { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime Fechalaminador { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime Modificado { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Modificadopor { get; set; }
    }
}
