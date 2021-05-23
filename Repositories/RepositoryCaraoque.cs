using ServiceDepartamentosRDSMySql.Data;
using ServiceDepartamentosRDSMySql.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDepartamentosRDSMySql.Repositories
{
    public class RepositoryCaraoque
    {
        private CaraoqueContext context;

        public RepositoryCaraoque(CaraoqueContext context)
        {
            this.context = context;
        }

        public List<Album> GetAlbums()
        {
            return this.context.Albums.ToList();
        }

        public AlbumFull GetAlbum(int id)
        {
            List<Cancion> canciones =  this.context.Cancion.Where(x => x.IdAlbum == id).ToList();

            return new AlbumFull(this.context.Albums.SingleOrDefault(x => x.IdAlbum == id), canciones);
        }

        public ArtistaFull GetArtistFull(int id)
        {
            var consulta = this.context.Albums.Where(x => x.IdArtista == id);
            List<Album> albumes = consulta.ToList();
            Artista artista = new Artista(this.context.Artistas.SingleOrDefault(x => x.IdArtista == id));
            ArtistaFull art = new ArtistaFull(artista, albumes);

            return art;
        }

        public List<Artista> GetArtistas()
        {
            return this.context.Artistas.ToList();
        }

        public Artista GetArtista(int id)
        {
            return this.context.Artistas.SingleOrDefault(x => x.IdArtista == id);
        }

        public List<Cancion> GetCanciones()
        {
            return this.context.Cancion.OrderBy(x => x.Titulo).ToList();
        }

        /*
        public ArtistaFull GetAlbumesArtista(int id)
        {
            var consulta = this.context.Albums.Where(x => x.IdArtista == id);
            List<Album> albumes = consulta.ToList();
            Artista artista = new Artista(this.context.Artistas.SingleOrDefault(x => x.IdArtista == id));
            ArtistaFull art = new ArtistaFull(artista, albumes);

            return art;
        }
        */

        public Cancion GetCancion(int id)
        {
            return this.context.Cancion.SingleOrDefault(x => x.IdCancion == id);
        }

        public List<Genero> GetGeneros()
        {
            return this.context.Generos.ToList();
        }

    }
}
