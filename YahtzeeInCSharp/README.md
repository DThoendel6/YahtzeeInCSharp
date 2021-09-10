# cSharpYahtzee
A game of Yahtzee I created using C# in Visual Studio.

You must register or log in with a Username and Password. The password must be at least 3 characters long, and contain an Uppercase, Lowercase, and a number.
A test log in is:
Username: BillyDean
Password: Bb1

Successful credentials will make the log in/register panel disappear until you click "logout" or restart the program.
Conventional Yahtzee rules apply. A Yahtzee is having 5 of the same dice.
The initial start game screen is a little misleading, because it gives the appearance that you can start playing with the current set of dice, but the message at the top of the screen says "Good Luck, Press Play!" When you do press play, the message at the top greets you with your name, and a new set of dice are displayed! It doesn't matter if you tried to hold some of the dice before clicking "play," as the button will remove the hold properties before bringing in a new set of dice.

There are tool tips in place that allows you to hover over any score box, and it will tell you the score you can get from the current listed dice. 
Once you've filled in a score box, that box is disabled, as it would be in Yahtzee. 
The game ends when you've filled in all of the score boxes and they're disabled. 

The tricky point comes with the YAHTZEE score. The rule is that you could potentially have unlimited YAHTZEE's, the first being worth 50 points, and each consecutive being worth 100 points! This also means that the box didn't need to be disabled if someone put a valid score in that box, which also means that the game isn't necessarily over after 13 rounds. 
To cover this, I added special mechanics to the YAHTZEE scorebox. 
If the player clicks on that scorebox without having a Yahtzee, the score entered in that box is 0, the box is disabled, and the turn counter is decremented. 
If the player gets a yahtzee, and clicks that scorebox, they will get a score of 50 points added, the turn ends, and the box is still enabled. If the player goes the rest of the game without finding a second yahtzee, at any point the player can click on the yahtzee box to disable it and decrement the turn counter. HOWEVER, this will not end the turn unless it is the very last option.
If the player gets 1 yahtzee, that scorebox will show 50 points. If the player gets a second yahtzee, the scorebox will add 100, showing 150 at this point. And 250, 350, however lucky you can get.
