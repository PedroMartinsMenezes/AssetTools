using System.Text.Json.Serialization;

namespace AssetTool
{
    public class AssetObject
    {
        public long Offset;

        [JsonIgnore] public long NextOffset => Offset + Size;

        public long Index;
        public long Size;
        public string Type;
        public UObject Obj;

        public T Get<T>() where T : new()
        {
            T obj = new T();
            Obj = obj as UObject;
            return obj;
        }
    }

    public static class AssetObjectExt
    {
        private static Dictionary<string, Action<BinaryReader, AssetObject>> AssetReaders = new();
        private static Dictionary<string, Action<BinaryWriter, AssetObject>> AssetWriters = new();

        static AssetObjectExt()
        {
            #region Readers
            AssetReaders.Add(UArrowComponent.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UArrowComponent>()));
            AssetReaders.Add(UAssetImportData.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UAssetImportData>()));
            AssetReaders.Add(UBlueprint.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UBlueprint>()));
            AssetReaders.Add(UBlueprintGeneratedClass.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UBlueprintGeneratedClass>()));
            AssetReaders.Add(UCameraComponent.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UCameraComponent>()));
            AssetReaders.Add(UCapsuleComponent.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UCapsuleComponent>()));
            AssetReaders.Add(UCharacterMovementComponent.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UCharacterMovementComponent>()));
            AssetReaders.Add(UEdGraph.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UEdGraph>()));
            AssetReaders.Add(UEdGraphNode_Comment.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UEdGraphNode_Comment>()));
            AssetReaders.Add(UEnhancedInputActionDelegateBinding.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UEnhancedInputActionDelegateBinding>()));
            AssetReaders.Add(UFunction.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UFunction>()));
            AssetReaders.Add(UK2Node_CallFunction.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UK2Node_CallFunction>()));
            AssetReaders.Add(UK2Node_DynamicCast.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UK2Node_DynamicCast>()));
            AssetReaders.Add(UK2Node_EnhancedInputAction.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UK2Node_EnhancedInputAction>()));
            AssetReaders.Add(UK2Node_Event.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UK2Node_Event>()));
            AssetReaders.Add(UK2Node_FunctionEntry.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UK2Node_FunctionEntry>()));
            AssetReaders.Add(UK2Node_GetSubsystemFromPC.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UK2Node_GetSubsystemFromPC>()));
            AssetReaders.Add(UK2Node_Knot.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UK2Node_Knot>()));
            AssetReaders.Add(UK2Node_MacroInstance.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UK2Node_MacroInstance>()));
            AssetReaders.Add(UMetaData.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UMetaData>()));
            AssetReaders.Add(USCS_Node.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<USCS_Node>()));
            AssetReaders.Add(USceneComponent.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<USceneComponent>()));
            AssetReaders.Add(USceneThumbnailInfo.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<USceneThumbnailInfo>()));
            AssetReaders.Add(USimpleConstructionScript.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<USimpleConstructionScript>()));
            AssetReaders.Add(USkeletalMeshComponent.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<USkeletalMeshComponent>()));
            AssetReaders.Add(USpringArmComponent.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<USpringArmComponent>()));
            AssetReaders.Add(UUserDefinedStruct.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UUserDefinedStruct>()));
            AssetReaders.Add(UUserDefinedStructEditorData.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UUserDefinedStructEditorData>()));
            AssetReaders.Add(UMaterialInstanceConstant.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UMaterialInstanceConstant>()));
            AssetReaders.Add(UMaterialInstanceEditorOnlyData.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UMaterialInstanceEditorOnlyData>()));
            AssetReaders.Add(USceneThumbnailInfoWithPrimitive.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<USceneThumbnailInfoWithPrimitive>()));
            #endregion

            #region Writers
            AssetWriters.Add(UArrowComponent.TypeName, (myWriter, myAsset) => myWriter.Write((UArrowComponent)myAsset.Obj));
            AssetWriters.Add(UAssetImportData.TypeName, (myWriter, myAsset) => myWriter.Write((UAssetImportData)myAsset.Obj));
            AssetWriters.Add(UBlueprint.TypeName, (myWriter, myAsset) => myWriter.Write((UBlueprint)myAsset.Obj));
            AssetWriters.Add(UBlueprintGeneratedClass.TypeName, (myWriter, myAsset) => myWriter.Write((UBlueprintGeneratedClass)myAsset.Obj));
            AssetWriters.Add(UCameraComponent.TypeName, (myWriter, myAsset) => myWriter.Write((UCameraComponent)myAsset.Obj));
            AssetWriters.Add(UCapsuleComponent.TypeName, (myWriter, myAsset) => myWriter.Write((UCapsuleComponent)myAsset.Obj));
            AssetWriters.Add(UCharacterMovementComponent.TypeName, (myWriter, myAsset) => myWriter.Write((UCharacterMovementComponent)myAsset.Obj));
            AssetWriters.Add(UEdGraph.TypeName, (myWriter, myAsset) => myWriter.Write((UEdGraph)myAsset.Obj));
            AssetWriters.Add(UEdGraphNode_Comment.TypeName, (myWriter, myAsset) => myWriter.Write((UEdGraphNode_Comment)myAsset.Obj));
            AssetWriters.Add(UEnhancedInputActionDelegateBinding.TypeName, (myWriter, myAsset) => myWriter.Write((UEnhancedInputActionDelegateBinding)myAsset.Obj));
            AssetWriters.Add(UFunction.TypeName, (myWriter, myAsset) => myWriter.Write((UFunction)myAsset.Obj));
            AssetWriters.Add(UK2Node_CallFunction.TypeName, (myWriter, myAsset) => myWriter.Write((UK2Node_CallFunction)myAsset.Obj));
            AssetWriters.Add(UK2Node_DynamicCast.TypeName, (myWriter, myAsset) => myWriter.Write((UK2Node_DynamicCast)myAsset.Obj));
            AssetWriters.Add(UK2Node_EnhancedInputAction.TypeName, (myWriter, myAsset) => myWriter.Write((UK2Node_EnhancedInputAction)myAsset.Obj));
            AssetWriters.Add(UK2Node_Event.TypeName, (myWriter, myAsset) => myWriter.Write((UK2Node_Event)myAsset.Obj));
            AssetWriters.Add(UK2Node_FunctionEntry.TypeName, (myWriter, myAsset) => myWriter.Write((UK2Node_FunctionEntry)myAsset.Obj));
            AssetWriters.Add(UK2Node_GetSubsystemFromPC.TypeName, (myWriter, myAsset) => myWriter.Write((UK2Node_GetSubsystemFromPC)myAsset.Obj));
            AssetWriters.Add(UK2Node_Knot.TypeName, (myWriter, myAsset) => myWriter.Write((UK2Node_Knot)myAsset.Obj));
            AssetWriters.Add(UK2Node_MacroInstance.TypeName, (myWriter, myAsset) => myWriter.Write((UK2Node_MacroInstance)myAsset.Obj));
            AssetWriters.Add(UMetaData.TypeName, (myWriter, myAsset) => myWriter.Write((UMetaData)myAsset.Obj));
            AssetWriters.Add(USCS_Node.TypeName, (myWriter, myAsset) => myWriter.Write((USCS_Node)myAsset.Obj));
            AssetWriters.Add(USceneComponent.TypeName, (myWriter, myAsset) => myWriter.Write((USceneComponent)myAsset.Obj));
            AssetWriters.Add(USceneThumbnailInfo.TypeName, (myWriter, myAsset) => myWriter.Write((USceneThumbnailInfo)myAsset.Obj));
            AssetWriters.Add(USimpleConstructionScript.TypeName, (myWriter, myAsset) => myWriter.Write((USimpleConstructionScript)myAsset.Obj));
            AssetWriters.Add(USkeletalMeshComponent.TypeName, (myWriter, myAsset) => myWriter.Write((USkeletalMeshComponent)myAsset.Obj));
            AssetWriters.Add(USpringArmComponent.TypeName, (myWriter, myAsset) => myWriter.Write((USpringArmComponent)myAsset.Obj));
            AssetWriters.Add(UUserDefinedStruct.TypeName, (myWriter, myAsset) => myWriter.Write((UUserDefinedStruct)myAsset.Obj));
            AssetWriters.Add(UUserDefinedStructEditorData.TypeName, (myWriter, myAsset) => myWriter.Write((UUserDefinedStructEditorData)myAsset.Obj));
            AssetWriters.Add(UMaterialInstanceConstant.TypeName, (myWriter, myAsset) => myWriter.Write((UMaterialInstanceConstant)myAsset.Obj));
            AssetWriters.Add(UMaterialInstanceEditorOnlyData.TypeName, (myWriter, myAsset) => myWriter.Write((UMaterialInstanceEditorOnlyData)myAsset.Obj));
            AssetWriters.Add(USceneThumbnailInfoWithPrimitive.TypeName, (myWriter, myAsset) => myWriter.Write((USceneThumbnailInfoWithPrimitive)myAsset.Obj));
            #endregion
        }

        [Location("void FLinkerLoad::LoadAllObjects(bool bForcePreload)")]
        public static void ReadAssetObject(this BinaryReader reader, string type, AssetObject item)
        {
            if (AssetReaders.TryGetValue(type, out var func))
            {
                func(reader, item);
            }
            else
            {
                Log.Info($"Reading {type} as UObject");
                reader.Read(item.Get<UObject>());
            }
        }
        public static void WriteAssetObject(this BinaryWriter writer, string type, AssetObject item)
        {
            if (AssetWriters.TryGetValue(type, out var func))
            {
                func(writer, item);
            }
            else
            {
                Log.Info($"Writing {type} as UObject");
                writer.Write(item.Obj);
            }
        }
    }
}
