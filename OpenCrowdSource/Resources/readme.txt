/ -------------------------------- \
| OPEN CROWD SOURCE - HOME EDITION |
\ -------------------------------- /
            Version 1.0

Table of contents

1. What have I downloaded? What is this? SWEET JESUS HELP ME

2. Rules of the game
     2.1 The cards
     2.2 The twists
     2.3 Resetting decks

3. Creating custom decks
     3.1 Anatomy of a deck XML
          3.1.1 Adding cards
          3.1.2 Adding twists
     3.2 How to play custom decks

4. Credits
5. License information



1. What have I downloaded? What is this? SWEET JESUS HELP ME
------------------------------------------------------------

Calm down. What you have downloaded is a simple yet highly addictive party game known as "Open Crowd Source."

The origins of this game lie within the fertile yet dangerous mind of one Dr. Gareth Millward, who suggested it to Frederik Olsen and Troels Pleimert (hosts of the podcast Back Seat Designers) one sweet summer morning.

The idea was to design an adventure game in just 30 minutes from randomly selected cards. Taking the idea and running with it, Frederik programmed an application that would randomly select the cards, and also introduce twists along the way to derail the brainstorming. Thus, the Open Crowd Source Machine was born.

The show itself was broadcast live over YouTube with each episode featuring a specially invited guest contestant. You can watch the show over on youtube.com/backseatdesigners.

Seeing as we were having such a good time, we decided to have Fred put together a stable version of the application that would also allow you to play with your own decks. And here you have it: Open Crowd Source - Home Edition.


2. Rules of the game
--------------------

At its core, this is simply a game of randomized cards and a timer. Once you hit "Begin," the game randomly selects four cards from the deck and the timer starts. You then have 30 minutes to sketch out an idea for a game.

When the timer stops, you are no longer allowed to come up with any new design elements. Just sit back and recap what you have come up with.

You are, of course, free to make up your own rules. For instance, you could do like a Shark Tank thing where, once the timer stops, you have to pitch your idea to a person who was not in on the brainstorming session, and that person has to decide whether or not they would want to play that game.

There's even a chance you could have this work in a creative writing class setting where people would pair off into groups and present their stories to the class after the timer runs out. We're just spitballing here.

You don't even have to design a game, specifically. It could be a movie, a book, or whatever you want. It's just a creative exercise.

Really, it's not that complicated. Just have fun with it. We did.

2.1 The cards
-------------

The Machine will give you four cards:

A CHARACTER: This is a central character in the story. It doesn't have to be the protagonist, but it often is.

A LOCATION: This gives you a setting for the story. You're not limited to this one location, but the location must be in the story somewhere.

A TASK: This is the central motivation for the character; what he/she has to accomplish during the story.

A MODIFIER: This is a wildcard that gets thrown in to spice things up. Either it's just a simple word like "vigorously," or it gives you some context to the task, like "using only household items." This is usually where shit gets weird.

2.2 The twists
--------------

Sometime during the 30 minutes, two twists will occur: a MINOR and a MAJOR one.

The purpose of the twists is to throw you a curveball during the planning. Think of it as a game producer, a book publisher or a clueless studio exec sticking his fat head in the door and mandating something that they heard in a focus group once, which they are convinced will make the product sell.

The MINOR twists occur about halfway into the proceedings (when there's 13-17 minutes left). They are supposed to be minor annoyances that you could probably shoehorn in with a little creative latitude, but not something that would break the story.

The MAJOR twists occur right at the end (when there's 3-5 minutes left). These are the major monkey wrenches that some idiot throws into a creative procedure at the 11th hour, and you have no choice but to twist and mangle your creative baby to suit this diabolically stupid mandate.

Twists are what makes the game fun. Sometimes they're a blessing in disguise and can give you that extra kick the story needs to transcend from the mundane into the genius -- and sometimes they're just there to force your creativity into a completely opposite direction.

2.3 Resetting decks
-------------------

"What's that 'reset deck' button for?" you may ask. Good question. That deserves an answer.

When you play the game and the Machine selects a card, it will mark that card as "played" -- meaning that, next time you play the game, you won't see that card again.

If you play a deck long enough, eventually the Machine will run out of cards to deal you, and in that case it will give an error message saying there aren't enough cards in the deck to play.

Hitting "reset deck" before playing means marking all cards as unplayed, so the deck starts over from scratch.


3. Creating custom decks
------------------------

When we came up with this, we wanted to design adventure games. So this game comes packed with the deck that we used in the 1st season of the YouTube show, and it's geared mainly towards adventure game design.

But the Home Edition lets you play with your own decks, and this gives you endless opportunities to have your own fun. Don't like adventure games? Cool; you can make it about ANY kind of game. Don't like games at all? Fine; you can say you're writing a movie, or a book, or a tv-show, or whatever you want.

This section will show you how to build your own custom deck.

3.1 Anatomy of a deck XML
-------------------------

The card decks are located in the folder "Decks" and are in XML format. We have included a "template.xml" which has the bare minimum of cards for you to get started, or you can take a look at the cards from the 1st season of our show for inspiration, which is "default.xml".

Here's how it works: You can put in as many cards as you like. The minimum requirement is that there is, of course, at least one of each (character, location, task and modifier), as well as at least one minor and one major twist. It doesn't care if there are more of one type of card or twist than the other, though, so just go nuts.

Every deck must start by identifying itself thusly:

	<deck name="Whatever">

And every deck must end by closing that tag at the very bottom of the file:

	</deck>

3.1.1 Adding cards
------------------

Between those two tags, you can put in your cards. Here's the syntax for a card:

	<location id="1">
	  <value>The Gobi desert</value>
	  <played>0</played>
	</location>

The first line identifies what type of card it is. They can either be "location," "character," "task" or "modifier."

The first line also includes a unique ID. *EVERY* card must have a unique ID. We cannot stress this enough. If you neglect to give a card an ID, the game won't be able to mark that card as played. If you give two cards the same ID, then the game will mark both those cards as played, even though it's only displayed one of them. That's bad. Don't do that.

The second line is the actual card itself. Whatever you put between the <value></value> tags are printed verbatum in the game, with the exception of "task" cards which will automatically put the word "must" in front of the value. So, a "task" card with the value "rummage through their sister's sock drawer" will display in the game as "MUST rummage through their sister's sock drawer."

The third line denotes whether the card has been played or not. If the value is "0," then the card is unplayed. If the value is "1," then the card has been marked as played and won't be dealt when you play. It stands to reason, then, that when adding in new cards, you should always set this value to "0."

Finally, the fourth line "closes" the card. Of course, it must match what you put in the first line, so if it's a "task," you would put "</task>". Don't forget this line. The deck will be unplayable if you forget to "close" a card.

3.1.2 Adding twists
-------------------

Adding twists works the same way as adding cards. A twist has the following syntax:

	<minorTwist id="5">
	  <value>This is a minor twist.</value>
	  <played>0</played>
	</minorTwist>

As you can see, there's no difference, other than the name of the opening and closing tag. Twists are named "minorTwist" and "majorTwist".

3.2 How to play custom decks
----------------------------

Simple. Once you've created your custom deck, put it in the "Decks" folder. The folder was created where you put the game .exe. The game simply looks in this folder for xml files, and, if it finds any, adds them to the dropdown menu in the game.

Before you start the game, you can select the deck you want to play from the dropdown menu next to the "Begin" button.

There you go! Custom play ahoy!


4. Credits
----------

Original concept:    Gareth Millward
Programming:         Frederik Olsen
Artwork:             Lone Merete Jensen
Logo:                Kevin Wallace
Documentation:       Troels Pleimert
Sound effects:       Freesound.org

All sound effects derive from Freesound.org, and are licensed under Creative Commons 0.

Visit our website at www.backseatdesigners.com

Watch the show at youtube.com/backseatdesigners

Here's the playlist for season 1 of Open Crowd Source: https://www.youtube.com/playlist?list=PLOfZYdcpQ-FM2thaiuN8C-d6wtIqEprMb

Our thanks to the guests of season 1 who made this much more fun that we ever thought it would be: Francisco Gonzalez, David X. Newton, Brian "Demodulated" Devins, Bianca Devins, Shawn Mills, Jess Morrissette, Serena "I'm credited in every game ever" Nelson, Josh Mandel, Diana Rose, and Natalie "Resulka" Juhasz.

And our thanks to all future contestants, of course, because they're also going to make it fun. ;)


5. License information
------------------------

Open Crowd Source - Home Edition is free and open source software, and is released under the GNU GPL 3.0 license.

A full copy of the license can be found in the file gpl-3.0.txt.


// EOF