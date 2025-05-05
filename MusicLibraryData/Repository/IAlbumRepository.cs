using MusicLibraryEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibraryData.Repository
{
    public interface IAlbumRepository
    {
        void Create(Album album);
        void Update(Album album);
        void Delete(int id);
        Album Get(int id);
        List<Album> GetAll();
    }
}
