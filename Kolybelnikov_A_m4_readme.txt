### Andrey Kolybelnikov

### andrey@gatech.edu

### akolybelnikov3

## Completed Requirements

### 1 AI controlled Minion visits 5 stationary waypoints(that are visible)

    - There are 5 half-transparent green cubes that are waypoints
    - AI controlled Minion starts the round by visiting them all before going after the moving target

### 2 AI controlled Minion heads off moving waypoint(that is visible)

    - After visiting all the static waypoints AI controlled Minion tries to head off the 6th, moving half-transparent green cube / waypoint

### 3 AI is controlled by procedural state machine of at least 2 states

    - There are two states, one for the static waypoints and one for the moving one

### 4 Minion is animated with steps and not sunk into ground

    - Implemented with `animator.SetFloat("vely", agent.velocity.magnitude / agent.speed);`

#### Known bugs

    - there are no known bugs except the AI controlled Minion is not able to correctly predict the position of the moving waypoint from the first time

## Project Instructions

### External resources

The project includes an imported package acquired int he Unity Assets Store, Kitsun Mask.

### Building and Running the code

The project submission includes a working build of the game for both target platform OSX and Windows, both tested locally.

Add the project to your Unity Hub and open it in the Unity3D to generate all the files and folders locally.

After the files of the project have been generated from the Project Settings, a new build/game can be run.

### Grading

To check if the game meets the assignemnt requirements, the project can be run with the executive files,
or opened in Unity and run in developer mode. The project includes only one scene, **demo**. The scene is using a fixed camera for the purpose of this assignment.
