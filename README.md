# ArlosQuest
 Game Off 2024

PAID & FREE ASSETS FROM THE UNITY ASSET STORE (You need them in order to run the cloned project)

2DxFX
Manor Interior Mega Pack
Beautiful Transitions
Damage Numbers Pro
DOTween PlayMaker Actions
Monster Bear (Free)
RPG_Animations_Pack_FREE
Everyday Motion Pack
Animations Crafter
Warrior Pack Bundle 1 FREE
Warrior Pack Bundle 2 FREE
Warrior Pack Bundle 3 FREE
Fantasy Adventure Environment
Tail Animator
Beautiful Transitions
Cartoon FX Remaster 1 & 2
Toony Colors Pro
GUI Pro-Simple Casual
Low Poly Dungeons
PlayMaker
PSX Effects
RPG Cameras & Controllers
Suburb Neighborhood House Pack



THIRD PARTY FREE ASSETS

Script TypingEffect by Joshua Wiscaver (https://medium.com/@joshua.wiscaver/creating-a-typing-effect-in-unity-2b2526fdc427)

"Game Console" (https://skfb.ly/oHnW7) by Manuel W. is licensed under Creative Commons Attribution-NonCommercial (http://creativecommons.org/licenses/by-nc/4.0/).

"Black Boy Rigged Ready For Ue4" (https://skfb.ly/oP8uB) by MotionStudioArts is licensed under Creative Commons Attribution (http://creativecommons.org/licenses/by/4.0/).

"AI generated Comics" (https://skfb.ly/ozWYP) by n-malmberg is licensed under Creative Commons Attribution (http://creativecommons.org/licenses/by/4.0/).

"Wii U - Mario Kart 8 - N64 Yoshi Valley" (https://skfb.ly/pqrp7) by H,yoshi is licensed under Creative Commons Attribution (http://creativecommons.org/licenses/by/4.0/).

"Giant cockroach" (https://skfb.ly/oZzSO) by Drillimpact is licensed under Creative Commons Attribution (http://creativecommons.org/licenses/by/4.0/).

"FREE - SkyBox Cliffside" (https://skfb.ly/oIHRt) by Paul is licensed under Creative Commons Attribution (http://creativecommons.org/licenses/by/4.0/).

Script WorldspaceOverlayUI by Julien-Lynge & ElectricFalcon91, found at: https://discussions.unity.com/t/world-space-canvas-on-top-of-everything/128165/5

"Cartoon two-story villa low polygon 3D model" (https://skfb.ly/pq6zT) by 3D Model Messenger is licensed under Creative Commons Attribution (http://creativecommons.org/licenses/by/4.0/).

"Cartoon wooden house low polygon 3D model" (https://skfb.ly/pq6wI) by 3D Model Messenger is licensed under Creative Commons Attribution (http://creativecommons.org/licenses/by/4.0/).

"Cartoon Villa Wooden House Low Polygon 3D Model" (https://skfb.ly/p7ZVJ) by 3D Model Messenger is licensed under Creative Commons Attribution (http://creativecommons.org/licenses/by/4.0/).

"Church" (https://skfb.ly/NQDE) by R-LAB is licensed under Creative Commons Attribution (http://creativecommons.org/licenses/by/4.0/).

"Low-Poly Church - Modular Kit" (https://skfb.ly/oLXqO) by _memo is licensed under Creative Commons Attribution (http://creativecommons.org/licenses/by/4.0/).

"The cart Insulator" (https://skfb.ly/69yAV) by VitSh is licensed under Creative Commons Attribution (http://creativecommons.org/licenses/by/4.0/).

"Waggon" (https://skfb.ly/69ySr) by VitSh is licensed under Creative Commons Attribution (http://creativecommons.org/licenses/by/4.0/).

"( FREE ) Ship in a bottle" (https://skfb.ly/6YJyU) by SDC PERFORMANCE™️ is licensed under Creative Commons Attribution (http://creativecommons.org/licenses/by/4.0/).




BUGS FIXED AFTER DEADLINE

There were some bugs that prevented the player to reach the game ending, all of them in the Boss fight. We didn't change anything else, as you can check comparing git commits.

*   PlayMaker FSM 'FSM' in Game Object 'Action Trigger - Church Secret Door 1': wrong PLAYER position/rotation after Boss battle,
    which caused the player to end up falling eternally after defeating the enemy. Changed the 2 variables to the correct ones
    (from churchExteriorPosition & churchExteriorRotation to newPos & newRot) 

*   Game Object 'Action Trigger - LAST DOOR', which triggers the ending cutscene, left deactivated by mistake. Activated it.

*   PlayMaker FSM 'Victory' in Game Object 'BattleManager ********** BOSS': PLAYER's controller not activated after Boss battle.
    Forced activation in one of the states of this FSM.

*   Game Object 'God Mode' was causing a critical bug in the Boss Fight, preventing it to be finished. Deactivated.

*   PlayMaker FSM 'FSM' in Game Object 'Dialogue Trigger', child of NPC's Game Object 'Ozono': it was suposed to add the battle version
    of the NPC (summon) to an array in both 'Char_Cer' and 'Char_Cer BOSS' Game Objects, but for some reason it wasn't working in the
    Boss fight and, whenever a player tried to invoke Ozono, the game wouldn't find the Game Object and would freeze forever.
    Game Object manually added to both Char_Cer arrays, no longer dependant of this 'Set Fsm Array Item' actions.

*   PlayMaker FSM 'Enemy_IA' in Game Object 'Enemy_BOSS': there's a cutscene that is suposed to trigger a 3-turn countdown,
    after which the event 'TEAR_COUNTER' would trigger the Boss's special attack cutscene. This previous cutscene would freeze the
    game at one point. Bypassed the countdown connecting state "Special Done?" with "Subtract Cycle 2" instead of "Special Attack".