namespace AssetTool
{
    [JsonAsset("MaterialEditorOnlyData")]
    public class UMaterialEditorOnlyData : UMaterialInterfaceEditorOnlyData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("Material")]
    public class UMaterial : UMaterialInterface
    {
        public List<FName> Names;
        public Int32 NumLoadedResources;
        public FBool bLocalSavedCachedExpressionData_DEPRECATED;
        public UScriptStruct Struct2;
        public FBool bForceNaniteUsage;

        [Location("void UMaterial::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.VER_UE4_PURGED_FMATERIAL_COMPILE_OUTPUTS)
            {
                SerializeInlineShaderMaps(transfer);
            }
            return this;
        }

        private void SerializeInlineShaderMaps(Transfer transfer)
        {
            transfer.Move(ref NumLoadedResources);
            if (NumLoadedResources > 0)
            {
                throw new NotImplementedException();
            }
            if (transfer.Supports.MaterialSavedCachedData && !transfer.Supports.MaterialInterfaceSavedCachedData)
            {
                transfer.Move(ref bLocalSavedCachedExpressionData_DEPRECATED);
            }
            if (bLocalSavedCachedExpressionData_DEPRECATED)
            {
                Struct2 ??= new();
                Struct2.SerializeTaggedProperties(transfer);
            }
            if (transfer.Supports.NaniteForceMaterialUsage)
            {
                transfer.Move(ref bForceNaniteUsage);
            }
        }
    }
}