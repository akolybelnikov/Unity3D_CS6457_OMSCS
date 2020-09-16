### Andrey Kolybelnikov

### andrey@gatech.edu

### akolybelnikov3

## Completed Requirements

### 1 Basic Rigidbodies with Collision Events

    - Created three blue rigidbody spheres and attached scripts for collision events and velocity control.

### 2 Physics Layers Example

    - Made three red spheres that are part of the red layer; disabled red layer objects collision with each other.

### 3 Compound Collider for Complex Geometry

    - Imported a Kitsun mask from the assets store and added a few child game objects that contain colliders,
      but are invisible and have no rigidbody. The resulting compound collider approximates the form of the mask.
    - Added a sound on a collision event of the mask.

### 4 Chain with Joint Constraints

    - Created a chain of yellow cylinders and attached a velocity script to make the chain swing at the start of the game.

### 5 Mecanim-Animated Kinematic Elevator

    - Added an Elevator platform to the scene that has an animation attached; added a red ball on top of the platform.
      The ball bounces every time the Elevator goes up.

### 6 Customized Center of Mass

    - Added a Weeble Wobble object with a capsule rigidbody and a customized center of mass. 
      Made it a prefab and added a two more instances of it rotated at different angles. 

### 7 Default Friction

    - Added a purple cude with default friction on top of the ramp. The cube won't slide down when the game starts.

### 8 Custom Friction

    - Added a green cube that has a new physics material with mimimal friction. The cube slides down the ramp. 

### 9 Bouncy Rigidbody

    - Created and added am orange sphere with a new bouncy material.

### 10 Ragdoll

    -  Created and added a Y-bot ragdoll with the bones assigned. Placed it over the nearest hurdle.

### 11 Scripting Forces

    - Created a prefab for Jumping Black Beans with a script that applies random force on X and Y axes,
      in order for the objects to jump upon touching the ground.

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

The player movement can be controlled with arrow keys of the keyboard, charcater switch is performed with the `t` key.
Match Target is performed with the left `ctrl` key when the root-motion dude is in the proximity of the button.
