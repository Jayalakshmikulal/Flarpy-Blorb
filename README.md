# Flarpy Blorb

A small 2D, Flappy Bird–style arcade game built in Unity. Guide the bird through moving pipe gaps, build a score, and restart after a collision or leaving the camera's vertical play area.

## Features

- Rigidbody2D-based flap and gravity gameplay
- Randomly positioned pipe pairs with collision and pass-through scoring
- Game Over state with a Play Again button
- Moving cloud background and animated bird tail

## Gameplay and controls

Press **Space** to flap upward and avoid the pipes. A point is awarded when the bird passes through a pipe gap. Hitting a pipe or leaving the top or bottom of the camera view ends the round. Select **Play Again** to restart. Press **Escape** to quit a standalone build.

## Technology

- Unity 6.4 (Editor version `6000.4.4f1`)
- C# and Unity 2D Physics
- Universal Render Pipeline 2D (URP 17.4.0)
- Unity UI (uGUI)

## Open and run

1. Install Unity Editor `6000.4.4f1` using Unity Hub.
2. In Unity Hub, add this repository's project folder—the folder containing `Assets`, `Packages`, and `ProjectSettings`.
3. Open `Assets/Scenes/SampleScene.unity` and press **Play**.

Unity will resolve packages from `Packages/manifest.json` and `Packages/packages-lock.json` when the project opens.

## Project structure

```text
Assets/
  Scenes/SampleScene.unity       Main game scene
  Settings/                      URP assets and Windows build profile
  *.cs                           Gameplay and background scripts
  *.prefab                       Pipe and cloud prefabs
  *.anim, *.controller           Tail animation assets
  unitytut-*.png                 Bird, pipe, and cloud sprites
Packages/                        Unity package manifest and lock file
ProjectSettings/                 Editor, input, build, and rendering settings
```

## My contribution

I built and tested the playable game loop, including bird movement, pipe spawning and scoring, collision and out-of-bounds Game Over handling, restart behavior, and the moving cloud and tail effects.

## Future improvements

- Add touch or mouse flap controls.
- Save a best score between sessions.
- Add sound effects and music.
- Add a start screen and additional gameplay polish.

## Credits and asset attribution

The repository contains sprite files named `unitytut-*`, but does not document their original source or license. Confirm the asset terms and add any required attribution before redistributing the project.
