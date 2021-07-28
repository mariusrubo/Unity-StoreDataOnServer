# Motivation
Psychological studies are often conducted over the internet. For questionnaire studies and experiments using PsychoPy, there exist a variety of services that will host your study and store data for you. However, when conducting a study using a Unity game, to my knowledge there exists no such service and one needs to collect data using one’s own server. This project gives a basic example on how to achieve this. 

# Setup
The project consists of 1) a php script that you will need to place on your server and 2) a C# script that sends data to the php script from within a Unity application. The php script then writes the data onto a file located in the same folder on the server. 

# Additional Remarks
* Personally I would recommend to distribute the Unity software as WebGL application so that participants can directly access it over a browser. The easiest place to host it may be Github Pages. However, note that Github Pages does not allow server-side scripting, so the php script will have to be located elsewhere. It does not matter if your game and the php script are located on the same server.  
* Note that in this example, data is not protected. If you collect any personal data, make sure to encrypt it before sending it to your server (not covered here). 

