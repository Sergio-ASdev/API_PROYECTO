using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDepartamentosRDSMySql.Models
{
    public class AlbumFull
    {
        public AlbumFull(Album album, List<Cancion> canciones)
        {
            this.IdAlbum = album.IdAlbum;
            this.IdArtista = album.IdArtista;
            this.Titulo = album.Titulo;
            this.Imagen = album.Imagen;
            this.Canciones = canciones;
        }
        public int IdAlbum { get; set; }

        public int IdArtista { get; set; }

        public String Titulo { get; set; }

        public String Imagen { get; set; }

        public List<Cancion> Canciones { get; set; }
    }
}
