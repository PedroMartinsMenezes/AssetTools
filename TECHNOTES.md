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

## Running the UnitTests

To run the UnitTests, please: 
- Download the UE version below into the `C:\Epic` folder.
- Go to the folder `AssetTools\Scripts` and run the respective `bat` file.
- That will copy only the `uasset` and `umap` files to the folder `C:\UEFiles`.
- Now you can **optionally** uninstall the UE from the `C:\Epic` folder.
- Finally you can run the UnitTests.

---

## Current Limitations

- The tool does not support `Cooked Assets`. This is a work in progress.

- The bottom of the any uasset file contains the raw byte array data. 
 To provide a high level visualization of it, we need to work to extract its original content to files 
 containing vertex buffers for meshes, audio wave samples, large texture mip-data, etc.
