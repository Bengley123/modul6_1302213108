using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213108
{
    internal class SayaTubeUser
    {
        private int id;
        private SayaTubeUser[] uploadVideos = new SayaTubeUser[30];
        private string Username;
    }

    public SayaTubeUser(string Username)
    {
        this.Username = Username;
        int id = new Random().Next(10000, 99999);
    }

    public int GetTotalVieoPlayCount()
    {
        int total = 0;
        for(int i = 0; i<uploadVideos.Length; i++)
        {
            total += uploadVideos.Length;
        }
        return total;
    }

    public void AddVideo(SayaTubeUser video)
    {
        AddVideo.uploadVideos(video);
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine("User", this.Username);
        for (int i = 0; i < uploadVideos.Count || i < 8; i++)
        {
            Console.WriteLine("Video ");
        }

        Console.WriteLine("Video ke - 1 judulnya adalah: ", this);
        Console.WriteLine("Video ke - 2 judulnya adalah: ", this);
    }
}
