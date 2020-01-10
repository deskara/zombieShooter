# zombieShooter

Zombie Madness, top-down zombie shooter.

# Assets

## Scenes

### Gameover
The scene loaded when the player dies
### MainMenu
The initial scene.
### HomeBase
The base scene where the player can upgrade their weapons and purchase new ones
### ZombieShooterLevel1
The scene where combat occurs
### ZombieShooterLevel2
Currently just a clone of ZombieShooterLevel1, there were plans to have multiple maps but this was scrapped.

## Scripts
I've given a short description of what each script does.
### Weapon System Folder
This folder contains the scripts that specifically pertain to weapons.
#### bulletScript
This script handles having the bullets deal damage, destroying them and contains the setters for firespeed and damage.
#### leftGunAnim
This script handles ensuring that the animator for the left gun has the correct values for isFiring
#### rightGunAnim
This script handles ensuring that the animator for the right gun has the correct values for isFiring
#### weaponScript
This script handles firing bullets and ensuring that the bullets are of the correct type (piercing/non-piercing). Also plays the sound for shooting.
#### addScore
Handles increasing the score when a zombie is killed
#### baseTutorial
Handles the first day introduction to the base
#### baseUI
Handles displaying the coins in the base
#### battleUI
Handles displaying coins,score and health during battle scenes.
#### buttonAnim
Ensures that the animators of buttons knows whether the user is hovering over the button or not.
#### coinScript
Handles removing the coin when the player collides with it and also increasing the coin counter and the coin sound effect.
#### destroyOnDie
Gives the game object a die method which destroys it. This can be called by other scripts to destroy the object.
#### Enemy
Ensures that the zombies can find the player
#### enterBase
Makes the enter base menu pop up while also making sure the player isn't stuck in a loop if they choose not to enter.
#### escapeMenu
Handles the pause menu which pops up and is removed by pressing escape.
#### exitBase
Handles the event that causes the exit base option to open up.
#### fpsLimiter
Ensures that the FPS doesn't go too high as that can cause problems.
#### gameManager
Handles moving the player to a different scene and resetting playerPrefs values when appropriate.
#### GunShopScript
Handles purchases from the gun shop
#### healthSystem
Handles the health for the zombies
#### HighScoreUI
Handles displaying and scoring the high scores upon game over.
#### hurtTrigger
Disables and re-enables the hurtTrigger on the zombie upon hitting the player.
#### inventoryScript
Ensures that the player can see the items in their inventory.
#### lookAtTarget
Handles rotating the zombies to look at the player.
#### mouseSmoothLook2D
Handles rotating the player to look at the mouse
#### MoveTowardsObject
Allows a gameobject to follow another gameobject,. Used by the zombies.
#### numDaysSurvivedScript
Handles displaying the number of days the player survived in the game over screen.
#### PlayerAnim
Handles animating the player when they're firing.
#### playerCollisions
Makes all events such as a player colliding with a base occur.
#### playerDeathHandler
Unused. A relic from when the game would be paused and a message would be displayed before going to the game over screen.
#### playerHealth
Handles sending the health value to the UI and contains methods for 
#### settingsScript
Handles setting the options which the player can choose from the main menu.
#### shopScript
Has an event attached to it which can be used to enable the shop menus.
#### smoothFollow2D
Allows a gameobject to follow another gameobject. Used by the camera.
#### Spawner
Spawns a specified gameObject
#### timerEvent
Makes an event occur on a specified time frame
#### topDownCharacterController2D
Handles allowing the player to move
#### tutorialEvents
Handles setting the text in the tutorial to the next instruction
#### upgradeScript
Handles checking if an upgrade is valid and if so applying it
#### zombieSpawner
This handles the random spawning of different zombies, inherits from the spawner script.
## Sprites

## Sound
#### Stage3
Music for the game screen.
#### Menu
Music for the main menu
#### PurchaseMade
Sound effect for when a successful purchase is made
#### CoinPickup
Sound effect when a coin is picked up
#### 8bit_hit_1
Sound effect for when the player shoots
#### A&C Percussion Loop
Music used in the Base
## Animations
### Buttons

### Gun Animations
## Materials
#### dialogueMaterial
Unused, from an attempt to make items transparent.
## Prefabs
#### Base
The base, the current sprite is a placeholder.
#### BulkyZombie
A zombie with high health and attack but low speed.
#### bullet
Bullets which deal damage
#### Coin
A coin which the player can pick up
#### Explosion
A blood explosion which removes itself when the animation is finished
#### Grave Zombie Spawner
A zombie spawner with a sprite of a grave on it
#### Health Bar
The bar which shows how much health the user has
#### Hero
The player
#### Pause Menu
The menu which pops up when the user presses escape
#### Rock
A rock which blocks zombies and players
#### Speedy Zombie
A zombie with a higher speed stat
#### Zombie Spawner
Zombie spawner with no sprite attached to it.
#### Zombie
A zombie
## TilePalletes
In this folder there are two palletes, the Arena pallete which is used in combat and the base pallete which is used in the homeBase.
