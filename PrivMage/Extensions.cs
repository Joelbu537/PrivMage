using PrImage.JsonBlueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivMage
{
    public static class ExtensionMethods
    {
        public static List<> Sort(this List<Image> images)
        {
            if (images == null || images.Count == 0)
                return images;
            // Sort by ID
            return images.OrderBy(image => image.id).ToList();
        }
    }
}
