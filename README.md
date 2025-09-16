Intern Week2 Tasks

Date : 16/9/2025

Task : Cinemachine and manunal script following the player

What I have learned:
* How to install cinemachine package from the package manager
* Then to implement it in the scene by adding the target in the inspector
* Learned more about the cinemachine settings that i have not learned before by exploring myself
* How to make a simple camera follow manual script
* How to add smoothing in the manual Script and leared how to implement a smooth value

Implementation:
* Created a Player gameobject and added to the scene and added the movement script for the player
* Then in hieachy added a cinemachine where it can follow the desired charcter when we added it in the inspector
* Cinemachine object the position composer i changed so many settings to make the camera follow the player smoothly
* For damping and smoothing increased the value for smooth camera movement
* Activated the deadzone and hard limits to set the player not move out of some desired boundary and deadzonw is where the camera will not focus that area
* Created a new scene for this one and added new player and added new script foe following the player
* In the script added the smooth value

Features Implemented:
* Added a cinemachine for following the player wherever the player is moving in the game scene.
* Adjusted the camera settings for the player smooth follow and with only set boundary
* Created a script manually to follow the player
* In the script added a smooth value for smooth;y follow the player
