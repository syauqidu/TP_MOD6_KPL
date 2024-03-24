using System;

namespace tpmodul6_1302220112;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;
    public SayaTubeVideo(string title)
    {
        Random random = new();
        this.title = title;
        id = random.Next(10000, 99999);
        playCount = 0;
    }
    public void increasePlayCount(int jumlah)
    {
        playCount = playCount + jumlah;
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
        SayaTubeVideo sayaTube = new SayaTubeVideo("Tutorial Design By Contract - Syauqi Dhiya Ulhaq");
        sayaTube.increasePlayCount(50);
        sayaTube.printVideoPlaylist();
    }
}