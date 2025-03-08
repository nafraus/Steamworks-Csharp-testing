using System;
using Steamworks;

class Program
{
    static void Main()
    {
        Callback<LobbyEnter_t>  m_LobbyEnter;
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
        m_LobbyEnter = Callback<LobbyEnter_t>.Create(OnLobbyEnter);

        CSteamID steamId = new CSteamID(109775244133711630);

        bool foundLobby = SteamMatchmaking.RequestLobbyData(steamId);
        Console.WriteLine("Found lobby: " + foundLobby);

        if (foundLobby) SteamMatchmaking.JoinLobby(steamId);

        // Keep the program running and process Steam callbacks
        while (true)
        {
            SteamAPI.RunCallbacks();
            Thread.Sleep(100); // Prevent CPU overload
        }
    }

    static void OnLobbyEnter(LobbyEnter_t result)
    {
        Console.WriteLine(result.m_EChatRoomEnterResponse);
        if (result.m_EChatRoomEnterResponse == 1)
        {
            Console.WriteLine("Successfully joined lobby.");
        }
        else
        {
            Console.WriteLine("Failed to join lobby.");
        }
    }
}
