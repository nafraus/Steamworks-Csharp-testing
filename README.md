How to use.

Given that you have C# installed, you should just be able to enter 'dotnet run' into your console.

If you get an error about not being able to find SteamAPI, or Steamworks, etc. enter 'dotnet add package Steamworks.NET'

If that doesn't fix it, it will just be easier to make a new dotnet project from scratch by doing the following:

Copy the dll files or download them from here: https://github.com/rlabrecque/Steamworks.NET/releases/download/2024.8.0/Steamworks.NET-Standalone_2024.8.0.zip
(If your pc is 32 bit do not use the dll files from this repo)

Enter 'dotnet new console -n SteamworksTest'
Copy the two dll files into the new folder
'cd SteamworksTest'
'dotnet add package Steamworks.NET'
'dotnet run'

That should do it. 
I'm sorry if it doesn't.
