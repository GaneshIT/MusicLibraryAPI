using MusicLibraryEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibraryData.Repository
{
    public class AlbumRepository : IAlbumRepository
    {
        private readonly MusicLibraryContext _musicLibraryContext;
        public AlbumRepository(MusicLibraryContext musicLibraryContext  )
        {
            _musicLibraryContext = musicLibraryContext;
        }
        public void Create(Album album)
        {
            //insert into albums values(album.id,album.name,album.desc)
            _musicLibraryContext.albums.Add( album );
            _musicLibraryContext.SaveChanges();//Execute sql
        }
        public void Delete(int id)
        {
            //select * from albums where id=id;
            var album = _musicLibraryContext.albums.Find(id);
            //delete from albums where id=id
            _musicLibraryContext.albums.Remove( album );
            _musicLibraryContext.SaveChanges();//execute sql
        }
        public Album Get(int id)
        {
            //select * from albums where id=id;
            var album = _musicLibraryContext.albums.Find(id);
            return album;
        }
        public List<Album> GetAll()
        {
            //select * from albums
            return _musicLibraryContext.albums.ToList();
        }
        public void Update(Album album)
        {
            //update album set name=album.name,
            //desc=album.desc where id=album.id
            _musicLibraryContext.albums.Update( album );
            _musicLibraryContext.SaveChanges();//execute
        }
    }
}
