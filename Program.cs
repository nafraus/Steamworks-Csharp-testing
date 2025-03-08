using System;
using Steamworks;

class Program
{
    static void Main()
    {
        if (!Packsize.Test())
        {
            Console.WriteLine("[Error] Steamworks.NET Packsize test failed.");
            return;
        }
        if (!DllCheck.Test())
        {
            Console.WriteLine("[Error] Steamworks.NET DLL test failed.");
            return;
        }
        if (!SteamAPI.Init())
        {
            Console.WriteLine("[Error] SteamAPI initialization failed. Make sure Steam is running.");
            return;
        }

        Console.WriteLine("[Success] Steamworks initialized.");
        Console.WriteLine("Logged in as: " + SteamFriends.GetPersonaName());
    }
}
