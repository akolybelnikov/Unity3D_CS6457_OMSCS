### Andrey Kolybelnikov

### andrey@gatech.edu

### akolybelnikov3

## Completed Requirements

### 1 Working Game Start Menu

    - Overlay UI Panel with Start Game and Exit buttons
    - Camera background with postprocessing effect

### 2 Working In-Game Menu

    - Overlay UI Panel with Restart Game and Exit buttons
    - Panel is toggled on and off with Escape button
    - Game pauses when Menu is enabled

### 3 Collectable Ball that only SomeDude_RootMotion can collect

    - Pink collectable Sphere that isTrigger and has a script attached

### 4 Trigger Based Mechanim-Animated Object

    - Created a Door prefab with an Animator, Animation and a script attached. The door is inside of an empty root object that can be placed anywhere in the world and the door position and rotation is relative to this root object.

    - I chose to make a door after a feed-back from my team. The door animation can be changed for the door to slide on x or y axis instead of rotating. The door prefab will be used in our team game project.

#### Known bugs

    I had to intrduce some simple state checks because the door behavior was poorly controlled by the trigger-enter and trigger-exit events: sometimes the door would stuck in the open state and repeat the open-close animation next time the Dude character would pass by, but then in a reversed uncontrollable manner. The state checks made the behavior almost 100% predictable.

### 5 Extra credit: SomeDude_RootMotion throwing a ball

    - Added an Elevator platform to the scene that has an animation attached; added a red ball on top of the platform.
      The ball bounces every time the Elevator goes up.

## Project Instructions

### External resources

The project includes an imported package acquired int he Unity Assets Store, Kitsun Mask.

### Building and Running the code

The project submission includes a working build of the game for both target platform OSX and Windows, both tested locally.

Add the project to your Unity Hub and open it in the Unity3D to generate all the files and folders locally.

After the files of the project have been generated from the Project Settings, a new build/game can be run.

### Grading

To check if the game meets the assignemnt requirements, the project can be run with the executive files,
or opened in Unity and run in developer mode. The project includes only one scene, **demo**.

The player movement can be controlled with arrow keys of the keyboard, character switch is performed with the `t` key.

Match Target is performed with the left `ctrl` key when the root-motion dude is in the proximity of the button.

Toggle UI panel is performed with Escape button.

The Door-prefabs are located one after another on the right side of the scene relative to the start position of the characters.
