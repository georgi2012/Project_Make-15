# Project_Make-15
## What is Make 15?
Make 15 is a simple strategy game where you have the numbers from 1 to 9 and two players take a turn to pick one of the numbers that are left untaken. Once a player has 3 numbers that together make 15, he wins.
## About the project
Project_Make-15 is a Windows Communication Foundation project that allows 2 players to connect through a web service and play the game against each other.
## Game menu
Once you run a game client, you see a menu of 3 options - Find match for online game, PVE for Player against the system offline game and Help section for game and GUI rules.

![Menu](https://github.com/georgi2012/Project_Make-15/blob/main/readme_img/menu.png)
## Player names
Each player has the chance to pick a name before the game that will be used in the chat and shown in the GUI window. Names should start with an uppercase english letter and have nothing but numbers and english letters in it. Color indicator will let you know if the player name is correct. Also a default name will be suggested once the window is opened.
![Names](https://github.com/georgi2012/Project_Make-15/blob/main/readme_img/names.png)
## PVP games
When joining a game, System message will let you know if a waiting opponent is presented or you are the first to have joined. Once two players are found, the game beggins. The graphic interface is made simple to use - you can see the available numbers, your picks, opponent picks and whose turn it is! What else do you need?
![PVP](https://github.com/georgi2012/Project_Make-15/blob/main/readme_img/pvp.png)
## Chat system
What is a multiplayer game without its chat? Chat window with color identification for your, opponent and System messeges is available for you to express your thoughts.
## PVE
Want to practise before going to the Make 15 PVP championship? Or maybe just internet issues drive you crazy? PVE will let you play offline games against a simple AI algorithm without connecting to the network.
![PVE](https://github.com/georgi2012/Project_Make-15/blob/main/readme_img/pve.png)

## More info
Project includes a Doxygen generated documentation. Code is documented and everything is a separated in different regions for better readability. A bulgarian report has been added explaining programmer decisions for the project.
## How to test
Download the code and open the VS solution. Find the Make15 server project right_click-> View in Browser to start the server. Then you can run the Make15_Project->bin exe file for multiple client instances.
