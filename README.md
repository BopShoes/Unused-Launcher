# Unused Launcher
This is the official Unused Launcher<br>Unused is a private 2010L/2013L revival.<br>If you do want a chance of getting in,<br>DM autoimi on discord.
## Step 1: Setting up URI
URI doesn't come with this project.<br>Make a text file and open it in notepad.<br>Put this in it:<br>
```reg
Windows Registry Editor Version 5.00

[HKEY_CLASSES_ROOT\unused]
"URL Protocol"=""
[HKEY_CLASSES_ROOT\unused\shell]
[HKEY_CLASSES_ROOT\unused\shell\open]
[HKEY_CLASSES_ROOT\unused\shell\open\command] 
@="\"C:\\Unused\\PlaceJoiner.exe\" \"%1\""
```
Of course, replace unused with your revival and C:\\Unused with your revival name.<br>Put PlaceJoiner.exe's contents in it when you build it.
## Step 2: Building
What you need: Visual Studio 2022<br>Change the project settings with your revival name.<br>You need to edit the source to make it go with your revival.<br>Press start, then go to where the project is at, and go into the Debug folder.<br>Drag it into C:\YOURREVIVALNAME.
## All Packages (Extra)
I couldn't upload the packages folder, but here are all of them listed:<br><br>Microsoft.Extensions.Primitives.2.2.0<br>Microsoft.Net.Http.Headers.2.2.8<br>Mono.HttpUtility.1.0.0.1<br>Newtonsoft.Json.13.0.3<br>System.Buffers.4.5.0<br>System.IO.4.3.0<br>System.Memory.4.5.1<br>System.Net.Http.4.3.4<br>System.Numerics.Vectors.4.4.0<br>System.Runtime.4.3.0<br>System.Runtime.CompilerServices.Unsafe.4.5.1<br>System.Security.Cryptography.Algorithms.4.3.0<br>System.Security.Cryptography.Encoding.4.3.0<br>System.Security.Cryptography.Primitives.4.3.0<br>System.Security.Cryptography.X509Certificates.4.3.0
## Credits
swordrx2 - Original Launcher Code<br>autoimi - (me) I edited it a ton for Unused<br>THANK YOU SWORD!
