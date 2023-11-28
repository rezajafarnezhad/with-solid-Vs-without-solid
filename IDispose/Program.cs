namespace IDispose;

internal class Program
{
    static void Main(string[] args)
    {
        //const string path = @"C:\Users\mReza\source\repos\with solid Vs without solid\IDispose\aa.pdf";
        //using StreamReader reader = new StreamReader(path);
        //string content = reader.ReadToEnd();
        //Console.WriteLine(content);

        using (var gallery = new Gallery())
        {
            gallery.AddPhoto("Nature", "nature.jpg");
            gallery.AddPhoto("City", "city.jpg");
            gallery.DisplayPhotos();
        } 
    }
}

public class Photo  : IDisposable
{

    public string Name { get; set; }
    public string Path { get; set; }

    public void Display()
    {
        Console.WriteLine($"Displaying photo:{Name}");
    }
    public void Dispose()
    {
    }
}


public class Gallery : IDisposable
{
    private List<Photo> Photos = new();
    private bool disposed = false;
    public void AddPhoto(string name, string path)
    {
        var photo = new Photo()
        {
            Name = name,
            Path = path
        };
        Photos.Add(photo);
        Console.WriteLine($"Photo added to gallery: {name}");
    }

    public void DisplayPhotos()
    {
        foreach (var photo in Photos)
        {
            photo.Display();
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }


    protected virtual void Dispose(bool disposing)
    {
        if (disposed==false)
        {
            if (disposing)
            {
                foreach (var photo in Photos)
                {
                    photo.Dispose();
                }
                Console.WriteLine("Disposing managed resources (photos).");
            }
            Console.WriteLine("Disposing unmanaged resources.");
            disposed = true;
        }
    }
    ~Gallery()
    {
        Dispose(false);
    }
}

