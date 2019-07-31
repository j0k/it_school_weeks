```
Game, Level, Monster

example: level 10x10
============
=          =
=          =
=          =
=          =
=          =
=          =
=          =
=          =
=          =
=          =
============

example: level 10x10 with player
============
=          =
=          =
=          =
=  P>      =
=          =
=          =
=          =
=          =
=          =
=          =
============

============
=          =
=          =
=          =
<P         =
=          =
=          =
=          =
=          =
=          =
=          =
============

============
=          =
=          =
=     ^    =
=     P    =
=          =
=          =
=          =
=          =
=          =
=          =
============

============
=          =
=          =
=          =
=     P    =
=     v    =
=          =
=          =
=          =
=          =
=          =
============

'>' symbol show Player's orientation

on each step player can make movements: a,w,s,d = (left, up, down, right)


============
=          =
=          =
=          =
=     P    = turn s
=     v    =
=          =
=          =
=          =
=          =
=          =
============

============
=          =
=          =
=          =
=          = turn s
=     P    =
=     v    =
=          =
=          =
=          =
=          =
============

============
=          =
=          =
=          =
=          = turn s
=          =
=     P    =
=     v    =
=          =
=          =
=          =
============

============
=          =
=          =
=          =
=          = turn d
=          =
=      P>  =
=          =
=          =
=          =
=          =
============

============
=          =
=          =
=          =
=          = turn d
=          =
=       P> =
=          =
=          =
=          =
=          =
============

 gun if press 'f' - fire;
============
=          =
=          =
=          =
=          =  
=       ^  =
=       P  =
=          =
=          =
=          =
=          =
============

gun if press 'f' - fire (2 steps per time step);
============
=          =
=          =
=          =
=       o  =  
=       ^  =
=       P  =
=          =
=          =
=          =
=          =
============

gun if press 'f' - fire;
============
=          =
=       o  =
=          =
=          =  
=       ^  =
=       P  =
=          =
=          =
=          =
=          =
============

there are monsters
============
=          =
=  m       =
=          =
=          =  
=       ^  =
=       P  =
=          =
=          =
=          =
=          =
============

monsters want to reach the player position and eat the player
============
=          =
=  m       =
=          =
=          =  
=       ^  =
=       P  =
=          =
=          =
=          =
=          =
============

============
=          =
=          =
=  m       =
=          =  
=       ^  =
=       P  =
=          =
=          =
=          =
=          =
============

sometimes monsters came out from Monsters cave
====M=======
=   m      =
=          =
=          =
=          =  
=       ^  =
=       P  =
=          =
=          =
=          =
=          =
============

====M=======
=          =
=   m      =
=          =
=          =  
=       ^  =
=       P  =
=          =
=          =
=          =
=          =
============

and go straight to the player
====M=======
=          =
=    m     =
=          =
=          =  
=       ^  =
=       P  =
=          =
=          =
=          =
=          =
============

if they reach the player => player.life --; monster.life --;

for example: each monsters have only 1 life points. player have more then one;
also player can fire the monster
```
