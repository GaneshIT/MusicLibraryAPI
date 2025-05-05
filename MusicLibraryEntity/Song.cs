using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibraryEntity
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("Album")]
        public int AlbumId { get; set; }
        public Album? Album { get; set; }//Primary table

    }
}
