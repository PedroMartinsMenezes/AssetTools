# AssetTools

[![GitHub stars](https://img.shields.io/github/stars/PedroMartinsMenezes/AssetTools?style=flat-square)](https://github.com/PedroMartinsMenezes/AssetTools/stargazers)
[![GitHub issues](https://img.shields.io/github/issues/PedroMartinsMenezes/AssetTools?style=flat-square)](https://github.com/PedroMartinsMenezes/AssetTools/issues)
[![License](https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square)](LICENSE)
![UE Version](https://img.shields.io/badge/Unreal%20Engine-5.x-green?style=flat-square)

`AssetTools` is a standalone utility designed to automate and manage **Unreal Engine** assets outside of the editor.  

- It can generate the `JSON` file from the `uasset` file, allowing us to see is data structure.

- It can also recreate the original `uasset` file from the `JSON` file.

- The TechNotes can be found in [TECHNOTES](TECHNOTES.md).

---

## ✨ Features

Current state:

- 🗂️ Works with `non cooked` **UE4** and **UE5** assets files like `.uasset` and `.umap`.
- 🗂️ Works with **non cooked** only.
- 🖥️ Cross-platform (Windows/Linux, if applicable).

Maybe in the future:

- 🔁 **Bulk Asset Renaming** – Mass-rename assets using rules, prefixes, patterns or data files  
- 🔍 **Dependency Graph Analysis** – Detect what assets depend on others (or are unused)  
- 📥 **Automated Asset Importing** – Batch import textures, meshes, audio, etc. programmatically 

---

## 🚀 Getting Started

### 📦 Installation
```bash
git clone https://github.com/PedroMartinsMenezes/AssetTools.git
cd AssetTools
dotnet build
```

## ▶️ Basic Usage

### UAsset to Json

Generates `JSON` file from `uasset` file:
```
AssetTool.exe uasset-to-json -i Input.uasset -o Output.json
``` 

### Json to UAsset

Generates `uasset` file from `JSON` file:
```
AssetTool.exe json-to-uasset -i Input.json -o Output.uasset
```

### Checking the tool

Before using the Tool, please check if it work for your particular asset file:

```
AssetTool.exe Input.uasset -log
```

## ✅ Running the UnitTests

To be able to run the UnitTests that check the capabilities of AssetTools please download the required dependencies.

### UE Source Codes

| UE Version                | File Count | Status | Unit Tests |
| -----                 | -----      | -----  | -----     |
| [UE_5.6](https://github.com/EpicGames/UnrealEngine/tree/5.6)   | 19026 / 170    | 100%   | `Test_UE56_Assets`  / `Test_UE56_Maps` |
| [UE_5.5](https://github.com/EpicGames/UnrealEngine/tree/5.5)   | 16240 / 188    | 100%   | `Test_UE55_Assets`  / `Test_UE55_Maps` |
| [UE_5.4](https://github.com/EpicGames/UnrealEngine/tree/5.4)   | 15577 / 179    | 100%   | `Test_UE54_Assets`  / `Test_UE54_Maps` |
| [UE_5.3](https://github.com/EpicGames/UnrealEngine/tree/5.3)   | 13560 / 162    | 100%   | `Test_UE53_Assets`  / `Test_UE53_Maps` |
| [UE_5.2](https://github.com/EpicGames/UnrealEngine/tree/5.2)   |  9997 / 155    | 100%   | `Test_UE52_Assets`  / `Test_UE52_Maps` |
| [UE_5.1](https://github.com/EpicGames/UnrealEngine/tree/5.1)   |  9733 / 155    | 100%   | `Test_UE51_Assets`  / `Test_UE51_Maps` |
| [UE_5.0](https://github.com/EpicGames/UnrealEngine/tree/5.0)   |  8717 / 148    | 100%   | `Test_UE50_Assets`  / `Test_UE50_Maps` |
| [UE_4.27](https://github.com/EpicGames/UnrealEngine/tree/4.27) |  7436 / 137    | 100%   | `Test_UE427_Assets` / `Test_UE427_Maps` |
| [UE_4.26](https://github.com/EpicGames/UnrealEngine/tree/4.26) |  7039 / 134    | 100%   | `Test_UE426_Assets` / `Test_UE426_Maps` |
| [UE_4.25](https://github.com/EpicGames/UnrealEngine/tree/4.25) |  5992 /  96    | 100%   | `Test_UE425_Assets` / `Test_UE425_Maps` |
| [UE_4.24](https://github.com/EpicGames/UnrealEngine/tree/4.24) |  5240 /  67    | 100%   | `Test_UE424_Assets` / `Test_UE424_Maps` |
| [UE_4.23](https://github.com/EpicGames/UnrealEngine/tree/4.23) |  4127 /  38    | 100%   | `Test_UE423_Assets` / `Test_UE423_Maps` |
| [UE_4.22](https://github.com/EpicGames/UnrealEngine/tree/4.22) |  3833 /  38    | 100%   | `Test_UE422_Assets` / `Test_UE422_Maps` |
| [UE_4.21](https://github.com/EpicGames/UnrealEngine/tree/4.21) |  3622 /  39    | 100%   | `Test_UE421_Assets` / `Test_UE421_Maps` |
| [UE_4.20](https://github.com/EpicGames/UnrealEngine/tree/4.20) |  3377 /  38    | 100%   | `Test_UE420_Assets` / `Test_UE420_Maps` |
| [UE_4.19](https://github.com/EpicGames/UnrealEngine/tree/4.19) |  2998 /  39    | 100%   | `Test_UE419_Assets` / `Test_UE419_Maps` |
| [UE_4.18](https://github.com/EpicGames/UnrealEngine/tree/4.18) |  2829 /  37    | 100%   | `Test_UE418_Assets` / `Test_UE418_Maps` |
| [UE_4.17](https://github.com/EpicGames/UnrealEngine/tree/4.17) |  2727 /  37    | 100%   | `Test_UE417_Assets` / `Test_UE417_Maps` |
| [UE_4.16](https://github.com/EpicGames/UnrealEngine/tree/4.16) |  2649 /  35    | 100%   | `Test_UE416_Assets` / `Test_UE416_Maps` |
| [UE_4.15](https://github.com/EpicGames/UnrealEngine/tree/4.15) |  2708 /  35    | 100%   | `Test_UE415_Assets` / `Test_UE415_Maps` |
| [UE_4.14](https://github.com/EpicGames/UnrealEngine/tree/4.14) |  2676 /  35    | 100%   | `Test_UE414_Assets` / `Test_UE414_Maps` |
| [UE_4.13](https://github.com/EpicGames/UnrealEngine/tree/4.13) |  2599 /  35    | 100%   | `Test_UE413_Assets` / `Test_UE413_Maps` |
| [UE_4.12](https://github.com/EpicGames/UnrealEngine/tree/4.12) |  2534 /  32    | 100%   | `Test_UE412_Assets` / `Test_UE412_Maps` |
| [UE_4.11](https://github.com/EpicGames/UnrealEngine/tree/4.11) |  2221 /  32    | 100%   | `Test_UE411_Assets` / `Test_UE411_Maps` |
| [UE_4.10](https://github.com/EpicGames/UnrealEngine/tree/4.10) |  2122 /  31    | 100%   | `Test_UE410_Assets` / `Test_UE410_Maps` |
| [UE_4.9](https://github.com/EpicGames/UnrealEngine/tree/4.9)   |  2124 /  31    | 100%   | `Test_UE409_Assets` / `Test_UE409_Maps` |
| [UE_4.8](https://github.com/EpicGames/UnrealEngine/tree/4.8)   |  2498 /  31    | 100%   | `Test_UE408_Assets` / `Test_UE408_Maps` |
| [UE_4.7](https://github.com/EpicGames/UnrealEngine/tree/4.7)   |  1614 /  24    | 100%   | `Test_UE407_Assets` / `Test_UE407_Maps` |
| [UE_4.6](https://github.com/EpicGames/UnrealEngine/tree/4.6)   |  1897 /  27    | 100%   | `Test_UE406_Assets` / `Test_UE406_Maps` |

### UE Samples Projects

| Source                | File Count | Status | Unit Test |
| -----                 | -----      | -----  | -----     |
| [Cropout](https://www.fab.com/listings/bd733d81-7c29-44fe-b53f-65b14d06a9e2) | 498 | 100% | `Test_Cropout_Assets` |
| [StackOBot](https://www.fab.com/listings/b4dfff49-0e7d-4c4b-a6c5-8a0315831c9c) | 1888 | 100% | `Test_StackOBot_Assets` |
| [Lyra](https://www.fab.com/listings/93faede1-4434-47c0-85f1-bf27c0820ad0) | 8722 | 100% | `Test_Lyra_Assets` |

### UE ThirdParty Plugins

| Source                | File Count | Status | Unit Test |
| -----                 | -----      | -----  | -----     |
| [Smartsuit](https://github.com/Rokoko/rokoko-studio-live-unreal-engine) | 56 | 100% | `Test_UE54_Assets` and `Test_UE54_Maps` |


## 📘 Use Cases

| Scenario                                    | Benefit                          |
| ------------------------------------------- | -------------------------------- |
| Cleaning a legacy project                   | Bulk rename + dependency cleanup |
| Preparing assets for Marketplace submission | Automated prefixing & validation |
| Importing 1000+ assets from DCC tools       | Batch import without opening UE  |
| CI/CD asset validation                      | Run in GitHub Actions / Jenkins  |
| Detecting unused or circular dependencies   | Visual dependency graph export   |


## 🛠️ Roadmap

- GUI version for non-technical users

- Export dependency graph to .png / .svg

- Add CSV/JSON rename rule system

- Support drag-and-drop import pipeline

- Unreal Editor plugin version for integrated workflow

## 🤝 Contributing

Pull Requests and Issues are welcome! If you have ideas, bugs, or feature requests, feel free to open an issue.

## ⭐ Support the Project

If this tool is useful to you, please consider giving it a star — it helps visibility and development.

## 📜 License

This project is licensed under the MIT License.
See the [LICENSE](LICENSE) file for details.
