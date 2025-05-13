using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Execise01{
    //2.1.1
    public class Song {
        public string Title { get; private set; } = string.Empty;
        public string ArtistName { get; private set; } = string.Empty;
        public int Length { get; set; }


        //2.1.2
        public Song(string title, string artistName, int length) {
            Title = title;
            ArtistName = artistName;
            Length = length;
        }   

    }
}
