using System;
using System.IO;

namespace BinaryFileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // you should point at a valid .bmp file on your machine/drive
            string fileName = @"C:\Users\thecr\Downloads\sps.bmp";

            // choosing a suitable size of buffer
            const int bufferSize = 16;
            byte[] buffer = new byte[bufferSize];
            int count;
            List<int> colours = new List<int>();
            long sz = new FileInfo(fileName).Length;
            int black = 0;
            int filesize=0;
            // note the alternative use of the using keyword
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                // loop through the file, the read command returns the number of characters read, up to the limit in the third argument
                while ((count = reader.Read(buffer, 0, buffer.Length)) != 0)
                {
                    for (int i = 0; i < bufferSize; i++)
                    {
                        if (i < count)
                            Console.Write("{0:x2} ", buffer[i]);
                        if (buffer[i] == 00)
                        {
                            black++;
                        }
                        filesize++;
                        if (colours.Contains(buffer[i]) == false){
                            colours.Add(buffer[i]); 
                        }
                    }
                    
                    Console.WriteLine();
                }
            }
            Console.WriteLine(black);
            colours.Sort();
            Console.WriteLine(colours.Count);
            Console.WriteLine(filesize);
        }
    }
}