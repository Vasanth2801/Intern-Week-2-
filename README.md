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
* How to update the increase in score in UI
* How to save the game data using player prefs 

Implementation(Step by step):
* First created a ScoreManager script and added it to the ScoreManager GameObject
* Then added the logic for the scoremanager using singletonpattern
* Created a new script for collectable and make the gameObject as trigger
* Now using singleton we are calling it this script and increase the score
* I have created a canvas and added a text mesh pro and make it to the top left and set it to the score
* In script by using update method  i have used to add the score in UI
* Created a new empty gameobject and named it high score manager and added the script to it and and used singlepattern to call it scoremanager script
* when the player is adding the coins then the score will increase and when the current score higher than the start score then when we restart the game the current score resets
* but the highscore will still stay the same when we again start the game 

Features Implemented:
* Score Increasing when the trigger is touched
* Updating the Score in UI when player touches the UI
* A highscore saving system using the PlayerPrefs

Summary:
*Today i learned about how to save the player data using the player prefs system

Date : 19/9/2025

Task : Enemy Spawner using waves

What I Have Leanred:
* How to implement the Spawn wave at a required interval
* How to spawn enemies with wave system at a single point
* How to spawn enemies with random point at the wave system
* How to display the current wave we are using 

Implementation(Step by step):
* First create a empty gameobject and name it as EnemeySpawner
* Add a New script to the ENemySpawner and created three new enemies with different sprites
* Now make the enmies as a prefab and delete it in the hiearchy view
* In Script created a variable for the wave spawning time and it as shown in inspector
* When the game is running less the countdown timer and when it reaches zero spawn the wave
* Now we have only one spawn point but we have do it at random points spawning
* For that we create multiple points and go through that and make it drop from there
* Now we want to display the current wave in the UI
* we created a textmeshpro and also added to script reference and use it in update method and update the score in UI


Features Implemented :
* Spawning the waves at the requird interval
* Spawning the waves one after one
* Spawning the enemies at random position
* Showing the UI of the current wave doing

Summary:
* Today i learned about the array uage in wave system and how to implemenet the wave System for the enemies

Date: 22/9/2025

Task: Animation for Player and Enemy


What I have learned:
* How to import the asset package from unity asset store
* How to create animation and add it in the animator window
* How to do animation Transtions between other animations
* How to do the animation transtions using the movement script
* How to do the enemy animations 

Implementation(Step by step):
* First I have gone to unity asset and searched for 2D charcter and choose the asset to download
* Then give add to my assets and give add in unity editor and downloaded the asset added the folder in the asset package
* Now i have opened the animation window and created a new animation folder and added the created the animations in that folder
* Now also i have a new window animator which handles the movement of the animations we are creating
* Have created the animation transitions between each animations in the animator window
* Have created a new script and attached it to the player and when player moves or jumps the corresponding animation is playing
* have created a another script for the enemy and make it follow the player from the start
* So for enemy we have to make it follow the enemy with flying aniamtions 


FeaturesImplemented:
* Created  animations using the image sprites
* Added the animation transtions between each animations
* Added the player animations for player moving and jumping
* Added the enmy animations for player chasing the enemy


Date: 23/9/2025

Task : AudioManager for loopmusic and SFX effects 

What i have Learned:
* How to Implement the audio for music running continous loop
* How to add Sfx Effects for specific events
* How to adjust them in audio source settings of the volume
* How to implement audio system with only script 

Implementation(Step by step):
* First created a normal scene setup with player,enemy and where player shoots when player press space
* Now all in place created a empty gameobject named as audio manager and script named "Audio manager for music and shooting
* Download the rquired sound effects and music and then now in script we add the logic for the music which plays at the start
* Downladed the specific sound effects and added it to the folder
* Now in audio manager script using the sound effects when certain action happen trigger the sound effect
* Created a new script and added the logic for it and created a another script and make it customizable in inspector 

Features Implemented:
* When game starts the music play on loop
* Sound effects triggering when certain events happens
* Shooting sound,enemy death sound and music loop throufh the game happens
* Another way to implement audio sytem with only script 

Summary:
* Today i learned about audio system and managing it in the script and how to certain trigger events happening
* Today i learned abouy another way of implementing the audio system
