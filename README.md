
# AR Bowling Game

This is an Augmented Reality (AR) Bowling game built using Unity and ARFoundation. The game utilizes the device's camera to detect the ground and allows players to place and interact with a bowling alley in real-world space.

## Features
- **AR Integration:** Detects ground planes using the camera of Android devices to place the game environment.
- **Bowling Simulation:** Classic bowling setup with 10 pins and a ball, all controlled by real-world physics.
- **Two Game Scenes:**
  - **Title Screen:** Welcome screen with an option to start the game.
  - **Game Scene:** The main bowling game, where players can interact and play.
- **Interactive UI:** Buttons to reset the game or retry a throw without restarting completely.
  
## Gameplay
1. **Setup:** Once the game is launched, the player scans the ground using their device's camera. The bowling lane appears on the detected plane.
2. **Throwing the Ball:** The player can throw the ball using touch gestures. The physics engine simulates the ball’s motion and interaction with the pins.
3. **Retry or Reset:** Players can retry the throw or reset the entire game using on-screen buttons.

## AR Foundation Components
- **AR Session & AR Session Origin:** Used for camera control and plane detection, allowing the bowling lane to be placed on the floor in augmented reality.
- **PlaceOnPlane:** Script used to detect horizontal planes and position the bowling alley assets.

## Scripts
- **BowlingBall.cs:** Manages the physics of the ball, calculating the force applied based on touch input. Supports both touch and mouse input.
- **PanelScript.cs:** Used on the title screen to detect touches that start the game.
- **PlaceOnPlane.cs:** Handles the detection of horizontal planes and positions the bowling assets on these planes.
- **Restart.cs:** Reloads the game scene, resetting the ball and pins to their original positions.
- **TryAgain.cs:** Deletes the current ball and spawns a new one without resetting the pins.

## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/imariagg/bowling-arfoundation.git
   ```
2. Open the project in Unity (version 2021.3.11f1 LTS or later recommended).
3. Ensure that AR Foundation and ARCore XR plugins are installed in the project.
4. Build the project for Android devices.

## Requirements
- Unity 2021.3.11f1 (LTS)
- ARFoundation 4.1.7 or later
- ARCore XR Plugin for Android builds

## Demo Video
You can find a demo video showcasing the gameplay 

https://github.com/user-attachments/assets/8e5665d1-7fcd-4102-8b56-8e1aa02dc215

## Future Improvements
- Optimizing plane detection for larger spaces.
- Enhancing ball physics and pin collision responses.
- Adding multiplayer or leaderboard functionality.

## Credits
Developed by María García Gómez using Unity and ARFoundation.
