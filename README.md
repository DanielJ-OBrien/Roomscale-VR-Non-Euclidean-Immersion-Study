# VRDisseration
A copy of the program I used as an experiment in my dissertation.

The purpose of my study was to measure how employing non-Euclidean geometric concepts to a roomscale VR level could influence the players immersion.

It consists of 4 levels - a home screen, and 3 separate experiment rooms. Each room has a different method of traversing between areas. The main exciting way is by using portals that represent two rooms occupying the same physical space. This, in theory, would improve the players immersion as they are never taken out of the game, as opposed to more traditonal methods such as teleports or fades to black.

![image](https://github.com/DanielJ-OBrien/VRDisseration/assets/99108127/e54487c4-8d42-488a-86c0-976195bb86aa)

The third rooms places the portal in a hallway, with the intention of making it less obvious it is a portal.

![image](https://github.com/DanielJ-OBrien/VRDisseration/assets/99108127/c569c1d1-f9e3-4170-ad90-c2de5d7d3071)

The portals work using an advanced shader and maths to calculate the position where the player *would* be on the other side of the portal. It then has a separate script to teleport the player at the appropriate time.
