namespace AssetTool
{
    public static class GlobalObjects
    {
        public static Transfer Transfer { get; set; }

        public static AssetObject CurrentObject { get; set; }

        public static FPackageFileSummary PackageFileSummary { get; set; }

        public static List<FSoftObjectPath> SoftObjectPathList { get; set; } = [];

        public static List<FObjectExport> ExportMap { get; set; } = [];

        public static Dictionary<string, Action<Transfer, AssetObject>> AssetMovers { get; } = new();

        public static int CustomVer(Guid guid)
        {
            return PackageFileSummary.CustomVersionContainer.Versions.Find(x => x.Key.Value == guid) is FCustomVersion x ? x.Version : -1;
        }

        public static string ExportDiaplayValue(uint i)
        {
            return i < ExportMap.Count ? ExportMap[(int)i].ObjectName.DisplayValue : null;
        }

        public static bool UESupport(EUnrealEngineObjectUE4Version value)
        {
            return PackageFileSummary.FileVersionUE.FileVersionUE4 >= (int)value;
        }

        public static bool UESupport(EUnrealEngineObjectUE5Version value)
        {
            return PackageFileSummary.FileVersionUE.FileVersionUE5 >= (int)value;
        }

        static GlobalObjects()
        {
            AssetMovers.Add(UArrowComponent.TypeName, (transfer, myAsset) => myAsset.Get<UArrowComponent>().Move(transfer));
            AssetMovers.Add(UAssetImportData.TypeName, (transfer, myAsset) => myAsset.Get<UAssetImportData>().Move(transfer));
            AssetMovers.Add(UBlueprint.TypeName, (transfer, myAsset) => myAsset.Get<UBlueprint>().Move(transfer));
            AssetMovers.Add(UBlueprintGeneratedClass.TypeName, (transfer, myAsset) => myAsset.Get<UBlueprintGeneratedClass>().Move(transfer));
            AssetMovers.Add(UCameraComponent.TypeName, (transfer, myAsset) => myAsset.Get<UCameraComponent>().Move(transfer));
            AssetMovers.Add(UCapsuleComponent.TypeName, (transfer, myAsset) => myAsset.Get<UCapsuleComponent>().Move(transfer));
            AssetMovers.Add(UCharacterMovementComponent.TypeName, (transfer, myAsset) => myAsset.Get<UCharacterMovementComponent>().Move(transfer));
            AssetMovers.Add(UEdGraph.TypeName, (transfer, myAsset) => myAsset.Get<UEdGraph>().Move(transfer));
            AssetMovers.Add(UEdGraphNode_Comment.TypeName, (transfer, myAsset) => myAsset.Get<UEdGraphNode_Comment>().Move(transfer));
            AssetMovers.Add(UEnhancedInputActionDelegateBinding.TypeName, (transfer, myAsset) => myAsset.Get<UEnhancedInputActionDelegateBinding>().Move(transfer));
            AssetMovers.Add(UFunction.TypeName, (transfer, myAsset) => myAsset.Get<UFunction>().Move(transfer));
            AssetMovers.Add(UK2Node_CallFunction.TypeName, (transfer, myAsset) => myAsset.Get<UK2Node_CallFunction>().Move(transfer));
            AssetMovers.Add(UK2Node_DynamicCast.TypeName, (transfer, myAsset) => myAsset.Get<UK2Node_DynamicCast>().Move(transfer));
            AssetMovers.Add(UK2Node_EnhancedInputAction.TypeName, (transfer, myAsset) => myAsset.Get<UK2Node_EnhancedInputAction>().Move(transfer));
            AssetMovers.Add(UK2Node_Event.TypeName, (transfer, myAsset) => myAsset.Get<UK2Node_Event>().Move(transfer));
            AssetMovers.Add(UK2Node_FunctionEntry.TypeName, (transfer, myAsset) => myAsset.Get<UK2Node_FunctionEntry>().Move(transfer));
            AssetMovers.Add(UK2Node_GetSubsystemFromPC.TypeName, (transfer, myAsset) => myAsset.Get<UK2Node_GetSubsystemFromPC>().Move(transfer));
            AssetMovers.Add(UK2Node_Knot.TypeName, (transfer, myAsset) => myAsset.Get<UK2Node_Knot>().Move(transfer));
            AssetMovers.Add(UK2Node_MacroInstance.TypeName, (transfer, myAsset) => myAsset.Get<UK2Node_MacroInstance>().Move(transfer));
            AssetMovers.Add(UMetaData.TypeName, (transfer, myAsset) => myAsset.Get<UMetaData>().Move(transfer));
            AssetMovers.Add(USCS_Node.TypeName, (transfer, myAsset) => myAsset.Get<USCS_Node>().Move(transfer));
            AssetMovers.Add(USceneComponent.TypeName, (transfer, myAsset) => myAsset.Get<USceneComponent>().Move(transfer));
            AssetMovers.Add(USceneThumbnailInfo.TypeName, (transfer, myAsset) => myAsset.Get<USceneThumbnailInfo>().Move(transfer));
            AssetMovers.Add(USimpleConstructionScript.TypeName, (transfer, myAsset) => myAsset.Get<USimpleConstructionScript>().Move(transfer));
            AssetMovers.Add(USkeletalMeshComponent.TypeName, (transfer, myAsset) => myAsset.Get<USkeletalMeshComponent>().Move(transfer));
            AssetMovers.Add(USpringArmComponent.TypeName, (transfer, myAsset) => myAsset.Get<USpringArmComponent>().Move(transfer));
            AssetMovers.Add(UUserDefinedStruct.TypeName, (transfer, myAsset) => myAsset.Get<UUserDefinedStruct>().Move(transfer));
            AssetMovers.Add(UUserDefinedStructEditorData.TypeName, (transfer, myAsset) => myAsset.Get<UUserDefinedStructEditorData>().Move(transfer));
            AssetMovers.Add(UMaterialInstanceConstant.TypeName, (transfer, myAsset) => myAsset.Get<UMaterialInstanceConstant>().Move(transfer));
            AssetMovers.Add(UMaterialInstanceEditorOnlyData.TypeName, (transfer, myAsset) => myAsset.Get<UMaterialInstanceEditorOnlyData>().Move(transfer));
            AssetMovers.Add(USceneThumbnailInfoWithPrimitive.TypeName, (transfer, myAsset) => myAsset.Get<USceneThumbnailInfoWithPrimitive>().Move(transfer));
            AssetMovers.Add(UMaterial.TypeName, (transfer, myAsset) => myAsset.Get<UMaterial>().Move(transfer));
            AssetMovers.Add(UMaterialEditorOnlyData.TypeName, (transfer, myAsset) => myAsset.Get<UMaterialEditorOnlyData>().Move(transfer));
            AssetMovers.Add(UMaterialExpressionLinearInterpolate.TypeName, (transfer, myAsset) => myAsset.Get<UMaterialExpressionLinearInterpolate>().Move(transfer));
            AssetMovers.Add(UObjectProperty.TypeName, (transfer, myAsset) => myAsset.Get<UObjectProperty>().Move(transfer));
            AssetMovers.Add(UAudioComponent.TypeName, (transfer, myAsset) => myAsset.Get<UAudioComponent>().Move(transfer));
            AssetMovers.Add(UEdGraphPin.TypeName, (transfer, myAsset) => myAsset.Get<UEdGraphPin>().Move(transfer));
            AssetMovers.Add(UByteProperty.TypeName, (transfer, myAsset) => myAsset.Get<UByteProperty>().Move(transfer));
            AssetMovers.Add(UDoubleProperty.TypeName, (transfer, myAsset) => myAsset.Get<UDoubleProperty>().Move(transfer));
            AssetMovers.Add(UFloatProperty.TypeName, (transfer, myAsset) => myAsset.Get<UFloatProperty>().Move(transfer));
            AssetMovers.Add(UInt16Property.TypeName, (transfer, myAsset) => myAsset.Get<UInt16Property>().Move(transfer));
            AssetMovers.Add(UInt64Property.TypeName, (transfer, myAsset) => myAsset.Get<UInt64Property>().Move(transfer));
            AssetMovers.Add(UInt8Property.TypeName, (transfer, myAsset) => myAsset.Get<UInt8Property>().Move(transfer));
            AssetMovers.Add(UIntProperty.TypeName, (transfer, myAsset) => myAsset.Get<UIntProperty>().Move(transfer));
            AssetMovers.Add(UStructProperty.TypeName, (transfer, myAsset) => myAsset.Get<UStructProperty>().Move(transfer));
            AssetMovers.Add(UUInt16Property.TypeName, (transfer, myAsset) => myAsset.Get<UUInt16Property>().Move(transfer));
            AssetMovers.Add(UUInt32Property.TypeName, (transfer, myAsset) => myAsset.Get<UUInt32Property>().Move(transfer));
            AssetMovers.Add(UUInt64Property.TypeName, (transfer, myAsset) => myAsset.Get<UUInt64Property>().Move(transfer));
            AssetMovers.Add(UPointLightComponent.TypeName, (transfer, myAsset) => myAsset.Get<UPointLightComponent>().Move(transfer));
            AssetMovers.Add(UStaticMeshComponent.TypeName, (transfer, myAsset) => myAsset.Get<UStaticMeshComponent>().Move(transfer));
            AssetMovers.Add(USpotLightComponent.TypeName, (transfer, myAsset) => myAsset.Get<USpotLightComponent>().Move(transfer));
            AssetMovers.Add(UBodySetup.TypeName, (transfer, myAsset) => myAsset.Get<UBodySetup>().Move(transfer));
            AssetMovers.Add(UFbxStaticMeshImportData.TypeName, (transfer, myAsset) => myAsset.Get<UFbxStaticMeshImportData>().Move(transfer));
            AssetMovers.Add(UNavCollision.TypeName, (transfer, myAsset) => myAsset.Get<UNavCollision>().Move(transfer));
            AssetMovers.Add(UStaticMesh.TypeName, (transfer, myAsset) => myAsset.Get<UStaticMesh>().Move(transfer));
            AssetMovers.Add(UStaticMeshDescriptionBulkData.TypeName, (transfer, myAsset) => myAsset.Get<UStaticMeshDescriptionBulkData>().Move(transfer));
            AssetMovers.Add(UAtmosphericFogComponent.TypeName, (transfer, myAsset) => myAsset.Get<UAtmosphericFogComponent>().Move(transfer));
            AssetMovers.Add(UK2Node_AddComponent.TypeName, (transfer, myAsset) => myAsset.Get<UK2Node_AddComponent>().Move(transfer));
            AssetMovers.Add(UK2Node_CallMaterialParameterCollectionFunction.TypeName, (transfer, myAsset) => myAsset.Get<UK2Node_CallMaterialParameterCollectionFunction>().Move(transfer));
            AssetMovers.Add(UK2Node_CommutativeAssociativeBinaryOperator.TypeName, (transfer, myAsset) => myAsset.Get<UK2Node_CommutativeAssociativeBinaryOperator>().Move(transfer));
            AssetMovers.Add(UK2Node_ExecutionSequence.TypeName, (transfer, myAsset) => myAsset.Get<UK2Node_ExecutionSequence>().Move(transfer));
            AssetMovers.Add(UK2Node_FunctionResult.TypeName, (transfer, myAsset) => myAsset.Get<UK2Node_FunctionResult>().Move(transfer));
            AssetMovers.Add(UK2Node_IfThenElse.TypeName, (transfer, myAsset) => myAsset.Get<UK2Node_IfThenElse>().Move(transfer));
            AssetMovers.Add(UK2Node_Select.TypeName, (transfer, myAsset) => myAsset.Get<UK2Node_Select>().Move(transfer));
            AssetMovers.Add(UK2Node_VariableGet.TypeName, (transfer, myAsset) => myAsset.Get<UK2Node_VariableGet>().Move(transfer));
            AssetMovers.Add(UK2Node_VariableSet.TypeName, (transfer, myAsset) => myAsset.Get<UK2Node_VariableSet>().Move(transfer));
            AssetMovers.Add(UAnimBlueprintGeneratedClass.TypeName, (transfer, myAsset) => myAsset.Get<UAnimBlueprintGeneratedClass>().Move(transfer));
            AssetMovers.Add(UAnimBlueprintExtension_PropertyAccess.TypeName, (transfer, myAsset) => myAsset.Get<UAnimBlueprintExtension_PropertyAccess>().Move(transfer));
            AssetMovers.Add(UAnimGraphNode_ApplyAdditive.TypeName, (transfer, myAsset) => myAsset.Get<UAnimGraphNode_ApplyAdditive>().Move(transfer));
            AssetMovers.Add(UAnimGraphNode_BlendSpacePlayer.TypeName, (transfer, myAsset) => myAsset.Get<UAnimGraphNode_BlendSpacePlayer>().Move(transfer));
            AssetMovers.Add(UBlendSpace1D.TypeName, (transfer, myAsset) => myAsset.Get<UBlendSpace1D>().Move(transfer));
        }
    }
}
