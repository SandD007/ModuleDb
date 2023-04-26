using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbMusicList.DbModels
{
    public class Genre
    {
        public int GenereId { get; set; }

        public string Title { get; set; }

        public virtual List<Song> Songs { get; set; } = new List<Song>();
    }
}
