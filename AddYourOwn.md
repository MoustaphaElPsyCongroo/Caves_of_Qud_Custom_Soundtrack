# Adding your own tracks to Custom Soundtrack
Custom Soundtrack works as a Harmony Patch to replace the track that would be playing when a zone loads by another, set up a timer, reducing crossfade, etc. Small parts of the code are commented, but thankfully you don't have to understand how it works or have any deep knowledge in coding or C# to add your own tracks. Follow me!

## Opening the source files
The mod's folder can be in two places :

 - If you've installed it from Steam:
	 - Open **C:\Program Files (x86)\Steam\steamapps\workshop\content\333640**
	 - There you'll see all your mods own folder, named by their Steam id. To find a mod's Steam id, go on the mod's workshop page, and check the url for **id=\*any id\***
	 - Open the corresponding folder

- If you've installed it from Github by downloading and extracting the zip file:
	- Open **C:\Users\\\*Your Username\*\AppData\LocalLow\Freehold Games\CavesOfQud\Mods**

## Warning about editing the source
Whenever I update the mod, all your changes will be lost. So always do a backup of any change you make. Don't copy paste the entire Tracklists.cs file with your changes on update it, since you won't have my eventual fixes and changes this way. Preferably, create a dummy .cs file containing everything you added and a folder with your tracks that you can copy paste on update. Don't worry, I won't update often.

## Editing the source files

The file you are interested in is **Tracklist.cs** and you'll place your tracks in the **Sounds** folder.
If you plan on adding multiple tracks or setting up many or complex conditions for these tracks to play, I recommand you [install VsCode](#installing-vscode). If not you can use Notepad just fine.

### Installing VsCode

 - Download VsCode from [there](https://code.visualstudio.com/) and install it
- [Optional] Install the [Prettier extension](https://marketplace.visualstudio.com/items?itemName=esbenp.prettier-vscode). It's optional but recommended so you have the same formatting as me when editing the code.
- Click File -> Open Folder and open Custom Soundtrack's folder
- Open the Explorer with **CTRL + Shift + e** and double click on **Tracklist.cs**. You are now ready to add your own tracks!
- If you installed Prettier, do **CTRL + Shift + p**, search for "Format document with", select "Configure default formatter" and select Prettier.

### Creating a condition
So let me explain how to use the Tracklists.cs file to set up your own tracklist for any zone. If you're already familiar with coding, or don't need to create your own condition and only need to replace some places' music, feel free to jump to the [next section](#editing-zone-tracks).

On line 10, you'll see the start of a class: *public class TrackList*. You don't have to know what a class is, just know that after a zone loaded, it will store a list of tracks defined following some **conditions**. This list is named **Tracks**, and starts empty.

Scroll down until you see the first comment, "*START EDITING AFTER THIS LINE*". Any single line that starts with double slashes // or multiple lines between /* */ are comments and won't do anything.

What happens after is that whenever a specified condition is met, a list of titles is stored in Tracks, and one track from this list will be chosen at random and played. For example it will look like this for Joppa :

    if (Z.DisplayName.Contains("Joppa"))
    {
	    Tracks =
			new string[] {
		    "First track filename",
		    "Second track filename",
		    "Last track filename"
	    };
    }
It may look scary but don't worry! Most of what you'll do is copy pasting :)
Let me explain everything you see here.

 - "**if**", you guessed it, allows you to set a **condition**. If whatever is written between parentheses is true, everything between the braces below it will happen.
 - So here the condition is **Z.DisplayName.Contains("Joppa")**. Once again, it's easy to guess: if the name of the current zone contains the characters "Joppa", the specified tracks will form the playlist for this zone.
	 - "**Z**" is the current zone. Each zone, like anything, has a set of attributes you'll use to set up conditions. Those can be as simple as name, strata or coordinates, and there is more complex ones also used in this mod. But most of the time you won't have to bother with it, copy pasting will be enough.
	 - The dot lets you access properties of the zone Z. So here our attribute is **DisplayName**. That's the name of the current zone as it appears on the top right of the screen ingame.
	 - And then we check if it **Contains** the characters "Joppa". Character strings are always written between quotes.

After that you're set! What's between braces pretty much never changes: we tell the program that we will create a new list of characters, stored in Tracks. There you'll write the file name of any track you want, **without its extension** and put the corresponding file in Sounds folder. Qud supports .mp3, .ogg, .wav and .aiff files. I myself only use .mp3 files and a specific notation for titles you'll see below so you won't risk to have duplicates.

After you've done an **if**, you have to follow it by a **else if** so that following conditions doesn't override previous ones. That's why after the "*START EDITING AFTER THIS LINE*", I commented out a single else. Uncomment it and write before it so that your code take precedence over mine. If you use Prettier it will move the else down at the start of my conditions. Whenever you add multiple conditions, follow them by an else if like so:

    if (any condition)
    {
	}
	else if (other condition)
	{
	}
	//else <-- you'll uncomment this one

#### Zone attributes
Here is a list of the most useful zone attributes for creating your own conditions.
| Attribute | Type |  Description |
|--|--| -- |
| Z.DisplayName | string | The name of the zone, as displayed |
|Z.Z| int (integer, write it without quotes) | The zone's stratum. Surface is 10, stratum 1 is 11 etc. |
|Z.NewTier| int (integer, write it without quotes) | The zone's [Tier](https://wiki.cavesofqud.com/wiki/Zone_tier) |
|Z.GetRegion()| string | A method to get a zone's region name. Check all region names under the "World map terrain" section in Tracklists.cs |

If you need more examples on how to use them, search for them in sections of the codes, they are used pretty much everywhere and in several ways.
Other attributes are used in the code but have more complex uses and custom methods are provided for some, like isStartingVillage().

### Editing zone tracks
Now that you know how conditions work, you don't have to write them yourself. You can just copy paste my existing condition for the zone you want, move your mp3 files and you're done. So step by step:

 - Do **CRTL + f** and search the name of the zone or location type (world map terrain, underground, specific named stratum in a zone) you want. For example Joppa.
 - You'll find a comment with the zone name, like so:
    //---------- //JOPPA  //-----------
 - Select everything after the comment, starting with the **if** until its closing brace. In VsCode you can follow a light gray vertical line to help you see where the brace closes. If it's your first condition, don't copy the else, copy it starting from the second.
 - Scroll back to "*START EDITING AFTER THIS LINE*". Uncomment the // else there (remove the //) and paste what you copied on the line before it. Add your own comment before your if to your liking or use mine.
 - Now you can add / remove / replace any tracks listed in Tracks by the name of a music file, **without its extension** and always between quotes. Separate multiple tracks by a comma.
 - Move the files you added into the **Sounds** folder.

Then each time you'll enter this zone and change screens / move up or down stairs, one of the tracks you chose will be played at random (as long as in the same zone the previous one played for a specific amount of time so that you don't hear multiple track changes if you travel quickly. You can change this amount, see how [here](#editing-the-minimum-time-for-music-to-change)).

#### Track filenames
I use this same convention for all file names:
"**Location_Origin of the Track_Track original title**".

That way you'll be unlikely to have the same filenames as me. I prefer not to use spaces and most special characters in filenames for the sake of compatibility but spaces and most special characters should be supported by Qud just fine.

#### No sound
If the zone you edited becomes silent ingame, it will be because you made a typo in the filename or the file doesn't exist.
If it's replaced by another, you made a typo copy pasting or forgot to
uncomment the else.

### No change even after checking for typos
Some locations, like the Stiltgrounds, only play the default music of their
region. If the music doesn't change after you added your condition, add toPatch
= "yes" right after the if braces. It will apply my custom patch for these cases.

#### Vanilla track
If you want the vanilla track that would play at this location to be part of the mix, just add "default" in the Tracks list.

    Tracks = new string[]
    {
	    "first track",
	    "default",
	    "third"
	}

### Editing the Crossfade
I greatly reduced the huge crossfade base Qud uses. It works well with the style of music of vanilla, but not so well with themes that have a dramatic start like some of mine. You can set the value you want by opening **Crossfade_Reduce.cs** and editing the single CrossfadeDuration value you'll see there. Vanilla value is noted as a comment.

### Editing the minimum time for music to change
You can edit the (real) time that must have elapsed in a location for music to be allowed to change. (I reset it if you change locations, the timer will be active only if you're still in the same location after you've moved between screens, went up/down stairs etc).
In TrackLists.cs edit **TracksMinSeconds** (line 28). It's at 90 seconds by default.

## [Optional] Using audio enhancement software
To enjoy great music use great headphones and use great EQ settings. I'll share with you my favorite config, used on all my headphones, that not only includes EQ but also surround and reverb settings, bass boost if needed and more, that will greatly improve clarity, soundstage and feels on all types of music. Try it and let me know if you like!

You'll use the great Viper4Windows patched by EqualizerAPO.
- Download [Viper4Windows](https://codecpack.co/download/ViPER4Windows.html). The site includes a patcher because this software isn't compatible with Windows 10/11, but I was using the EqualizerAPO method before those patches existed and it always worked for me. Use their method if it doesn't for you.
- Install Viper4Windows
- If the installation process didn't prompt you for audio devices to install Viper on, open your Viper4Windows installation folder and launch configurator.exe **as administrator** (it won't ask by default), then choose your device.
- Install [EqualizerAPO](https://equalizerapo.com/). Choose the same device you installed Viper on.
- Reload your PC.

Viper4Windows should now be successfully installed and working. Now you'll use my settings!
- Open Viper4Windows **as administrator**.
- Select Freestyle mode on the left.
- Click Load preset and open *general.vpf* from Custom Soundtrack\Viper4Windows_settings folder.
- In the Convolver section click on the arrow and select the provided TubeAmplifier & Technics one. Enable the Convolver on the top if not already enabled.
- **Lower your sound**, then try listening to your favorite music. There is some amount of preamp and gain in my settings, so your current volume will be too loud. Don't worry though, you have no risk of clipping with my settings.
- Enjoy! :)

### Some notes:
Bass boost is disabled by default, because I prefer to boost it through a
DAC/amp.

If you listen to music that has a beat, you'll notice that drums have some
reverb. The effect is incredible for me but you'll see you will hear this
reverb if you listen to podcasts, films etc. I got used to this effect and like
the fuller sound, but if it bothers you, just disable Reverberation on the
right.

Enable it again after though! Just compare with it on and off, listening to any
music with a beat and you'll see. It's night and day!

### About EQ
EqualizerAPO you just downloaded is the best EQ for Windows. I recommend you use it alongside my Viper to very more precisely and strongly control any frequency. To do it:
- Open Viper's Settings and check "Enable APO coexists"
- Restart your PC.
- Download [Peace](https://sourceforge.net/projects/peace-equalizer-apo-extension/), a GUI for EqualizerAPO.
- Using Peace, apply [Oratory1990](https://www.google.com/url?sa=t&source=web&rct=j&url=https://www.reddit.com/r/oratory1990/wiki/index/&ved=2ahUKEwiz_-yn9Zf7AhWrz4UKHbMmD3IQjjh6BAgcEAE&usg=AOvVaw30U6o4wV90HVrnxj1qAIEN)'s settings to your specific model of headphones (the link contains instructions and FAQ on how to do it). From this base you can further tweak them to your liking. Keep in mind that if you're already near maxing out your volume, you would most likely need an amp for those because he applies negative preamp to prevent songs from clipping at high volumes.
