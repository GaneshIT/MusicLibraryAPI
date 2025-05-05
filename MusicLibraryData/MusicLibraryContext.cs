using Microsoft.EntityFrameworkCore;
using MusicLibraryEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibraryData
{
    public class MusicLibraryContext:DbContext
    {
        //To receive db connection from middleware
        //to generate Sql operations
        public MusicLibraryContext
            (DbContextOptions<MusicLibraryContext> options)
            :base(options) { }
       public DbSet<Album> albums { get;set; }//Generate Table
        //DbSet<Song> songs { get; set; }
        //
    }
}
