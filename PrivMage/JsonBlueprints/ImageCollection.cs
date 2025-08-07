using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrivMage.JsonBlueprints
{
    public class ImageCollection
    {
        public required string MD5;
        public required string Content; // List<Image>, encrypted
    }
    public class Image
    {
        public required byte[] data { get; set; }
        public int id { get; set; }
        public static List<Image> Sort()
        {

        }
    }
}