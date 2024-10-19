# Disclamer: this program is NOT designed for remaking random maps you found on the internet. Don't bother me with whacky results if you attempt this.

This is AoC image to scenario converter, a simple program to assist map and scenario makers in the Ages of Conflict community. This readme contains an in-depth guide to all functions of the program.

## How to use:
1. download, extract and run the program
2. pick prefered mode (explaination of different modes and their specific options below)
3. select input(s) and output destination (if available, the program will suggest game's default scenario folder)
4. click "generate" and await confirmation

# Modes

## Basic mode
The oldest and simplest mode the program can work in, made to bypass game's map size limit.
Upon selection you need to only provide the terrain image, it works the same as making a normal map that you intend to put in game's custom maps folder, meaning it has to obey standard terrain color-coding.

## Advanced mode
By far the most complicated of the bunch, made to aid map makers by allowing them to paint countries in their image editing software of choice instead of the in game editor. Unfortunately, I'm not a magician. so you have to name countries and cities yourself.
To use it, you need to provide a terrain image that works the same as in basic mode and a second image for countries, which has specific requirements:
- only 1 unique color per country, regardless of terrain.
- grayscale (R=G=B) will be ignored, meaning you can paint countries on a copy of the terrain image.
- #FF0000 (red) is reserved for capitals, if a country doesn't have one, it won't be created.
    - be mindful when putting capitals near borders, as the program determines who ownes what city by looking at the most common color in neighboring pixels.
- if "advanced cities" option is selected #00FF00 (green) and #FFFF00 (yellow) will be reserved for cored and uncored cities respectively.

## Map art mode
Recreates images by placing countries of corresponding colors on a blank map. The goofiest of the bunch with limited practical use, but it's here.
To use it you just need to selct an image, any image and press go, simple as that. 
The program also has a built in posterizer (color reduction) so you can sacrifice some quality for faster generation and more of a chance of actually running whatever abominations you choose to create.
There's also a handy preview attached of what the different posterization levels will look like on your image.
