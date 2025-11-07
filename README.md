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
