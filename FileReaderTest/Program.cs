using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var filename = @"E:\music\flac\Let's Eat Grandma\I, Gemini\03 Let's Eat Grandma - Sax In The City.flac";
            var f = TagLib.File.Create(filename);
            var tags = f.Tag;
            Console.Write("Read: {0}", tags.Title);
            Console.ReadKey();

        }
    }
}
