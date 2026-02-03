# HW4
## Devlog
The BirdController class defines the control side, and the PointsUI and AudioManager define the view side of this pattern.
The BirdCotroller defines the conditions of when to add points and what condition will the player die. The PointsUI changes the TextMeshPro displayed and AudioManager plays a sound according to the event.

Two events are defined in the BirdController class and connect to method handlers in both view class. The Scored event will call PointUI's HandleScored() which contains change to  _pointText, as well as AudioManager's HandleScored() which contains _Die.Play(). The Die event works similarly.

A Singleton named Locator is used so that Both PointsUI and AudioManager can access the BirdController class without SerializeField.



## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
