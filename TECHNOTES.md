# AssetTools tech Notes

### Internal Checking Process

When we run the command:
```
AssetTool.exe Input.uasset -log
```

The checking process perfoms these operations: 

| Operation             | Description |
| ------                | ------      |
| uasset to bytes1      | Create the byte array from the uasset file opened for reading |
| bytes1 to obj         | Create the C# `AssetPackage` object from the byte array |
| obj to json           | Create the JSON content from the C# `AssetPackage` object |
| json to obj2          | Create the cloned C# `AssetPackage` object from the JSON |
| obj2 to bytes2        | Create the cloned byte array from the cloned C# `AssetPackage` object |
| compare bytes         | Checks if the original byte array macthes the cloned byte array |
| print result          | Prints SUCCESS if the uasset reconstruction was perfect ! |

---

## Current Tool Status

To run the UnitTests, please: 
- Download the UE version below into the `C:\Epic` folder.
- Go to the folder `AssetTools\Scripts` and run the respective `bat` file.
- That will copy only the `uasset` and `umap` files to the folder `C:\UEFiles`.
- Now you can **optionally** uninstall the UE from the `C:\Epic` folder.
- Finally you can run the UnitTests.

| UE Version                | File Count (uasset / umap) | Status | Unit Test (uasset / umap) |
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

### UE Samples Projects

| Source                | File Count | Status | Unit Test |
| -----                 | -----      | -----  | -----     |
| [Cropout](https://www.fab.com/listings/bd733d81-7c29-44fe-b53f-65b14d06a9e2) | 498 | 100% | `Test_Cropout_Assets` |
| [StackOBot](https://www.fab.com/listings/b4dfff49-0e7d-4c4b-a6c5-8a0315831c9c) | 1888 | 100% | `Test_StackOBot_Assets` |
| [Lyra](https://www.fab.com/listings/93faede1-4434-47c0-85f1-bf27c0820ad0) | 8722 | 100% | `Test_Lyra_Assets` |

### UE ThirdParty Plugins

Please install the missing plugins in case:

| Source                | File Count | Status | Unit Test |
| -----                 | -----      | -----  | -----     |
| [Smartsuit](https://github.com/Rokoko/rokoko-studio-live-unreal-engine) | 56 | 100% | `Test_UE54_Assets` and `Test_UE54_Maps` |

---

## Current Limitations

- The tool does not support `Cooked Assets`. This is a work in progress.

- The bottom of the any uasset file contains the raw byte array data. 
 To provide a high level visualization of it, we need to work to extract its original content to files 
 containing vertex buffers for meshes, audio wave samples, large texture mip-data, etc.
