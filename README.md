# Steamworks.NET Console App Setup (64-bit)

## How to Use

### Prerequisites
- Ensure you have **C# (.NET SDK)** installed on your system.
- **Steam must be running** for Steamworks.NET functions to work.

### Running the Project
Simply enter the following command in your terminal:
```sh
dotnet run
```

### Troubleshooting
#### Missing Steamworks.NET or SteamAPI Errors
If you encounter an error about missing **SteamAPI** or **Steamworks**, try installing the Steamworks.NET package:
```sh
dotnet add package Steamworks.NET
```

#### Starting Over (Fresh Setup)
If errors persist, it's easier to create a new .NET console project from scratch:

1. **Download Steamworks.NET DLLs:**  
   - Download from [this link](https://github.com/rlabrecque/Steamworks.NET/releases/download/2024.8.0/Steamworks.NET-Standalone_2024.8.0.zip).  
   - ⚠️ **Do not use these DLLs if your PC is 32-bit.**

2. **Create a new .NET Console Project:**
   ```sh
   dotnet new console -n SteamworksTest
   ```

3. **Copy the downloaded DLL files** into the newly created `SteamworksTest` folder.

4. **Navigate into the project folder:**
   ```sh
   cd SteamworksTest
   ```

5. **Install Steamworks.NET:**
   ```sh
   dotnet add package Steamworks.NET
   ```

6. **Run the project:**
   ```sh
   dotnet run
   ```

That should do it! 🚀

If it still doesn't work, I'm sorry. 😞 Let me know if you need more help!

