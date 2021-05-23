using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDepartamentosRDSMySql.Models
{
    public class ArtistaFull
    {
     public ArtistaFull(Artista artista, List<Album> albumes)
        {
            this.IdArtista = artista.IdArtista;
            this.IdGenero = artista.IdGenero;
            this.Nombre = artista.Nombre;
            this.Imagen = artista.Imagen;
            this.Descripcion = artista.Descripcion;
            this.albumes = albumes;
        }
            public int IdArtista { get; set; }
            public int IdGenero { get; set; }

            public String Nombre { get; set; }

            public String Imagen { get; set; }

            public String Descripcion { get; set; }

            public List<Album> albumes { get; set; }
        }
   
}
