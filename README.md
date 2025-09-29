# AssetTools
Tools to read and write **Unreal Engine** `uasset` files .

The code reads `uasset` files and converts them to their JSON equivalents. This allows us to inspect the contents of the original binary files.

Additionally, the code can read the JSON and recreate the original uasset file.

## How to use

### UAsset to Json

To convert a `uasset` file to a `json` file, run:

```
AssetTool.exe uasset-to-json -i Input.uasset -o Output.json
``` 

### Json to UAsset

To convert a `json` file to a `uasset` file, run:

```
AssetTool.exe json-to-uasset -i Input.json -o Output.uasset
```

### Checking the tool

To check if the tool is able to recreate a `uasset` file, run:

```
AssetTool.exe Input.uasset
```

The checking process perfoms these operations: 

| Operation             | Description |
| ------                | ------      |
| uasset to bytes1      | Read the uasset file into a byte array |
| bytes1 to obj         | Deserializes the uasset file into C# `AssetPackage` |
| obj to json           | Serializes the `AssetPackage` into JSON string |
| json to obj2          | Deserializes the JSON into a second `AssetPackage` |
| obj2 to bytes2        | Serializes the second `AssetPackage` into a new uasset byte array |
| compare bytes         | Checks if the original uasset bytes macthes the recreated uasset bytes |
| print result          | Return SUCCESS if the uasset reconstruction was perfect |

## Current Tool Status

The AssetTools currenty works for these UE versions:

## Runnint the UnitTests

To be able to run the UnitTests to check the capabilities of AssetTools please download the required dependencies.

### UE Source Codes

| Source                | File Count | Status | Unit Test |
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

## Current Limitations

- The AssetTools has very limited support `Cooked Assets`. This is a work in progress and we need to improve cooked assets processing.

- The bottom of the any uasset file contains the raw byte array data. 
Our generated JSON saves this data into the `Footer` member of the `AssetPackage` object. 
We need to work more to display this data in high level data structure.