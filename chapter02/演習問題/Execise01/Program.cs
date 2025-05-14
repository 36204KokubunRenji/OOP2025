using System.Reflection;
using System.Xml.Serialization;

namespace Execise01 {
    public class Program {
        static void Main(string[] args) {
            //2.1.3
            while (true) {
                var songs = new List<Song>();

                Console.WriteLine("*** 曲の登録 ***");

                Console.WriteLine("曲名：");
                String? title = Console.ReadLine();
                if (title.Equals("end", StringComparison.OrdinalIgnoreCase))
                    break;

                Console.WriteLine("アーティスト名：");
                string? artistname = Console.ReadLine();

                Console.WriteLine("演奏時間（秒）：");
                int length = int.Parse(Console.ReadLine());

                //Song song = new Song(title, artistname, length);
                Song song = new Song() {
                    Title = title,
                    ArtistName = artistname,
                    Length = length
                };
                songs.Add(song);

                Console.WriteLine();


                printSongs(songs);
            }
        }

        //2.1.4
        private static void printSongs(IEnumerable<Song> songs) {
#if false
            foreach (var song in songs) {
                var minutes = song.Length / 60;
                var seconds = song.Length % 60;
                Console.WriteLine($"{song.Title}, {song.ArtistName} {minutes}:{seconds:00}");
            }
#else
            //TimeSpan構造体を使った場合
            foreach (var song in songs) {
                var timespan = TimeSpan.FromSeconds(song.Length);
                Console.WriteLine($"{song.Title}, {song.ArtistName} {timespan.Minutes}:{timespan.Seconds:00}");
            }
            //または以下でも可
            foreach (var song in songs) {
                Console.WriteLine(@"{0},{1},{2:m\:ss}",
                    song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));
            }
#endif
            Console.WriteLine();
        }
    }
}
