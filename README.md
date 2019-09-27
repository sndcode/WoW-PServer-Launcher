# WoW-PServer-Launcher (v0.0.99)
A launcher i wrote for a side fun project. Currently has every basic feature such as autologin, cache clear, realmist patches etc etc.
Backend PHP scripts here : https://github.com/sndcode/WoW-Pserver-Launcher-Backend-Scripts


The Features are : 
- Auto patch realmlist
- Auto Login (Needs a rewrite with a more precise check) but is working
- Cache Clear / Auto Cache Clear before play
- Settings.ini holds user settings
- Settings form 
- Error Handling (most important ones)
- Save login data encrypted (To protect from malware)
- Newsfeed via server (HTML Page or plain txt file)
- Very simple update check 
- Auto close after login
- Commented Code (Mostly)
- Devmode (Some admin features)
- Bugtracker inside Launcher to submit bugs to the Team with ease !
- Create Account from launcher
- Game Client Downloader with progressbar and download speed etc
- In DEVMODE see bug tracker tickets 
- Icons !
- Bugtracker with attatchment support
- many many more and some easter eggs


INSTALLATION OF THE BACKEND AND SERVER SETUP:

- You will need a mangos server for either 2.4.3 or 3.3.5a . (works with any emulator when you change the backend SQL commands.)
- First upload the www folder contents to your WEBSERVER.
- Configure "www\wow\files\launcher\cfg.php" 
- Configure "www\wow\settings\cfg.php"
- Configure "\Launcher\Classes\classVars.cs" <- The links etc are located here
- If everything is set up correctly you can recompile the launcher and it should work.


Thread = http://www.ac-web.org/forums/showthread.php?234784-C-Launcher-(GitHUB)-(Open-Source)

![Alt text](https://i.imgur.com/eOAaGRm.png " ")
