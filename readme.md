<div align="center"><img src="https://i.imgur.com/VCvZhWT.jpg" alt="Seele" width="30%"></img></div>

A simple **API** for retrieving data from **Honkai Impact 3rd**.<br>
The **API** development is still in its early stages, missing **error** handling and an automatic **DS** generation system.

To retrieve the **DS, Cookie Token and lToken** you need to access **[Honkai Impact 3rd Battle Chronicle](https://act.hoyolab.com/app/community-game-records-sea/index.html?bbs_presentation_style=fullscreen&bbs_auth_required=true&gid=1&utm_source=introduction#/bh3)** and wait for the page to load.<br>
After the page loads, press **CTRL + SHIFT + C** and go to the console.<br>
In the console there will be a request with an error, click on this request and then go to:<br>
**object > config > headers > DS, copy the DS** and then paste this code in the console to get **Cookie Token and lToken 🠋**<br>
```
document.write(document.cookie);
```

After copying the **DS, Cookie and lToken**, go to **[Program.cs](https://github.com/nicaksks/Seele/blob/main/Program.cs)** and paste your **UID (Honkai Impact), ID (HoYoLAB), Cookie Token, lToken and DS**<br>
Inside the **[Program.cs](https://github.com/nicaksks/Seele/blob/main/Program.cs)** file there is an example of an **API** request.
<div align="center"><img src="https://i.imgur.com/tNpXiFq.png" alt="Example" width="30%"></img></div>