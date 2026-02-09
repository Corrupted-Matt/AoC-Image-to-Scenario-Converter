# Disclamer: this program is NOT designed for remaking random maps you found on the internet. Don't bother me with whacky results if you attempt this.

This is AoC image to scenario converter, a simple program to assist map and scenario makers in the Ages of Conflict community. This readme contains an in-depth guide to all functions of the program.
If you have any issues or think you've found a bug, feel free to reach out to me @corruptedmatt on Discord

## How to use:
1. download, extract and run the program
2. pick prefered mode (explaination of different modes and their specific options below)
3. select input(s) and output destination (if available, the program will suggest game's default scenario folder)
4. click "generate scenario" and await confirmation

# Modes

## Basic mode
The oldest and simplest mode the program can work in, made to bypass game's map size limit.

Upon selection you need to only provide the terrain image, it works the same as making a normal map that you intend to put in game's custom maps folder, meaning it has to obey standard terrain color-coding.

## Advanced mode
By far the most complicated of the bunch, made to aid map makers by allowing them to paint countries in their image editing software of choice instead of the in game editor. Unfortunately, I'm not a magician so you have to name countries and cities yourself.

To use it, you need to provide a terrain image that works the same as in basic mode and a second image for countries. Each country is defined by 1 unique color, with no man's land remaining transparent.

This mode has several additional settings:
### Occupations
 - when selected, splits political map into de facto and de jure variants, any difference between them will be marked as occupied,
 - when "within political map" option is selected, non cores will also check de jure map when assigning rightful ownership,
### Create Flags
 - creates blank flags of the corresponding map color for every country,
 - useful as a template for creating flags with less need to reference flagnames.txt provided by the game.
### Cities
 - **None**: capitals are placed in the bottommost pixel of the country, just like in legacy versions of this program.
 - **Within political map**: when selected, #FF0000 (red) will be reserved for capitals, #00FF00 (green) for cores, and #FFFF00 (yellow) for uncored cities. Be mindful when putting cities next to borders, as ownership is determined by checking neighbouring pixels.
 - **Separate file**: adds another image input, where each pixel is a city and its color tells the program who the rightful owner is, with #FF0000 (red) being reserved for capitals

## Terrain Swap Mode
Replaces terrain in a preexisting scenario according to the terrain map provided. Most useful when updating multiple scenarios using the same map.

To use it you only need to choose a scenario and provide a new map (that naturally needs to be the same size as the scenario). It's best practice not to override your scenario and instead save a copy.

## Map Art mode
Recreates images by placing countries of corresponding colors on a blank map. The goofiest of the bunch with limited practical use, but it's here.

To use it you just need to selct an image, any image and press go, simple as that. 

The program also has a built in posterizer (color reduction) so you can sacrifice some quality for faster generation and more of a chance of actually running whatever abominations you choose to create.

There's also a handy preview attached of what the different posterization levels will look like on your image.
