using MusicLibraryEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibraryBusiness.Services
{
    public interface IAlbumService
    {
        void Create(Album album);
        List<Album> GetAll();
        void Delete(int id);
        void Update(Album album);
        Album GetById(int id);
    }
}
