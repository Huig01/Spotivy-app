using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy_app.classes
{
    class Client
    {
        private iPlayable CurrentlyPlaying;
        private int CurrentTime;
        private bool Playing;
        private bool Shuffle;
        private bool repeat;
        public SuperUser ActiveUser;
        public List<Album> AllAlbums;
        public List<Song> AllSongs;
        public List<Person> AllUsers;
    }
}
