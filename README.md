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

This code perfoms these transformations: 

| Operation             | Description |
| ------                | ------      |
| uasset to obj         | Perform the binary deserialization of uasset into the C# obj |
| obj to uasset         | Perform the binary serialization into byte array to match the original uasset content |
| obj to json           | Perform the JSON serialization into string to match the output of uasset-to-json command |
| json to obj2          | Perfomr the JSON deserialization to match the same values of original obj |
| obj2 to uasset        | Perform the binary serialization into byte array to match the original uasset content |

and return SUCCESS when all the operations succeed.
