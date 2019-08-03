using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Songs.Data;

namespace EF_Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var db = new SongsDB())
            //{
            //    if (!db.Songs.Any())
            //    {
            //        var songs = new Song[100];
            //        for (var i = 0; i < songs.Length;i++)
            //            songs[i] = new Song
            //            {
            //                Name=$"Песня{i+1}",
            //                Artist = new Artist { Name=$"Исполнитель {i}"}
            //            };
            //        db.Songs.AddRange(songs);

            //        db.SaveChanges();
            //    }
            //}

            //using (var db = new SongsDB())
            //{
            //    db.Database.Log = str => Console.WriteLine(str); // Указыаем контексту БД куда писать лог

            //    var song = db.Songs.FirstOrDefault(s => s.Artist.Name == "Исполнитель 8");
            //    if (song != null)
            //        db.Songs.Remove(song);

            //    db.SaveChanges();
            //}

            //using (var db = new SongsDB())
            //{
            //    foreach (var song in db.Songs.ToArray())
            //    {
            //        Console.WriteLine("Song {0} - artist {1}", song.Name, song.Artist.Name);
            //    }
            //}

            using (var db = new SongsDB())
            {
                Console.WriteLine("Songs count - {0}", db.Songs.Count());
            }

            Console.ReadLine();
        }
    }
}
