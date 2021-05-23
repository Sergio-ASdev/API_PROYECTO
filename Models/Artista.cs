using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDepartamentosRDSMySql.Models
{
    [Table("Artista")]
    public class Artista
    {
        public Artista()
        {
        }

        public Artista(int idArtista, int idGenero, string nombre, string imagen, string descripcion)
        {
            this.IdArtista = idArtista;
            this.IdGenero = idGenero;
            this.Nombre = nombre;
            this.Imagen = imagen;
            this.Descripcion = descripcion;
        }

            public Artista(Artista artista)
            {
                this.IdArtista = artista.IdArtista;
                this.IdGenero = artista.IdGenero;
                this.Nombre = artista.Nombre;
                this.Imagen = artista.Imagen;
                this.Descripcion = artista.Descripcion;
            }

        [Key]
        [Column("IdArtista")]
        public int IdArtista { get; set; }

        [Column("IdGenero")]
        public int IdGenero { get; set; }

        [Column("Nombre")]
        public String Nombre { get; set; }

        [Column("Imagen")]
        public String Imagen { get; set; }

        [Column("Descripcion")]
        public String Descripcion { get; set; }
    }
}
