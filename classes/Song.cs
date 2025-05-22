using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy_app.classes
{
    public enum Genre
    {
        HIPHOP,
        ROCK,
        JAZZ,
        POP

    }
    class Song
    {
        public string title;
        public List<Artist> Artists;
        public Genre SongGenre;
        private int Duration;
    }
}
