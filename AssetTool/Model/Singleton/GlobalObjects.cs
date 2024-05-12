namespace AssetTool
{
    public static class GlobalObjects
    {
        public static Transfer Transfer { get; set; }

        public static AssetObject CurrentObject { get; set; }

        public static FPackageFileSummary PackageFileSummary { get; set; }

        public static List<FSoftObjectPath> SoftObjectPathList { get; set; } = [];

        public static List<FObjectExport> ExportMap { get; set; } = [];

        public static Dictionary<string, Action<BinaryReader, AssetObject>> AssetReaders { get; } = new();

        public static Dictionary<string, Action<BinaryWriter, AssetObject>> AssetWriters { get; } = new();

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
            #region Readers
            AssetReaders.Add(UArrowComponent.TypeName, (myReader, myAsset) => myAsset.Get<UArrowComponent>().Move(Transfer));
            AssetReaders.Add(UAssetImportData.TypeName, (myReader, myAsset) => myAsset.Get<UAssetImportData>().Move(Transfer));
            AssetReaders.Add(UBlueprint.TypeName, (myReader, myAsset) => myAsset.Get<UBlueprint>().Move(Transfer));
            AssetReaders.Add(UBlueprintGeneratedClass.TypeName, (myReader, myAsset) => myAsset.Get<UBlueprintGeneratedClass>().Move(Transfer));
            AssetReaders.Add(UCameraComponent.TypeName, (myReader, myAsset) => myAsset.Get<UCameraComponent>().Move(Transfer));
            AssetReaders.Add(UCapsuleComponent.TypeName, (myReader, myAsset) => myAsset.Get<UCapsuleComponent>().Move(Transfer));
            AssetReaders.Add(UCharacterMovementComponent.TypeName, (myReader, myAsset) => myAsset.Get<UCharacterMovementComponent>().Move(Transfer));
            AssetReaders.Add(UEdGraph.TypeName, (myReader, myAsset) => myAsset.Get<UEdGraph>().Move(Transfer));
            AssetReaders.Add(UEdGraphNode_Comment.TypeName, (myReader, myAsset) => myAsset.Get<UEdGraphNode_Comment>().Move(Transfer));
            AssetReaders.Add(UEnhancedInputActionDelegateBinding.TypeName, (myReader, myAsset) => myAsset.Get<UEnhancedInputActionDelegateBinding>().Move(Transfer));
            AssetReaders.Add(UFunction.TypeName, (myReader, myAsset) => myAsset.Get<UFunction>().Move(Transfer));
            AssetReaders.Add(UK2Node_CallFunction.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_CallFunction>().Move(Transfer));
            AssetReaders.Add(UK2Node_DynamicCast.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_DynamicCast>().Move(Transfer));
            AssetReaders.Add(UK2Node_EnhancedInputAction.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_EnhancedInputAction>().Move(Transfer));
            AssetReaders.Add(UK2Node_Event.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_Event>().Move(Transfer));
            AssetReaders.Add(UK2Node_FunctionEntry.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_FunctionEntry>().Move(Transfer));
            AssetReaders.Add(UK2Node_GetSubsystemFromPC.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_GetSubsystemFromPC>().Move(Transfer));
            AssetReaders.Add(UK2Node_Knot.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_Knot>().Move(Transfer));
            AssetReaders.Add(UK2Node_MacroInstance.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_MacroInstance>().Move(Transfer));
            AssetReaders.Add(UMetaData.TypeName, (myReader, myAsset) => myAsset.Get<UMetaData>().Move(Transfer));
            AssetReaders.Add(USCS_Node.TypeName, (myReader, myAsset) => myAsset.Get<USCS_Node>().Move(Transfer));
            AssetReaders.Add(USceneComponent.TypeName, (myReader, myAsset) => myAsset.Get<USceneComponent>().Move(Transfer));
            AssetReaders.Add(USceneThumbnailInfo.TypeName, (myReader, myAsset) => myAsset.Get<USceneThumbnailInfo>().Move(Transfer));
            AssetReaders.Add(USimpleConstructionScript.TypeName, (myReader, myAsset) => myAsset.Get<USimpleConstructionScript>().Move(Transfer));
            AssetReaders.Add(USkeletalMeshComponent.TypeName, (myReader, myAsset) => myAsset.Get<USkeletalMeshComponent>().Move(Transfer));
            AssetReaders.Add(USpringArmComponent.TypeName, (myReader, myAsset) => myAsset.Get<USpringArmComponent>().Move(Transfer));
            AssetReaders.Add(UUserDefinedStruct.TypeName, (myReader, myAsset) => myAsset.Get<UUserDefinedStruct>().Move(Transfer));
            AssetReaders.Add(UUserDefinedStructEditorData.TypeName, (myReader, myAsset) => myAsset.Get<UUserDefinedStructEditorData>().Move(Transfer));
            AssetReaders.Add(UMaterialInstanceConstant.TypeName, (myReader, myAsset) => myAsset.Get<UMaterialInstanceConstant>().Move(Transfer));
            AssetReaders.Add(UMaterialInstanceEditorOnlyData.TypeName, (myReader, myAsset) => myAsset.Get<UMaterialInstanceEditorOnlyData>().Move(Transfer));
            AssetReaders.Add(USceneThumbnailInfoWithPrimitive.TypeName, (myReader, myAsset) => myAsset.Get<USceneThumbnailInfoWithPrimitive>().Move(Transfer));
            AssetReaders.Add(UMaterial.TypeName, (myReader, myAsset) => myAsset.Get<UMaterial>().Move(Transfer));
            AssetReaders.Add(UMaterialEditorOnlyData.TypeName, (myReader, myAsset) => myAsset.Get<UMaterialEditorOnlyData>().Move(Transfer));
            AssetReaders.Add(UMaterialExpressionLinearInterpolate.TypeName, (myReader, myAsset) => myAsset.Get<UMaterialExpressionLinearInterpolate>().Move(Transfer));
            AssetReaders.Add(UObjectProperty.TypeName, (myReader, myAsset) => myAsset.Get<UObjectProperty>().Move(Transfer));
            AssetReaders.Add(UAudioComponent.TypeName, (myReader, myAsset) => myAsset.Get<UAudioComponent>().Move(Transfer));
            AssetReaders.Add(UEdGraphPin.TypeName, (myReader, myAsset) => myAsset.Get<UEdGraphPin>().Move(Transfer));
            AssetReaders.Add(UByteProperty.TypeName, (myReader, myAsset) => myAsset.Get<UByteProperty>().Move(Transfer));
            AssetReaders.Add(UDoubleProperty.TypeName, (myReader, myAsset) => myAsset.Get<UDoubleProperty>().Move(Transfer));
            AssetReaders.Add(UFloatProperty.TypeName, (myReader, myAsset) => myAsset.Get<UFloatProperty>().Move(Transfer));
            AssetReaders.Add(UInt16Property.TypeName, (myReader, myAsset) => myAsset.Get<UInt16Property>().Move(Transfer));
            AssetReaders.Add(UInt64Property.TypeName, (myReader, myAsset) => myAsset.Get<UInt64Property>().Move(Transfer));
            AssetReaders.Add(UInt8Property.TypeName, (myReader, myAsset) => myAsset.Get<UInt8Property>().Move(Transfer));
            AssetReaders.Add(UIntProperty.TypeName, (myReader, myAsset) => myAsset.Get<UIntProperty>().Move(Transfer));
            AssetReaders.Add(UStructProperty.TypeName, (myReader, myAsset) => myAsset.Get<UStructProperty>().Move(Transfer));
            AssetReaders.Add(UUInt16Property.TypeName, (myReader, myAsset) => myAsset.Get<UUInt16Property>().Move(Transfer));
            AssetReaders.Add(UUInt32Property.TypeName, (myReader, myAsset) => myAsset.Get<UUInt32Property>().Move(Transfer));
            AssetReaders.Add(UUInt64Property.TypeName, (myReader, myAsset) => myAsset.Get<UUInt64Property>().Move(Transfer));
            AssetReaders.Add(UPointLightComponent.TypeName, (myReader, myAsset) => myAsset.Get<UPointLightComponent>().Move(Transfer));
            AssetReaders.Add(UStaticMeshComponent.TypeName, (myReader, myAsset) => myAsset.Get<UStaticMeshComponent>().Move(Transfer));
            AssetReaders.Add(USpotLightComponent.TypeName, (myReader, myAsset) => myAsset.Get<USpotLightComponent>().Move(Transfer));
            AssetReaders.Add(UBodySetup.TypeName, (myReader, myAsset) => myAsset.Get<UBodySetup>().Read(myReader));
            AssetReaders.Add(UFbxStaticMeshImportData.TypeName, (myReader, myAsset) => myAsset.Get<UFbxStaticMeshImportData>().Move(Transfer));
            AssetReaders.Add(UNavCollision.TypeName, (myReader, myAsset) => myAsset.Get<UNavCollision>().Read(myReader));
            AssetReaders.Add(UStaticMesh.TypeName, (myReader, myAsset) => myAsset.Get<UStaticMesh>().Move(Transfer));
            AssetReaders.Add(UStaticMeshDescriptionBulkData.TypeName, (myReader, myAsset) => myAsset.Get<UStaticMeshDescriptionBulkData>().Read(myReader));
            AssetReaders.Add(UAtmosphericFogComponent.TypeName, (myReader, myAsset) => myAsset.Get<UAtmosphericFogComponent>().Move(Transfer));
            AssetReaders.Add(UK2Node_AddComponent.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_AddComponent>().Move(Transfer));
            AssetReaders.Add(UK2Node_CallMaterialParameterCollectionFunction.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_CallMaterialParameterCollectionFunction>().Move(Transfer));
            AssetReaders.Add(UK2Node_CommutativeAssociativeBinaryOperator.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_CommutativeAssociativeBinaryOperator>().Move(Transfer));
            AssetReaders.Add(UK2Node_ExecutionSequence.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_ExecutionSequence>().Move(Transfer));
            AssetReaders.Add(UK2Node_FunctionResult.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_FunctionResult>().Move(Transfer));
            AssetReaders.Add(UK2Node_IfThenElse.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_IfThenElse>().Move(Transfer));
            AssetReaders.Add(UK2Node_Select.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_Select>().Move(Transfer));
            AssetReaders.Add(UK2Node_VariableGet.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_VariableGet>().Move(Transfer));
            AssetReaders.Add(UK2Node_VariableSet.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_VariableSet>().Move(Transfer));
            #endregion

            #region Writers
            AssetWriters.Add(UArrowComponent.TypeName, (myWriter, myAsset) => ((UArrowComponent)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UAssetImportData.TypeName, (myWriter, myAsset) => ((UAssetImportData)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UBlueprint.TypeName, (myWriter, myAsset) => ((UBlueprint)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UBlueprintGeneratedClass.TypeName, (myWriter, myAsset) => ((UBlueprintGeneratedClass)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UCameraComponent.TypeName, (myWriter, myAsset) => ((UCameraComponent)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UCapsuleComponent.TypeName, (myWriter, myAsset) => ((UCapsuleComponent)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UCharacterMovementComponent.TypeName, (myWriter, myAsset) => ((UCharacterMovementComponent)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UEdGraph.TypeName, (myWriter, myAsset) => ((UEdGraph)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UEdGraphNode_Comment.TypeName, (myWriter, myAsset) => ((UEdGraphNode_Comment)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UEnhancedInputActionDelegateBinding.TypeName, (myWriter, myAsset) => ((UEnhancedInputActionDelegateBinding)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UFunction.TypeName, (myWriter, myAsset) => ((UFunction)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UK2Node_CallFunction.TypeName, (myWriter, myAsset) => ((UK2Node_CallFunction)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UK2Node_DynamicCast.TypeName, (myWriter, myAsset) => ((UK2Node_DynamicCast)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UK2Node_EnhancedInputAction.TypeName, (myWriter, myAsset) => ((UK2Node_EnhancedInputAction)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UK2Node_Event.TypeName, (myWriter, myAsset) => ((UK2Node_Event)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UK2Node_FunctionEntry.TypeName, (myWriter, myAsset) => ((UK2Node_FunctionEntry)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UK2Node_GetSubsystemFromPC.TypeName, (myWriter, myAsset) => ((UK2Node_GetSubsystemFromPC)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UK2Node_Knot.TypeName, (myWriter, myAsset) => ((UK2Node_Knot)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UK2Node_MacroInstance.TypeName, (myWriter, myAsset) => ((UK2Node_MacroInstance)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UMetaData.TypeName, (myWriter, myAsset) => ((UMetaData)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(USCS_Node.TypeName, (myWriter, myAsset) => ((USCS_Node)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(USceneComponent.TypeName, (myWriter, myAsset) => ((USceneComponent)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(USceneThumbnailInfo.TypeName, (myWriter, myAsset) => ((USceneThumbnailInfo)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(USimpleConstructionScript.TypeName, (myWriter, myAsset) => ((USimpleConstructionScript)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(USkeletalMeshComponent.TypeName, (myWriter, myAsset) => ((USkeletalMeshComponent)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(USpringArmComponent.TypeName, (myWriter, myAsset) => ((USpringArmComponent)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UUserDefinedStruct.TypeName, (myWriter, myAsset) => ((UUserDefinedStruct)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UUserDefinedStructEditorData.TypeName, (myWriter, myAsset) => ((UUserDefinedStructEditorData)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UMaterialInstanceConstant.TypeName, (myWriter, myAsset) => ((UMaterialInstanceConstant)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UMaterialInstanceEditorOnlyData.TypeName, (myWriter, myAsset) => ((UMaterialInstanceEditorOnlyData)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(USceneThumbnailInfoWithPrimitive.TypeName, (myWriter, myAsset) => ((USceneThumbnailInfoWithPrimitive)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UMaterial.TypeName, (myWriter, myAsset) => ((UMaterial)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UMaterialEditorOnlyData.TypeName, (myWriter, myAsset) => ((UMaterialEditorOnlyData)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UMaterialExpressionLinearInterpolate.TypeName, (myWriter, myAsset) => ((UMaterialExpressionLinearInterpolate)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UObjectProperty.TypeName, (myWriter, myAsset) => ((UObjectProperty)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UAudioComponent.TypeName, (myWriter, myAsset) => ((UAudioComponent)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UEdGraphPin.TypeName, (myWriter, myAsset) => ((UEdGraphPin)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UByteProperty.TypeName, (myWriter, myAsset) => ((UByteProperty)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UDoubleProperty.TypeName, (myWriter, myAsset) => ((UDoubleProperty)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UFloatProperty.TypeName, (myWriter, myAsset) => ((UFloatProperty)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UInt16Property.TypeName, (myWriter, myAsset) => ((UInt16Property)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UInt64Property.TypeName, (myWriter, myAsset) => ((UInt64Property)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UInt8Property.TypeName, (myWriter, myAsset) => ((UInt8Property)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UIntProperty.TypeName, (myWriter, myAsset) => ((UIntProperty)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UStructProperty.TypeName, (myWriter, myAsset) => ((UStructProperty)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UUInt16Property.TypeName, (myWriter, myAsset) => ((UUInt16Property)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UUInt32Property.TypeName, (myWriter, myAsset) => ((UUInt32Property)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UUInt64Property.TypeName, (myWriter, myAsset) => ((UUInt64Property)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UPointLightComponent.TypeName, (myWriter, myAsset) => ((UPointLightComponent)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UStaticMeshComponent.TypeName, (myWriter, myAsset) => ((UStaticMeshComponent)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(USpotLightComponent.TypeName, (myWriter, myAsset) => ((USpotLightComponent)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UBodySetup.TypeName, (myWriter, myAsset) => ((UBodySetup)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UFbxStaticMeshImportData.TypeName, (myWriter, myAsset) => ((UFbxStaticMeshImportData)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UNavCollision.TypeName, (myWriter, myAsset) => ((UNavCollision)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UStaticMesh.TypeName, (myWriter, myAsset) => ((UStaticMesh)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UStaticMeshDescriptionBulkData.TypeName, (myWriter, myAsset) => ((UStaticMeshDescriptionBulkData)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UAtmosphericFogComponent.TypeName, (myWriter, myAsset) => ((UAtmosphericFogComponent)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UK2Node_AddComponent.TypeName, (myWriter, myAsset) => ((UK2Node_AddComponent)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UK2Node_CallMaterialParameterCollectionFunction.TypeName, (myWriter, myAsset) => ((UK2Node_CallMaterialParameterCollectionFunction)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UK2Node_CommutativeAssociativeBinaryOperator.TypeName, (myWriter, myAsset) => ((UK2Node_CommutativeAssociativeBinaryOperator)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UK2Node_ExecutionSequence.TypeName, (myWriter, myAsset) => ((UK2Node_ExecutionSequence)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UK2Node_FunctionResult.TypeName, (myWriter, myAsset) => ((UK2Node_FunctionResult)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UK2Node_IfThenElse.TypeName, (myWriter, myAsset) => ((UK2Node_IfThenElse)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UK2Node_Select.TypeName, (myWriter, myAsset) => ((UK2Node_Select)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UK2Node_VariableGet.TypeName, (myWriter, myAsset) => ((UK2Node_VariableGet)myAsset.Obj).Move(Transfer));
            AssetWriters.Add(UK2Node_VariableSet.TypeName, (myWriter, myAsset) => ((UK2Node_VariableSet)myAsset.Obj).Move(Transfer));
            #endregion
        }
    }
}
