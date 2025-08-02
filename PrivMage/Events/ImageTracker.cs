using System.Diagnostics;

public static class ImageTracker
{
    private static readonly List<WeakReference> _images = new();

    public static void Track(Image img)
    {
        if (img != null)
            _images.Add(new WeakReference(img));
    }

    public static void Report()
    {
        int alive = 0;
        foreach (var wr in _images)
        {
            if (wr.IsAlive)
                alive++;
        }

        Debug.WriteLine($"[ImageTracker] Alive images: {alive} / {_images.Count}");
    }
}