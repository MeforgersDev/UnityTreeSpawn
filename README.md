# Unity Automated Tree Spawning System

This project implements an automated tree spawning system in Unity using Machine Learning (ML). The system dynamically spawns trees based on different biomes, optimizing tree distribution and diversity.

## Features

- **Biome Management:** Supports multiple biomes with distinct tree types.
- **ML-Agents Integration:** Utilizes Unity ML-Agents for intelligent tree spawning.
- **Procedural Tree Placement:** Automatically places trees based on environmental factors.
- **GitHub Ready:** Organized project structure with necessary configuration files.

## Installation

### Prerequisites

- **Unity:** [Download Unity Hub](https://unity.com/download) and install the latest version.
- **Python:** Ensure Python 3.6 or higher is installed.
- **ML-Agents:** Install ML-Agents via pip.

### Steps

1. **Clone the Repository:**
    ```bash
    git clone https://github.com/MeforgersDev/MyTreeSpawnerProject.git
    ```

2. **Open in Unity:**
    - Launch Unity Hub.
    - Click on `Add`, navigate to the cloned repository folder, and open it.

3. **Install ML-Agents Package:**
    - In Unity Editor, go to `Window > Package Manager`.
    - Click the `+` icon and select `Add package from git URL...`.
    - Enter `https://github.com/Unity-Technologies/ml-agents.git` and install.

4. **Configure the Scene:**
    - Ensure `BiomeManager`, `TreeManager`, and `TreeSpawnerAgent` are properly configured.

## Usage

1. **Set Up Biomes:**
    - Define different biomes in the `BiomeManager` with unique colors and associated tree prefabs.

2. **Train the ML Agent:**
    - Configure training parameters in a `config.yaml` file.
    - Run the training process using ML-Agents.

3. **Run the Scene:**
    - Press `Play` in Unity to see the ML-driven tree spawning in action.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any enhancements or bug fixes.

## License

This project is licensed under the Apache License 2.0. See the [LICENSE](LICENSE) file for details.
