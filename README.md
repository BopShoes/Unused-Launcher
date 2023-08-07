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
## Credits
swordrx2 - Original Launcher Code<br>autoimi - (me) I edited it a ton for Unused<br>THANK YOU SWORD!
