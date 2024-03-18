namespace AssetTool
{
    public static class GlobalObjects
    {
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
            AssetReaders.Add(UArrowComponent.TypeName, (myReader, myAsset) => myAsset.Get<UArrowComponent>().Read(myReader));
            AssetReaders.Add(UAssetImportData.TypeName, (myReader, myAsset) => myAsset.Get<UAssetImportData>().Read(myReader));
            AssetReaders.Add(UBlueprint.TypeName, (myReader, myAsset) => myAsset.Get<UBlueprint>().Read(myReader));
            AssetReaders.Add(UBlueprintGeneratedClass.TypeName, (myReader, myAsset) => myAsset.Get<UBlueprintGeneratedClass>().Read(myReader));
            AssetReaders.Add(UCameraComponent.TypeName, (myReader, myAsset) => myAsset.Get<UCameraComponent>().Read(myReader));
            AssetReaders.Add(UCapsuleComponent.TypeName, (myReader, myAsset) => myAsset.Get<UCapsuleComponent>().Read(myReader));
            AssetReaders.Add(UCharacterMovementComponent.TypeName, (myReader, myAsset) => myAsset.Get<UCharacterMovementComponent>().Read(myReader));
            AssetReaders.Add(UEdGraph.TypeName, (myReader, myAsset) => myAsset.Get<UEdGraph>().Read(myReader));
            AssetReaders.Add(UEdGraphNode_Comment.TypeName, (myReader, myAsset) => myAsset.Get<UEdGraphNode_Comment>().Read(myReader));
            AssetReaders.Add(UEnhancedInputActionDelegateBinding.TypeName, (myReader, myAsset) => myAsset.Get<UEnhancedInputActionDelegateBinding>().Read(myReader));
            AssetReaders.Add(UFunction.TypeName, (myReader, myAsset) => myAsset.Get<UFunction>().Read(myReader));
            AssetReaders.Add(UK2Node_CallFunction.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_CallFunction>().Read(myReader));
            AssetReaders.Add(UK2Node_DynamicCast.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_DynamicCast>().Read(myReader));
            AssetReaders.Add(UK2Node_EnhancedInputAction.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_EnhancedInputAction>().Read(myReader));
            AssetReaders.Add(UK2Node_Event.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_Event>().Read(myReader));
            AssetReaders.Add(UK2Node_FunctionEntry.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_FunctionEntry>().Read(myReader));
            AssetReaders.Add(UK2Node_GetSubsystemFromPC.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_GetSubsystemFromPC>().Read(myReader));
            AssetReaders.Add(UK2Node_Knot.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_Knot>().Read(myReader));
            AssetReaders.Add(UK2Node_MacroInstance.TypeName, (myReader, myAsset) => myAsset.Get<UK2Node_MacroInstance>().Read(myReader));
            AssetReaders.Add(UMetaData.TypeName, (myReader, myAsset) => myAsset.Get<UMetaData>().Read(myReader));
            AssetReaders.Add(USCS_Node.TypeName, (myReader, myAsset) => myAsset.Get<USCS_Node>().Read(myReader));
            AssetReaders.Add(USceneComponent.TypeName, (myReader, myAsset) => myAsset.Get<USceneComponent>().Read(myReader));
            AssetReaders.Add(USceneThumbnailInfo.TypeName, (myReader, myAsset) => myAsset.Get<USceneThumbnailInfo>().Read(myReader));
            AssetReaders.Add(USimpleConstructionScript.TypeName, (myReader, myAsset) => myAsset.Get<USimpleConstructionScript>().Read(myReader));
            AssetReaders.Add(USkeletalMeshComponent.TypeName, (myReader, myAsset) => myAsset.Get<USkeletalMeshComponent>().Read(myReader));
            AssetReaders.Add(USpringArmComponent.TypeName, (myReader, myAsset) => myAsset.Get<USpringArmComponent>().Read(myReader));
            AssetReaders.Add(UUserDefinedStruct.TypeName, (myReader, myAsset) => myAsset.Get<UUserDefinedStruct>().Read(myReader));
            AssetReaders.Add(UUserDefinedStructEditorData.TypeName, (myReader, myAsset) => myAsset.Get<UUserDefinedStructEditorData>().Read(myReader));
            AssetReaders.Add(UMaterialInstanceConstant.TypeName, (myReader, myAsset) => myAsset.Get<UMaterialInstanceConstant>().Read(myReader));
            AssetReaders.Add(UMaterialInstanceEditorOnlyData.TypeName, (myReader, myAsset) => myAsset.Get<UMaterialInstanceEditorOnlyData>().Read(myReader));
            AssetReaders.Add(USceneThumbnailInfoWithPrimitive.TypeName, (myReader, myAsset) => myAsset.Get<USceneThumbnailInfoWithPrimitive>().Read(myReader));
            AssetReaders.Add(UMaterial.TypeName, (myReader, myAsset) => myAsset.Get<UMaterial>().Read(myReader));
            AssetReaders.Add(UMaterialEditorOnlyData.TypeName, (myReader, myAsset) => myAsset.Get<UMaterialEditorOnlyData>().Read(myReader));
            AssetReaders.Add(UMaterialExpressionLinearInterpolate.TypeName, (myReader, myAsset) => myAsset.Get<UMaterialExpressionLinearInterpolate>().Read(myReader));
            AssetReaders.Add(UObjectProperty.TypeName, (myReader, myAsset) => myAsset.Get<UObjectProperty>().Read(myReader));
            AssetReaders.Add(UAudioComponent.TypeName, (myReader, myAsset) => myAsset.Get<UAudioComponent>().Read(myReader));
            AssetReaders.Add(UEdGraphPin.TypeName, (myReader, myAsset) => myAsset.Get<UEdGraphPin>().Read(myReader));
            AssetReaders.Add(UByteProperty.TypeName, (myReader, myAsset) => myAsset.Get<UByteProperty>().Read(myReader));
            AssetReaders.Add(UDoubleProperty.TypeName, (myReader, myAsset) => myAsset.Get<UDoubleProperty>().Read(myReader));
            AssetReaders.Add(UFloatProperty.TypeName, (myReader, myAsset) => myAsset.Get<UFloatProperty>().Read(myReader));
            AssetReaders.Add(UInt16Property.TypeName, (myReader, myAsset) => myAsset.Get<UInt16Property>().Read(myReader));
            AssetReaders.Add(UInt64Property.TypeName, (myReader, myAsset) => myAsset.Get<UInt64Property>().Read(myReader));
            AssetReaders.Add(UInt8Property.TypeName, (myReader, myAsset) => myAsset.Get<UInt8Property>().Read(myReader));
            AssetReaders.Add(UIntProperty.TypeName, (myReader, myAsset) => myAsset.Get<UIntProperty>().Read(myReader));
            AssetReaders.Add(UStructProperty.TypeName, (myReader, myAsset) => myAsset.Get<UStructProperty>().Read(myReader));
            AssetReaders.Add(UUInt16Property.TypeName, (myReader, myAsset) => myAsset.Get<UUInt16Property>().Read(myReader));
            AssetReaders.Add(UUInt32Property.TypeName, (myReader, myAsset) => myAsset.Get<UUInt32Property>().Read(myReader));
            AssetReaders.Add(UUInt64Property.TypeName, (myReader, myAsset) => myAsset.Get<UUInt64Property>().Read(myReader));
            AssetReaders.Add(UPointLightComponent.TypeName, (myReader, myAsset) => myAsset.Get<UPointLightComponent>().Read(myReader));
            AssetReaders.Add(UStaticMeshComponent.TypeName, (myReader, myAsset) => myAsset.Get<UStaticMeshComponent>().Read(myReader));
            AssetReaders.Add(USpotLightComponent.TypeName, (myReader, myAsset) => myAsset.Get<USpotLightComponent>().Read(myReader));
            #endregion

            #region Writers
            AssetWriters.Add(UArrowComponent.TypeName, (myWriter, myAsset) => ((UArrowComponent)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UAssetImportData.TypeName, (myWriter, myAsset) => ((UAssetImportData)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UBlueprint.TypeName, (myWriter, myAsset) => ((UBlueprint)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UBlueprintGeneratedClass.TypeName, (myWriter, myAsset) => ((UBlueprintGeneratedClass)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UCameraComponent.TypeName, (myWriter, myAsset) => ((UCameraComponent)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UCapsuleComponent.TypeName, (myWriter, myAsset) => ((UCapsuleComponent)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UCharacterMovementComponent.TypeName, (myWriter, myAsset) => ((UCharacterMovementComponent)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UEdGraph.TypeName, (myWriter, myAsset) => ((UEdGraph)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UEdGraphNode_Comment.TypeName, (myWriter, myAsset) => ((UEdGraphNode_Comment)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UEnhancedInputActionDelegateBinding.TypeName, (myWriter, myAsset) => ((UEnhancedInputActionDelegateBinding)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UFunction.TypeName, (myWriter, myAsset) => ((UFunction)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UK2Node_CallFunction.TypeName, (myWriter, myAsset) => ((UK2Node_CallFunction)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UK2Node_DynamicCast.TypeName, (myWriter, myAsset) => ((UK2Node_DynamicCast)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UK2Node_EnhancedInputAction.TypeName, (myWriter, myAsset) => ((UK2Node_EnhancedInputAction)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UK2Node_Event.TypeName, (myWriter, myAsset) => ((UK2Node_Event)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UK2Node_FunctionEntry.TypeName, (myWriter, myAsset) => ((UK2Node_FunctionEntry)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UK2Node_GetSubsystemFromPC.TypeName, (myWriter, myAsset) => ((UK2Node_GetSubsystemFromPC)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UK2Node_Knot.TypeName, (myWriter, myAsset) => ((UK2Node_Knot)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UK2Node_MacroInstance.TypeName, (myWriter, myAsset) => ((UK2Node_MacroInstance)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UMetaData.TypeName, (myWriter, myAsset) => ((UMetaData)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(USCS_Node.TypeName, (myWriter, myAsset) => ((USCS_Node)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(USceneComponent.TypeName, (myWriter, myAsset) => ((USceneComponent)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(USceneThumbnailInfo.TypeName, (myWriter, myAsset) => ((USceneThumbnailInfo)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(USimpleConstructionScript.TypeName, (myWriter, myAsset) => ((USimpleConstructionScript)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(USkeletalMeshComponent.TypeName, (myWriter, myAsset) => ((USkeletalMeshComponent)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(USpringArmComponent.TypeName, (myWriter, myAsset) => ((USpringArmComponent)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UUserDefinedStruct.TypeName, (myWriter, myAsset) => ((UUserDefinedStruct)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UUserDefinedStructEditorData.TypeName, (myWriter, myAsset) => ((UUserDefinedStructEditorData)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UMaterialInstanceConstant.TypeName, (myWriter, myAsset) => ((UMaterialInstanceConstant)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UMaterialInstanceEditorOnlyData.TypeName, (myWriter, myAsset) => ((UMaterialInstanceEditorOnlyData)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(USceneThumbnailInfoWithPrimitive.TypeName, (myWriter, myAsset) => ((USceneThumbnailInfoWithPrimitive)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UMaterial.TypeName, (myWriter, myAsset) => ((UMaterial)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UMaterialEditorOnlyData.TypeName, (myWriter, myAsset) => ((UMaterialEditorOnlyData)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UMaterialExpressionLinearInterpolate.TypeName, (myWriter, myAsset) => ((UMaterialExpressionLinearInterpolate)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UObjectProperty.TypeName, (myWriter, myAsset) => ((UObjectProperty)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UAudioComponent.TypeName, (myWriter, myAsset) => ((UAudioComponent)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UEdGraphPin.TypeName, (myWriter, myAsset) => ((UEdGraphPin)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UByteProperty.TypeName, (myWriter, myAsset) => ((UByteProperty)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UDoubleProperty.TypeName, (myWriter, myAsset) => ((UDoubleProperty)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UFloatProperty.TypeName, (myWriter, myAsset) => ((UFloatProperty)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UInt16Property.TypeName, (myWriter, myAsset) => ((UInt16Property)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UInt64Property.TypeName, (myWriter, myAsset) => ((UInt64Property)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UInt8Property.TypeName, (myWriter, myAsset) => ((UInt8Property)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UIntProperty.TypeName, (myWriter, myAsset) => ((UIntProperty)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UStructProperty.TypeName, (myWriter, myAsset) => ((UStructProperty)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UUInt16Property.TypeName, (myWriter, myAsset) => ((UUInt16Property)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UUInt32Property.TypeName, (myWriter, myAsset) => ((UUInt32Property)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UUInt64Property.TypeName, (myWriter, myAsset) => ((UUInt64Property)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UPointLightComponent.TypeName, (myWriter, myAsset) => ((UPointLightComponent)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(UStaticMeshComponent.TypeName, (myWriter, myAsset) => ((UStaticMeshComponent)myAsset.Obj).Write(myWriter));
            AssetWriters.Add(USpotLightComponent.TypeName, (myWriter, myAsset) => ((USpotLightComponent)myAsset.Obj).Write(myWriter));
            #endregion
        }
    }
}
