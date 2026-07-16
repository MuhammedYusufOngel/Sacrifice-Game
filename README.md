# 🕯️ Sacrifice (Working Title)

![Status: Work in Progress](https://img.shields.io/badge/Status-Work_in_Progress-orange?style=for-the-badge)
![Engine: Unity](https://img.shields.io/badge/Engine-Unity_3D-black?style=for-the-badge&logo=unity)
![Language: C#](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp)

> **⚠️ Note:** This project is currently in **active development (Work in Progress)**. All mechanics, visuals, and systems showcased here are experimental and do not represent the final product.

**Sacrifice** is an atmospheric **First-Person Psychological Horror / Survival FPS** game built with Unity 3D and C#. Unlike traditional shooters where players only fight physical threats, *Sacrifice* challenges players to survive while managing a deteriorating psychological condition through its core **Sanity System**.

---

## 🛠️ Features & Development Status

### ✅ Implemented Mechanics
- **First-Person Controller (`PlayerMovement.cs`):**
  - Smooth character movement with Sprinting, Jumping, Gravity handling, and precise Ground checking.
- **Dynamic Weapon & Camera Feedback:**
  - **Weapon Recoil & Sway (`WeaponRecoil.cs`, `WeaponSway.cs`):** Responsive weapon handling with procedural recoil and movement sway.
  - **Camera Recoil & Head Bob (`CameraRecoil.cs`, `HeadBob.cs`):** Immersive view adjustments and realistic procedural head bobbing during walking and sprinting.
  - **Firing System (`WeaponFire.cs`, `Bullet.cs`):** Responsive shooting and bullet mechanics.
- **Sanity System (`SanityManager.cs`):**
  - Dynamic sanity tracking where environmental anomalies and terrifying encounters actively deplete player sanity, triggering sensory distortions.

### ⏳ Planned Features (Roadmap)
- [ ] **Enemy AI & Encounter System:** Intelligent behavior trees for stalking and engaging players.
- [ ] **Inventory & Interaction System:** Item management, inspection, and environmental puzzles.
- [ ] **Sanity Hallucinations:** Visual and audio distortions tied directly to sanity threshold levels.
- [ ] **Atmospheric Sound Design:** Dynamic ambient audio and spatial sound effects.
- [ ] **Level Design & Lighting:** Creepy, immersive environments optimized for tension.

---

## 📂 Project Structure

```text
Sacrafice/
├── Assets/
│   ├── InputSystem_Actions.inputactions   # New Unity Input System setup
│   ├── Prefabs/                           # Weapon, Player, and environmental prefabs
│   ├── Scenes/                            # Sandbox and testing scenes (TestScene.unity)
│   └── Scripts/                           # Core C# scripts (Movement, Weapon, Sanity)
├── ProjectSettings/                       # Unity project configuration
└── Packages/                              # Project dependencies
```

---

## 🚀 Getting Started

### Prerequisites
- **Unity 3D** (Recommended Version: Unity 2022.3 LTS or newer)
- **Visual Studio** or **JetBrains Rider** (for C# scripting)

### Installation
1. Clone this repository to your local machine:
   ```bash
   git clone https://github.com/YOUR_USERNAME/Sacrifice-Game.git
   ```
2. Open **Unity Hub** and click **Add** -> **Add project from disk**, then select the cloned project folder.
3. Open `Assets/Scenes/TestScene.unity` in the Unity Editor and press **Play** to test the current build!

---

## 🤝 Contributing & Feedback

Since this project is currently in the early development stages, feedback, bug reports, and suggestions are welcome! Feel free to open an [Issue](https://github.com/YOUR_USERNAME/Sacrifice-Game/issues) if you have any ideas regarding the game mechanics or sanity features.

---

## 📄 License

This project is currently for development and portfolio purposes. License information will be updated as the project nears completion.
