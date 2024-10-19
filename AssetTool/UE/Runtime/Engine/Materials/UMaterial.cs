namespace AssetTool
{
    [JsonAsset("Material")]
    public class UMaterial : UMaterialInterface
    {
        public const string TypeName = "Material";

        public List<FName> Names;
        public Int32 NumLoadedResources;
        public FBool bLocalSavedCachedExpressionData_DEPRECATED;
        public new UScriptStruct Struct;
        public FBool bForceNaniteUsage;

        [Location("void UMaterial::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (Supports.VER_UE4_PURGED_FMATERIAL_COMPILE_OUTPUTS)
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
            if (Supports.MaterialSavedCachedData && !Supports.MaterialInterfaceSavedCachedData)
            {
                transfer.Move(ref bLocalSavedCachedExpressionData_DEPRECATED);
            }
            if (bLocalSavedCachedExpressionData_DEPRECATED ?? false)
            {
                Struct ??= new();
                Struct.SerializeTaggedProperties(transfer);
            }
            if (Supports.NaniteForceMaterialUsage)
            {
                transfer.Move(ref bForceNaniteUsage);
            }
        }
    }
}
