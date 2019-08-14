# Zelda-Rework
Reworking the Zelda tutorial 
Hey everyone!  Here's a re-work of the Zelda Like series.  I'm currently
working on making sure scripts are well commented and arranged in a 
sensible way, so until that's done be kind :)

I've made quite a few improvements.  Here is a non-complete list of
what has been improved so far:

1 - Tile maps are now implemented as Prefabs using Super Tiled2Unity
2 - The sprite sheets are now more broken up to better use for different
  items
3 - New sprites have been added for the items courtesy of Alex's Assest
  https://alexs-assets.itch.io/16x16-rpg-item-pack
4 - The virtual camera parameters are changed to better track the player
  and always keep the camera looking ahead
5 - The UI Layout is less cluttered
6 - The Heart UI interface is more solid and understandable (work in 
  progress)
7 - The player's money is also more solid and also a work in progress
8 - Interactable objects now use a signal to change the UI
9 - The UI is now split into multiple canvases
10 - Area name now uses a signal as part of the room script
11 - There is now a string and sprite value scriptable object to keep
  connections flexible
12 - Pots now use a health script to keep the knockback script simple
13 - Treasure chests now use the new Inventory Item instead of the old one
14 - Vector Values now work much better.

To Do:
1 - Fix the issue with serializing Scriptable Objects.  This one is big and
  frustrates the heck out of me.
2 - Re-implement the inventory
3 - More Room Types
4 - Magic is waiting for the ability system
5 - Scene transitions
