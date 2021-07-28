# Motivation
Psychological studies are often conducted over the internet. For questionnaire studies and experiments using PsychoPy, there exist a variety of services that will host your study and store data for you. However, when conducting a study using a Unity game, to my knowledge there exists no such service and one needs to host the software and collect data using one’s own server. This project gives a basic example on how to do this. 

# Setup
The project consists of 1. a php script that is located on a server and stores data in the same folder where it is located and 2. a C# script that exemplifies how to message data to that php script in order to trigger data storage from inside a Unity application. You just need to insert the correct link to where you have stored the php script and you’re good to store data collected by your Unity application, running on a participant’s computer, on your server. 

# Additional Remarks
Personally I would recommend to distribute the Unity software as WebGL application so that participants can directly access it over a browser. The easiest place to host it may be Github Pages. However, note that Github Pages does not allow server-side scripting, so the php script will have to be located elsewhere. It does not matter if your game and the php script are located on the same server.  
Note that in this example, data is not protected from external parties. If you collect any personal data, make sure to encrypt it before storing it to your server (not covered here). 

