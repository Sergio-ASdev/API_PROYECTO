using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDepartamentosRDSMySql.Models
{
    [Table("Album")]
    public class Album
    {
        [Key]
        [Column("IdAlbum")]
        public int IdAlbum { get; set; }

        [Column("IdArtista")]
        public int IdArtista { get; set; }

        [Column("Titulo")]
        public String Titulo { get; set; }

        [Column("Imagen")]
        public String Imagen { get; set; }
    }
}
