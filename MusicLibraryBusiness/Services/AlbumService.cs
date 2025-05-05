using MusicLibraryData.Repository;
using MusicLibraryEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibraryBusiness.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly IAlbumRepository _albumRepository;
        public AlbumService(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }
        public void Create(Album album)
        {
            //business logic
            _albumRepository.Create(album);
        }
        public List<Album> GetAll()
        {
            //business logic
            return _albumRepository.GetAll();
        }
        public void Update(Album album)
        {
            _albumRepository.Update(album);//calling repo
        }
        public void Delete(int id)
        {   
            _albumRepository.Delete(id);//calling repo
        }
        public Album GetById(int id)
        {
            return _albumRepository.Get(id);//calling repo
        }
    }
}
