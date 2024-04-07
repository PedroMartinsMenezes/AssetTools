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
    [JsonDerivedType(typeof(UAssetImportData), "UAssetImportData")]
    [JsonDerivedType(typeof(UMaterialInterface), "UMaterialInterface")]
    [JsonDerivedType(typeof(UMaterialInstance), "UMaterialInstance")]
    [JsonDerivedType(typeof(UMaterialInstanceConstant), "UMaterialInstanceConstant")]
    [JsonDerivedType(typeof(UMaterialInstanceEditorOnlyData), "UMaterialInstanceEditorOnlyData")]
    [JsonDerivedType(typeof(USceneThumbnailInfoWithPrimitive), "USceneThumbnailInfoWithPrimitive")]
    [JsonDerivedType(typeof(UMaterial), "UMaterial")]
    [JsonDerivedType(typeof(UMaterialEditorOnlyData), "MaterialEditorOnlyData")]
    [JsonDerivedType(typeof(UMaterialExpressionLinearInterpolate), "MaterialExpressionLinearInterpolate")]
    [JsonDerivedType(typeof(UObjectProperty), "UObjectProperty")]
    [JsonDerivedType(typeof(UAudioComponent), "UAudioComponent")]
    [JsonDerivedType(typeof(UEdGraphPin), "UEdGraphPin")]
    [JsonDerivedType(typeof(UByteProperty), "UByteProperty")]
    [JsonDerivedType(typeof(UDoubleProperty), "UDoubleProperty")]
    [JsonDerivedType(typeof(UFloatProperty), "UFloatProperty")]
    [JsonDerivedType(typeof(UInt16Property), "UInt16Property")]
    [JsonDerivedType(typeof(UInt64Property), "UInt64Property")]
    [JsonDerivedType(typeof(UInt8Property), "UInt8Property")]
    [JsonDerivedType(typeof(UIntProperty), "UIntProperty")]
    [JsonDerivedType(typeof(UStructProperty), "UStructProperty")]
    [JsonDerivedType(typeof(UUInt16Property), "UUInt16Property")]
    [JsonDerivedType(typeof(UUInt32Property), "UUInt32Property")]
    [JsonDerivedType(typeof(UUInt64Property), "UUInt64Property")]
    [JsonDerivedType(typeof(UPointLightComponent), "UPointLightComponent")]
    [JsonDerivedType(typeof(UStaticMeshComponent), "UStaticMeshComponent")]
    [JsonDerivedType(typeof(USpotLightComponent), "USpotLightComponent")]
    [JsonDerivedType(typeof(UBodySetup), "UBodySetup")]
    [JsonDerivedType(typeof(UFbxStaticMeshImportData), "UFbxStaticMeshImportData")]
    [JsonDerivedType(typeof(UNavCollision), "UNavCollision")]
    [JsonDerivedType(typeof(UStaticMesh), "UStaticMesh")]
    [JsonDerivedType(typeof(UStaticMeshDescriptionBulkData), "UStaticMeshDescriptionBulkData")]
    [JsonDerivedType(typeof(UAtmosphericFogComponent), "UAtmosphericFogComponent")]
    public class UObject
    {
        [JsonPropertyOrder(-9)] public List<object> Tags = new();
        [JsonPropertyOrder(-9)] public FBool HasGuid = new();
        [JsonPropertyOrder(-9)] public FGuid Guid;
        [JsonPropertyOrder(-9)] public UInt32 SerializedSparseClassDataStruct;

        public UObject Read(BinaryReader reader, int indent = 0)
        {
            reader.ReadTags(Tags, indent);
            reader.Read(ref HasGuid);
            if (HasGuid?.Value == true)
            {
                reader.Read(ref Guid);
            }
            return this;
        }

        public void Write(BinaryWriter writer)
        {
            writer.WriteTags(Tags);
            writer.Write(HasGuid);
            if (HasGuid?.Value == true)
            {
                writer.Write(Guid);
            }
        }

        public UObject ReadDefault(BinaryReader reader)
        {
            reader.ReadTags(Tags);
            if (GlobalObjects.CustomVer(FUE5MainStreamObjectVersion.Guid) >= (int)FUE5MainStreamObjectVersion.Enums.SparseClassDataStructSerialization)
            {
                reader.Read(ref SerializedSparseClassDataStruct);
            }
            return this;
        }

        public void WriteDefault(BinaryWriter writer)
        {
            writer.WriteTags(Tags);
            if (GlobalObjects.CustomVer(FUE5MainStreamObjectVersion.Guid) >= (int)FUE5MainStreamObjectVersion.Enums.SparseClassDataStructSerialization)
            {
                writer.Write(SerializedSparseClassDataStruct);
            }
        }
    }
}
