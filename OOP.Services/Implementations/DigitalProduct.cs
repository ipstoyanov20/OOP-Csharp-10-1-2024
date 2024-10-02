namespace Services.Implementations;

public class DigitalProduct : Product
{
    public string DownloadLink { get; set; }

    public void ProvideDownloadLink()
    {
        Console.WriteLine($"Download link for {Name}: {DownloadLink}");
    }
}