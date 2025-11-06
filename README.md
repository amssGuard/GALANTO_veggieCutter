# Fruit Cut — Unity Mini Game

A simple and interactive **3D Fruit Cutting Game** made in **Unity**.  
Chop fruits with a moving knife, pick up and move the sliced halves, and trigger new spawns dynamically.

---

## Gameplay Overview

- Control the **knife** to slice fruits using arrow keys.  
- Once cut, the fruit splits into two physics-based halves.  
- Pick up each half individually using your **mouse click**.  
- Move the selected half with **arrow keys** (← →).  
- When the sliced halves are moved to the **trigger zone**, a **new fruit** automatically spawns!

---

## Features

 Fruit cutting mechanic using **colliders and physics**  
 Interactive **selection system** for moving individual halves  
 **Trigger-based fruit spawner** to keep gameplay continuous  
 Made in Unity 6000
  

---

## Controls
```
 Action                 | Key / Input 
 Move Knife Up / Down   | ↑ / ↓ 
 Slice Fruit            | Knife passes through fruit 
 Select Fruit Half      | Left Mouse Click 
 Move Selected Half     | ← / → 
 Spawn Next Fruit       | Move half into trigger zone 
```
---

##  Project Structure
```bash
Assets/
├── Scripts/
│ ├── Blade.cs
│ ├── FruitCut.cs
│ ├── FruitHalf.cs
│ ├── FruitPicker.cs
│ └── FruitSpawner.cs
├── Prefabs/
│ ├── Fruit.prefab
│ ├── Knife.prefab
│ └── Spawner.prefab
├── Scenes/
│ └── MainScene.unity
└── Materials/
└── (Fruit and Table Materials)
```


##  How to Run

1. **Clone this repository**
   ```bash
   git clone https://github.com/amssGuard/GALANTO_veggieCutter.git
