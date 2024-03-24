using System;

namespace tpmodul6_1302220112;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;
    public SayaTubeVideo(string title)
    {
        if (title == null || title.Length > 100) 
            throw new ArgumentException("Judul video maksimal 100 karakter dan tidak boleh null.");
        Random random = new();
        this.title = title;
        id = random.Next(10000, 99999);
        playCount = 0;
    }
    public void increasePlayCount(int jumlah)
    {
        if (jumlah > 10000000 || jumlah < 0)
        {
            throw new ArgumentOutOfRangeException("Jumlah harus diantara 0 sampai 10.000.000");
        }
        try
        {
            checked
            {
                playCount = playCount + jumlah;
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("OverFlow Execption: " + ex.Message);
        }
        
    }
    public void printVideoPlaylist()
    {
        Console.WriteLine("=================");
        Console.WriteLine("ID Video : " + id);
        Console.WriteLine("Title    : " + title);
        Console.WriteLine("Played   : " +  playCount + " times");
        Console.WriteLine("=================");
    }

}
public class Program
{
    public static void Main(string[] args)
    {
        //Testing Prekondisi
        Console.WriteLine("Testing Prekondisi");
        try
        {
            SayaTubeVideo video = new SayaTubeVideo(null);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Argument Exception: " + ex.Message);
        }

        //Testing Exception
        Console.WriteLine("\nTesting Exception");
        try
        {
            SayaTubeVideo sayaTube = new SayaTubeVideo("Tutorial Design By Contract - Syauqi Dhiya Ulhaq");
            sayaTube.increasePlayCount(100000000);
            sayaTube.printVideoPlaylist();
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Argument Out Of Range Exception: " + ex.Message);
        }

        //Real case
        Console.WriteLine("\nTesting Real Case (Running sebelum ada Execption)");
        SayaTubeVideo sayaTubeVid = new SayaTubeVideo("Tutorial Design By Contract - Syauqi Dhiya Ulhaq");
        sayaTubeVid.increasePlayCount(50);
        sayaTubeVid.printVideoPlaylist();
    }
}