using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace AssetTool.Service
{
    public class PolymorphicTypeResolver : DefaultJsonTypeInfoResolver
    {
        public override JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options)
        {
            JsonTypeInfo jsonTypeInfo = base.GetTypeInfo(type, options);
            if (jsonTypeInfo.Type == typeof(UObject))
            {
                jsonTypeInfo.PolymorphismOptions = new JsonPolymorphismOptions
                {
                    TypeDiscriminatorPropertyName = "__type",
                    DerivedTypes =
                    {
                        new JsonDerivedType(typeof(UActorComponent), "UActorComponent"),
                        new JsonDerivedType(typeof(UArrowComponent), "UArrowComponent"),
                        new JsonDerivedType(typeof(UBlueprint), "UBlueprint"),
                        new JsonDerivedType(typeof(UBlueprintCore), "UBlueprintCore"),
                        new JsonDerivedType(typeof(UBlueprintGeneratedClass), "UBlueprintGeneratedClass"),
                        new JsonDerivedType(typeof(UCameraComponent), "UCameraComponent"),
                        new JsonDerivedType(typeof(UCapsuleComponent), "UCapsuleComponent"),
                        new JsonDerivedType(typeof(UCharacterMovementComponent), "UCharacterMovementComponent"),
                        new JsonDerivedType(typeof(UClass), "UClass"),
                        new JsonDerivedType(typeof(UEdGraph), "UEdGraph"),
                        new JsonDerivedType(typeof(UEdGraphNode), "UEdGraphNode"),
                        new JsonDerivedType(typeof(UEdGraphNode_Comment), "UEdGraphNode_Comment"),
                        new JsonDerivedType(typeof(UEnhancedInputActionDelegateBinding), "UEnhancedInputActionDelegateBinding"),
                        new JsonDerivedType(typeof(UFunction), "UFunction"),
                        new JsonDerivedType(typeof(UK2Node), "UK2Node"),
                        new JsonDerivedType(typeof(UK2Node_CallFunction), "UK2Node_CallFunction"),
                        new JsonDerivedType(typeof(UK2Node_DynamicCast), "UK2Node_DynamicCast"),
                        new JsonDerivedType(typeof(UK2Node_EditablePinBase), "UK2Node_EditablePinBase"),
                        new JsonDerivedType(typeof(UK2Node_EnhancedInputAction), "UK2Node_EnhancedInputAction"),
                        new JsonDerivedType(typeof(UK2Node_Event), "UK2Node_Event"),
                        new JsonDerivedType(typeof(UK2Node_FunctionEntry), "UK2Node_FunctionEntry"),
                        new JsonDerivedType(typeof(UK2Node_FunctionTerminator), "UK2Node_FunctionTerminator"),
                        new JsonDerivedType(typeof(UMetaData), "UMetaData"),
                        new JsonDerivedType(typeof(UPrimitiveComponent), "UPrimitiveComponent"),
                        new JsonDerivedType(typeof(USceneComponent), "USceneComponent"),
                        new JsonDerivedType(typeof(UStruct), "UStruct"),
                        new JsonDerivedType(typeof(UUserDefinedStruct), "UUserDefinedStruct"),
                        new JsonDerivedType(typeof(UUserDefinedStructEditorData), "UUserDefinedStructEditorData"),
                        new JsonDerivedType(typeof(UK2Node_MacroInstance), "UK2Node_MacroInstance"),
                        new JsonDerivedType(typeof(USceneThumbnailInfo), "USceneThumbnailInfo"),
                        new JsonDerivedType(typeof(USCS_Node), "USCS_Node"),
                        new JsonDerivedType(typeof(USkeletalMeshComponent), "USkeletalMeshComponent"),
                        new JsonDerivedType(typeof(UK2Node_GetSubsystemFromPC), "UK2Node_GetSubsystemFromPC"),
                        new JsonDerivedType(typeof(UK2Node_Knot), "UK2Node_Knot"),
                        new JsonDerivedType(typeof(USimpleConstructionScript), "USimpleConstructionScript"),
                        new JsonDerivedType(typeof(USpringArmComponent), "USpringArmComponent"),
                        new JsonDerivedType(typeof(UAssetImportData), "UAssetImportData"),
                        new JsonDerivedType(typeof(UMaterialInterface), "UMaterialInterface"),
                        new JsonDerivedType(typeof(UMaterialInstance), "UMaterialInstance"),
                        new JsonDerivedType(typeof(UMaterialInstanceConstant), "UMaterialInstanceConstant"),
                        new JsonDerivedType(typeof(UMaterialInstanceEditorOnlyData), "UMaterialInstanceEditorOnlyData"),
                        new JsonDerivedType(typeof(USceneThumbnailInfoWithPrimitive), "USceneThumbnailInfoWithPrimitive"),
                        new JsonDerivedType(typeof(UMaterial), "UMaterial"),
                        new JsonDerivedType(typeof(UMaterialEditorOnlyData), "UMaterialEditorOnlyData"),
                        new JsonDerivedType(typeof(UMaterialExpressionLinearInterpolate), "UMaterialExpressionLinearInterpolate"),
                        new JsonDerivedType(typeof(UObjectProperty), "UObjectProperty"),
                        new JsonDerivedType(typeof(UAudioComponent), "UAudioComponent"),
                        new JsonDerivedType(typeof(UEdGraphPin), "UEdGraphPin"),
                        new JsonDerivedType(typeof(UByteProperty), "UByteProperty"),
                        new JsonDerivedType(typeof(UDoubleProperty), "UDoubleProperty"),
                        new JsonDerivedType(typeof(UFloatProperty), "UFloatProperty"),
                        new JsonDerivedType(typeof(UInt16Property), "UInt16Property"),
                        new JsonDerivedType(typeof(UInt64Property), "UInt64Property"),
                        new JsonDerivedType(typeof(UInt8Property), "UInt8Property"),
                        new JsonDerivedType(typeof(UIntProperty), "UIntProperty"),
                        new JsonDerivedType(typeof(UStructProperty), "UStructProperty"),
                        new JsonDerivedType(typeof(UUInt16Property), "UUInt16Property"),
                        new JsonDerivedType(typeof(UUInt32Property), "UUInt32Property"),
                        new JsonDerivedType(typeof(UUInt64Property), "UUInt64Property"),
                        new JsonDerivedType(typeof(UPointLightComponent), "UPointLightComponent"),
                        new JsonDerivedType(typeof(UStaticMeshComponent), "UStaticMeshComponent"),
                        new JsonDerivedType(typeof(USpotLightComponent), "USpotLightComponent"),
                        new JsonDerivedType(typeof(UBodySetup), "UBodySetup"),
                        new JsonDerivedType(typeof(UFbxStaticMeshImportData), "UFbxStaticMeshImportData"),
                        new JsonDerivedType(typeof(UNavCollision), "UNavCollision"),
                        new JsonDerivedType(typeof(UStaticMesh), "UStaticMesh"),
                        new JsonDerivedType(typeof(UStaticMeshDescriptionBulkData), "UStaticMeshDescriptionBulkData"),
                        new JsonDerivedType(typeof(UAtmosphericFogComponent), "UAtmosphericFogComponent"),
                        new JsonDerivedType(typeof(UK2Node_AddComponent), "UK2Node_AddComponent"),
                        new JsonDerivedType(typeof(UK2Node_CallMaterialParameterCollectionFunction), "UK2Node_CallMaterialParameterCollectionFunction"),
                        new JsonDerivedType(typeof(UK2Node_CommutativeAssociativeBinaryOperator), "UK2Node_CommutativeAssociativeBinaryOperator"),
                        new JsonDerivedType(typeof(UK2Node_ExecutionSequence), "UK2Node_ExecutionSequence"),
                        new JsonDerivedType(typeof(UK2Node_FunctionResult), "UK2Node_FunctionResult"),
                        new JsonDerivedType(typeof(UK2Node_IfThenElse), "UK2Node_IfThenElse"),
                        new JsonDerivedType(typeof(UK2Node_Select), "UK2Node_Select"),
                        new JsonDerivedType(typeof(UK2Node_VariableGet), "UK2Node_VariableGet"),
                        new JsonDerivedType(typeof(UK2Node_VariableSet), "UK2Node_VariableSet"),
                        new JsonDerivedType(typeof(UAnimBlueprintGeneratedClass), "UAnimBlueprintGeneratedClass"),
                        new JsonDerivedType(typeof(UAnimBlueprintExtension_PropertyAccess), "UAnimBlueprintExtension_PropertyAccess"),
                        new JsonDerivedType(typeof(UAnimGraphNode_ApplyAdditive), "UAnimGraphNode_ApplyAdditive"),
                        new JsonDerivedType(typeof(UAnimGraphNode_BlendSpacePlayer), "UAnimGraphNode_BlendSpacePlayer"),
                        new JsonDerivedType(typeof(UBlendSpace1D), "UBlendSpace1D"),
                        new JsonDerivedType(typeof(UAnimDataModel), "UAnimDataModel"),
                        new JsonDerivedType(typeof(UAnimSequence), "UAnimSequence"),
                        new JsonDerivedType(typeof(UFbxAnimSequenceImportData), "UFbxAnimSequenceImportData"),
                        new JsonDerivedType(typeof(K2Node_CallParentFunction), "K2Node_CallParentFunction"),
                        new JsonDerivedType(typeof(UScriptStruct), "UScriptStruct"),
                        new JsonDerivedType(typeof(UAnimGraphNode_ControlRig), "UAnimGraphNode_ControlRig"),
                    }
                };
            }
            return jsonTypeInfo;
        }
    }
}
