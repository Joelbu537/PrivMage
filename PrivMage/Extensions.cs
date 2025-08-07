using PrImage.JsonBlueprints;
using PrivMage.JsonBlueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivMage.Extensions
{
    public static class ExtensionMethods
    {
        public static List<JsonBlueprints.Image> SortImages(this List<JsonBlueprints.Image> images)
        {
            if (images == null || images.Count == 0)
                return images;
            // Sort by ID
            return images.OrderBy(image => image.id).ToList();
        }
    }
}
