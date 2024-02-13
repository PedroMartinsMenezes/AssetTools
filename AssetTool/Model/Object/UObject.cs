using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("void UObject::Serialize(FStructuredArchive::FRecord Record)")]
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "__type")]
    [JsonDerivedType(typeof(UActorComponent), "UActorComponent")]
    [JsonDerivedType(typeof(UArrowComponent), "UArrowComponent")]
    [JsonDerivedType(typeof(UBlueprint), "UBlueprint")]
    [JsonDerivedType(typeof(UBlueprintCore), "UBlueprintCore")]
    [JsonDerivedType(typeof(UBlueprintGeneratedClass), "UBlueprintGeneratedClass")]
    [JsonDerivedType(typeof(UCameraComponent), "UCameraComponent")]
    [JsonDerivedType(typeof(UCapsuleComponent), "UCapsuleComponent")]
    [JsonDerivedType(typeof(UCharacterMovementComponent), "UCharacterMovementComponent")]
    [JsonDerivedType(typeof(UClass), "UClass")]
    [JsonDerivedType(typeof(UEdGraph), "UEdGraph")]
    [JsonDerivedType(typeof(UEdGraphNode), "UEdGraphNode")]
    [JsonDerivedType(typeof(UEdGraphNode_Comment), "UEdGraphNode_Comment")]
    [JsonDerivedType(typeof(UEnhancedInputActionDelegateBinding), "UEnhancedInputActionDelegateBinding")]
    [JsonDerivedType(typeof(UFunction), "UFunction")]
    [JsonDerivedType(typeof(UK2Node), "UK2Node")]
    [JsonDerivedType(typeof(UK2Node_CallFunction), "UK2Node_CallFunction")]
    [JsonDerivedType(typeof(UK2Node_DynamicCast), "UK2Node_DynamicCast")]
    [JsonDerivedType(typeof(UK2Node_EditablePinBase), "UK2Node_EditablePinBase")]
    [JsonDerivedType(typeof(UK2Node_EnhancedInputAction), "UK2Node_EnhancedInputAction")]
    [JsonDerivedType(typeof(UK2Node_Event), "UK2Node_Event")]
    [JsonDerivedType(typeof(UK2Node_FunctionEntry), "UK2Node_FunctionEntry")]
    [JsonDerivedType(typeof(UK2Node_FunctionTerminator), "UK2Node_FunctionTerminator")]
    [JsonDerivedType(typeof(UMetaData), "UMetaData")]
    [JsonDerivedType(typeof(UPrimitiveComponent), "UPrimitiveComponent")]
    [JsonDerivedType(typeof(USceneComponent), "USceneComponent")]
    [JsonDerivedType(typeof(UStruct), "UStruct")]
    [JsonDerivedType(typeof(UUserDefinedStruct), "UUserDefinedStruct")]
    [JsonDerivedType(typeof(UUserDefinedStructEditorData), "UUserDefinedStructEditorData")]
    [JsonDerivedType(typeof(UK2Node_MacroInstance), "UK2Node_MacroInstance")]
    [JsonDerivedType(typeof(USceneThumbnailInfo), "USceneThumbnailInfo")]
    [JsonDerivedType(typeof(USCS_Node), "USCS_Node")]
    [JsonDerivedType(typeof(USkeletalMeshComponent), "USkeletalMeshComponent")]
    [JsonDerivedType(typeof(UK2Node_GetSubsystemFromPC), "UK2Node_GetSubsystemFromPC")]
    [JsonDerivedType(typeof(UK2Node_Knot), "UK2Node_Knot")]
    [JsonDerivedType(typeof(USimpleConstructionScript), "USimpleConstructionScript")]
    [JsonDerivedType(typeof(USpringArmComponent), "USpringArmComponent")]
    public class UObject
    {
        [JsonPropertyOrder(-9)] public List<FPropertyTag> Tags = new();
        [JsonPropertyOrder(-9)] public FBool HasGuid = new();
        [JsonPropertyOrder(-9)] public FGuid Guid;
    }

    public static class UObjectExt
    {
        public static void Write(this BinaryWriter writer, UObject item)
        {
            writer.Write(item.Tags);
            writer.Write(item.HasGuid);
            if (item.HasGuid.Value)
            {
                writer.Write(item.Guid);
            }
        }

        public static UObject Read(this BinaryReader reader, UObject item)
        {
            reader.Read(item.Tags);
            reader.Read(ref item.HasGuid);
            if (item.HasGuid.Value)
            {
                reader.Read(ref item.Guid);
            }
            return item;
        }
    }
}
