using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DbMusicList
{
    public sealed class Conection : IDesignTimeDbContextFactory<MusicListContext>
    {
        public MusicListContext CreateDbContext(string[] args)
        {
            var connectFile = File.ReadAllText("Appsetings.json");
            ConnectionString connect = JsonSerializer.Deserialize<ConnectionString>(connectFile);
            var cstring = connect.GetConnectionStrings.Cstring;
            var optionsBuilder = new DbContextOptionsBuilder<MusicListContext>();
            var options = optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(cstring)
                .Options;
            return new MusicListContext(options);
        }
    }
}
