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

        static AssetObjectExt()
        {
            AssetReaders.Add(UMetaData.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UMetaData>()));
            AssetReaders.Add(UUserDefinedStruct.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UUserDefinedStruct>()));
            AssetReaders.Add(UUserDefinedStructEditorData.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UUserDefinedStructEditorData>()));
            AssetReaders.Add(UArrowComponent.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UArrowComponent>()));
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
            AssetReaders.Add(USpringArmComponent.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<USpringArmComponent>()));
            AssetReaders.Add(UK2Node_EnhancedInputAction.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UK2Node_EnhancedInputAction>()));
            AssetReaders.Add(UK2Node_Event.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UK2Node_Event>()));
            AssetReaders.Add(UK2Node_FunctionEntry.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UK2Node_FunctionEntry>()));
            AssetReaders.Add(UK2Node_GetSubsystemFromPC.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UK2Node_GetSubsystemFromPC>()));
            AssetReaders.Add(UK2Node_Knot.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UK2Node_Knot>()));
            AssetReaders.Add(UK2Node_MacroInstance.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UK2Node_MacroInstance>()));
            AssetReaders.Add(USceneComponent.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<USceneComponent>()));
            AssetReaders.Add(USceneThumbnailInfo.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<USceneThumbnailInfo>()));
            AssetReaders.Add(USCS_Node.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<USCS_Node>()));
            AssetReaders.Add(USimpleConstructionScript.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<USimpleConstructionScript>()));
            AssetReaders.Add(USkeletalMeshComponent.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<USkeletalMeshComponent>()));
            AssetReaders.Add(UAssetImportData.TypeName, (myReader, myAsset) => myReader.Read(myAsset.Get<UAssetImportData>()));
        }

        [Location("void FLinkerLoad::LoadAllObjects(bool bForcePreload)")]
        public static void ReadAssetObject(this BinaryReader reader, string type, AssetObject item)
        {
            if (AssetReaders.TryGetValue(type, out var readFunction))
            {
                readFunction(reader, item);
            }
            else if (type == Consts.CurveFloat) reader.Read(item.Get<UObject>());
            else if (type == "CurveLinearColor") reader.Read(item.Get<UObject>());
            else if (type.StartsWith("Default__")) reader.Read(item.Get<UObject>());
            else
            {
                throw new InvalidOperationException($"Invalid object {type}");
            }
        }
        public static void WriteAssetObject(this BinaryWriter writer, string type, AssetObject item)
        {
            if (item.Obj is UMetaData obj1) writer.Write(obj1);
            else if (item.Obj is UUserDefinedStruct obj2) writer.Write(obj2);
            else if (item.Obj is UUserDefinedStructEditorData obj3) writer.Write(obj3);
            else if (item.Obj is UArrowComponent obj4) writer.Write(obj4);
            else if (item.Obj is UBlueprint obj5) writer.Write(obj5);
            else if (item.Obj is UBlueprintGeneratedClass obj6) writer.Write(obj6);
            else if (item.Obj is UCameraComponent obj7) writer.Write(obj7);
            else if (item.Obj is UCapsuleComponent obj8) writer.Write(obj8);
            else if (item.Obj is UCharacterMovementComponent obj9) writer.Write(obj9);
            else if (item.Obj is UEdGraph obj10) writer.Write(obj10);
            else if (item.Obj is UEdGraphNode_Comment obj11) writer.Write(obj11);
            else if (item.Obj is UEnhancedInputActionDelegateBinding obj12) writer.Write(obj12);
            else if (item.Obj is UFunction obj13) writer.Write(obj13);
            else if (item.Obj is UK2Node_CallFunction obj14) writer.Write(obj14);
            else if (item.Obj is UK2Node_DynamicCast obj15) writer.Write(obj15);
            else if (item.Obj is USpringArmComponent obj16) writer.Write(obj16);
            else if (item.Obj is UK2Node_EnhancedInputAction obj17) writer.Write(obj17);
            else if (item.Obj is UK2Node_Event obj18) writer.Write(obj18);
            else if (item.Obj is UK2Node_FunctionEntry obj19) writer.Write(obj19);
            else if (item.Obj is UK2Node_GetSubsystemFromPC obj20) writer.Write(obj20);
            else if (item.Obj is UK2Node_Knot obj21) writer.Write(obj21);
            else if (item.Obj is UK2Node_MacroInstance obj22) writer.Write(obj22);
            else if (item.Obj is USceneComponent obj23) writer.Write(obj23);
            else if (item.Obj is USceneThumbnailInfo obj24) writer.Write(obj24);
            else if (item.Obj is USCS_Node obj25) writer.Write(obj25);
            else if (item.Obj is USimpleConstructionScript obj26) writer.Write(obj26);
            else if (item.Obj is USkeletalMeshComponent obj27) writer.Write(obj27);
            else if (item.Obj is UAssetImportData obj28) writer.Write(obj28);

            else if (type == Consts.CurveFloat) writer.Write(item.Obj);
            else if (type == "CurveLinearColor") writer.Write(item.Obj);
            else if (item.Obj is UObject obj29) writer.Write(obj29);
            else if (type.StartsWith("Default__")) writer.Write(item.Obj);
            else
            {
                throw new InvalidOperationException($"Invalid object {type}");
            }
        }
    }
}
