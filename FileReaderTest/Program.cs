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
            var filename = @"C:\Music\Robot\47 - Up to Here\01 - Blow at High Dough.flac";
            var f = TagLib.File.Create(filename);
            var tags = f.Tag;
            Console.Write("Read: {0}", tags.Title);
            Console.ReadKey();

        }
    }
}
