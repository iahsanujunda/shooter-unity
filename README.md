# Project Shooter

A simple shooting made in Unity3d game Studio.

## Usage

If you have a working Unity3d Game Studio, then just run the file "Shooter v5.unitypackage".

## GAME STRUCTURE:

### CONTROL

The user navigate a player object using RIGHT and LEFT arrow key to move the player horizontally. The player object will move accordingly.
In the desired position, user could make the player shoot a bullet using UP arrow key. BEWARE that some enemy could retaliate and launch a counter attack by shooting bullets to player�s position. 

### SCORING

By default, all enemies worth 100 points each. But an attacking enemy worth 50 points bonus.
Try to avoid any incoming attacks from the attacking enemies by moving the player to avoid enemies bullets, or commit a retaliating action by shooting at the bullets.
Successful attack on enemy bullet would provide a better score than shooting at the enemy itself.

Complete Documentation could be read on "Project Shooter - GDD.pdf"




V5 updates:
- fix on "Null Reference" caused by enemy shooter to search
  for player's position when player already dead
- bundled all files inside the .unitypackage
