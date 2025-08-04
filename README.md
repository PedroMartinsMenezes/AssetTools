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

The AssetTools currenty works for the 16240 uasset files of UE5.5:

- Please install UE5.5 into `C:/Program Files/Epic Games/UE_5.5` to run the unit test `Test_01_UE55_Assets`.

The AssetTools also works for the 498 files of sample project [Cropout](https://www.fab.com/listings/bd733d81-7c29-44fe-b53f-65b14d06a9e2):

- Please install the `Cropout` into `C:/UE/CropoutSampleProject` to run the unit test `Test_02_Cropout_Assets`.

The AssetTools also works for the 1888 of sample project [StackOBot](https://www.fab.com/listings/b4dfff49-0e7d-4c4b-a6c5-8a0315831c9c):

- Please install the `StackOBot` into `C:/UE/StackOBot` to run the unit test `Test_03_StackOBot_Assets`.

The AssetTools also works for the 8722 of sample project [Lyra](https://www.fab.com/listings/93faede1-4434-47c0-85f1-bf27c0820ad0):

- Please install the `Lyra` into `C:/Program Files/Epic Games/UE_5.5/Samples/Games/Lyra` to run the unit test `Test_04_Lyra_Assets`.

## Current Limitations

- The AssetTools has very limited support `Cooked Assets`. This is a work in progress and we need to improve coocked assets processing.

- The bottom of the any uasset file contains the raw byte array data. 
Our generated JSON saves this data into the `Footer` member of the `AssetPackage` object. 
We need to work more to display this data in high level data structure.