using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDepartamentosRDSMySql.Models
{
    [Table("Cancion")]
    public class Cancion
    {
        [Key]
        [Column("IdCancion")]
        public int IdCancion { get; set; }

        [Column("IdAlbum")]
        public int IdAlbum { get; set; }

        [Column("Titulo")]
        public String Titulo { get; set; }

        [Column("Youtube")]
        public String Youtube { get; set; }

        [Column("LRC")]
        public String LRC { get; set; }
    }
}
