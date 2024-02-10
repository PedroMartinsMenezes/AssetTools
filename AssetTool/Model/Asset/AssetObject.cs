using System.Text.Json.Serialization;

namespace AssetTool
{
    public class AssetObject
    {
        public long Offset;

        [JsonIgnore] public long NextOffset => Offset + Size;

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
        [Location("void FLinkerLoad::LoadAllObjects(bool bForcePreload)")]
        public static void ReadAssetObject(this BinaryReader reader, string type, AssetObject item)
        {
            if (type == UMetaData.TypeName) reader.Read(item.Get<UMetaData>());
            else if (type == UUserDefinedStruct.TypeName) reader.Read(item.Get<UUserDefinedStruct>());
            else if (type == UUserDefinedStructEditorData.TypeName) reader.Read(item.Get<UUserDefinedStructEditorData>());
            else if (type == UArrowComponent.TypeName) reader.Read(item.Get<UArrowComponent>());
            else if (type == UBlueprint.TypeName) reader.Read(item.Get<UBlueprint>());
            else if (type == UBlueprintGeneratedClass.TypeName) reader.Read(item.Get<UBlueprintGeneratedClass>());
            else if (type == UCameraComponent.TypeName) reader.Read(item.Get<UCameraComponent>());
            else if (type == UCapsuleComponent.TypeName) reader.Read(item.Get<UCapsuleComponent>());
            else if (type == UCharacterMovementComponent.TypeName) reader.Read(item.Get<UCharacterMovementComponent>());
            else if (type == UEdGraph.TypeName) reader.Read(item.Get<UEdGraph>());
            else if (type == UEdGraphNode_Comment.TypeName) reader.Read(item.Get<UEdGraphNode_Comment>());
            else if (type == UEnhancedInputActionDelegateBinding.TypeName) reader.Read(item.Get<UEnhancedInputActionDelegateBinding>());
            else if (type == UFunction.TypeName) reader.Read(item.Get<UFunction>());
            else if (type == UK2Node_CallFunction.TypeName) reader.Read(item.Get<UK2Node_CallFunction>());
            else reader.Read(item.Get<UObject>());
        }
        public static void WriteAssetObject(this BinaryWriter writer, string type, AssetObject item)
        {
            if (type == UMetaData.TypeName) writer.Write((UMetaData)item.Obj);
            else if (type == UUserDefinedStruct.TypeName) writer.Write((UUserDefinedStruct)item.Obj);
            else if (type == UUserDefinedStructEditorData.TypeName) writer.Write((UUserDefinedStructEditorData)item.Obj);
            else if (type == UArrowComponent.TypeName) writer.Write((UArrowComponent)item.Obj);
            else if (type == UBlueprint.TypeName) writer.Write((UBlueprint)item.Obj);
            else if (type == UBlueprintGeneratedClass.TypeName) writer.Write(item.Get<UBlueprintGeneratedClass>());
            else if (type == UCameraComponent.TypeName) writer.Write(item.Get<UCameraComponent>());
            else if (type == UCapsuleComponent.TypeName) writer.Write(item.Get<UCapsuleComponent>());
            else if (type == UCharacterMovementComponent.TypeName) writer.Write(item.Get<UCharacterMovementComponent>());
            else if (type == UEdGraph.TypeName) writer.Write(item.Get<UEdGraph>());
            else if (type == UEdGraphNode_Comment.TypeName) writer.Write(item.Get<UEdGraphNode_Comment>());
            else if (type == UEnhancedInputActionDelegateBinding.TypeName) writer.Write(item.Get<UEnhancedInputActionDelegateBinding>());
            else if (type == UFunction.TypeName) writer.Write(item.Get<UFunction>());
            else if (type == UK2Node_CallFunction.TypeName) writer.Write(item.Get<UK2Node_CallFunction>());
        }
    }
}
