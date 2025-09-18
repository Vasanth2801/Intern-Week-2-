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


Date : 17/9/2025

Task : Collectable coin prefab with update score in UI 

what I have learned :
* How to create coin prefab and how to detect the collsion detection with two gameobjects
* In triggerenter 2D method, how  to trigger the events
* How to display the coin increment in UI when we pick the coins
* How to add particle effects and trigger it using the code 

Implementation(Step by step):
* Created a cricle gameobject give it a yellow colour so it can get the feel of real coin
* Then added a circle collider and checked the trigger to check the triggerenter event
* Added a player and added rigidbody and boxcollider so only two colliders collision detection will happen
* In script using debug.Log i check the collision dectection it is working really working well
* In coin script add a new textmeshpro field and assign the score text we created and in script create a new varaible for the score to increment the score when it is touched
* Now in trigger method now we add that logic so when we touch the coin it will implement the score in the UI
* In hiearchy created a new particle effects and adjusted the values for the particles and bring the coin bring up effect
* In script inside the trigger we add the thing for calling the particle system

Features Implemented:
* A collectable coin prefab with collision detection
* When the coin is picked up the score will implement in the UI
* Added the audio and particle system when the coin is picked up

Bug Fixes:
* The Singleton pattern is the main hero of today progress i have learned it
* Even though normally the implemented one is working but singleton makes it very ease to work


Date : 18/9/2025

Task : ScoreManager and Saving Data

What I have Learned:
* How to implement a singleton ScoreManager to call from other scripts to persisent data
* How to add score when something is touched 

Implementation(Step by step):
* First created a ScoreManager script and added it to the ScoreManager GameObject
* Then added the logic for the scoremanager using singletonpattern
* Created a new script for collectable and make the gameObject as trigger
* Now using singleton we are calling it this script and increase the score

Features Implemented:
* Score Increasing when the trigger is touched 

