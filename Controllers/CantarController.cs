using ServiceDepartamentosRDSMySql.Models;
using ServiceDepartamentosRDSMySql.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDepartamentosRDSMySql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CantarController : ControllerBase
    {
        private RepositoryCaraoque repo;

        public CantarController(RepositoryCaraoque repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Cancion>> Canciones()
        {
            return this.repo.GetCanciones();
        }
              
        [HttpGet("Albumes/")]
        public ActionResult<List<Album>> Albums()
        {
            return this.repo.GetAlbums();
        }

        [HttpGet("Album/{id:int}")]
        public ActionResult<AlbumFull> Album(int id)
        {
            return this.repo.GetAlbum(id);
        }

        [HttpGet("Artistas/")]
        public ActionResult<List<Artista>> Artistas()
        {
            return this.repo.GetArtistas();
        }

        [HttpGet("Artista/{id:int}")]
        public ActionResult<ArtistaFull> Artista(int id)
        {
            return this.repo.GetArtistFull(id);
        }
        
        [HttpGet("ObtenerCancion/{id:int}")]
        public ActionResult<Cancion> ObtenerCancion(int id)
        {
            return this.repo.GetCancion(id);
        }
        

    }
}
