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
            else if (type == UK2Node_DynamicCast.TypeName) reader.Read(item.Get<UK2Node_DynamicCast>());
            else if (type == USpringArmComponent.TypeName) reader.Read(item.Get<USpringArmComponent>());
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
            else if (type.StartsWith("Default__")) writer.Write(item.Obj);
            else
            {
                throw new InvalidOperationException($"Invalid object {type}");
            }
        }
    }
}
