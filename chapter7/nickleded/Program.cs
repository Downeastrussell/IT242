using System;
using System.Collections.Generic;

namespace nickleded
{
    class Program
    {
        static void Main(string[] args)
        {


            Dictionary<string, string> goodsongs = new Dictionary<string, string>();

            List<Dictionary<string, string>> listOfCrap = new List<Dictionary<string, string>>();

            HashSet<Dictionary<string, string>> allSongs = new HashSet<Dictionary<string, string>>();


            Dictionary<string, string> one = new Dictionary<string, string>(){
                {"nickleback", "how you remind me"}
            };
                        Dictionary<string, string> two = new Dictionary<string, string>(){
                {"notnickleback1", "!!!!!!"}
            };
                        Dictionary<string, string> three = new Dictionary<string, string>(){
                {"notnickleback", "??????"}
            };
                        Dictionary<string, string> four = new Dictionary<string, string>(){
                {"nickleback", "burn it down"}
            };

            allSongs.Add(one);
            allSongs.Add(two);
            allSongs.Add(three);
            allSongs.Add(four);

           foreach (Dictionary<string, string> list in allSongs)
       {Console.WriteLine("");
    foreach(KeyValuePair<string, string> word in list)
     {  string artist = word.Key;
        string song = word.Value;

        if(word.Key!="nickleback"){

            goodsongs.Add(artist, song);
        }
     };
     }

     foreach(KeyValuePair<string, string> song in goodsongs){
         Console.WriteLine($"{song.Key} is a good band, {song.Value} is a good song");
     }









        }
    }
}
