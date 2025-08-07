using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivMage.JsonBlueprints
{
    public class LibraryFile
    {
        public required byte[] Salt;
        public required string MD5;
        public required string Content; // List<LibraryContent>, verschlüsselt
    }
    public class LibraryContent
    {
        public required string Name;
        public required DateTime DateCreated;
        public required DateTime DateModified;
        public required List<string> Tags;
        public required int Id;
        public required byte[] Data;
    }
}
