namespace AssetTool
{
    [JsonAsset("MaterialInstance")]
    public class UMaterialInstance : UMaterialInterface
    {
        public FBool bSavedCachedData;
        public UScriptStruct Struct2;
        public bool bHasStaticPermutationResource;
        public FStaticParameterSet StaticParameters_DEPRECATED;
        public FBool bOverrideBaseProperties_DEPRECATED;
        public FBool bHasPropertyOverrides;
        public FMaterialInstanceBasePropertyOverrides BasePropertyOverrides;
        public List<FMaterialResource> LoadedResources;
        public FMaterialResource LegacyResource;
        public FMaterialShaderMapId LegacyId;

        [Location("void UMaterialInstance::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);

            if (Members.FirstOrDefault(x => x.Key.Contains("bHasStaticPermutationResource")) is var value && value.Value is { })
            {
                bHasStaticPermutationResource = Convert.ToBoolean(value.Value.ToString());
            }

            if (transfer.Supports.MaterialSavedCachedData)
            {
                transfer.Move(ref bSavedCachedData);
            }
            if (bSavedCachedData)
            {
                Struct2 ??= new();
                Struct2.SerializeTaggedProperties(transfer);
            }
            if (bHasStaticPermutationResource)
            {
                if (transfer.Supports.VER_UE4_PURGED_FMATERIAL_COMPILE_OUTPUTS)
                {
                    if (!transfer.Supports.MaterialAttributeLayerParameters)
                    {
                        transfer.Move(ref StaticParameters_DEPRECATED);
                    }
                    SerializeInlineShaderMaps(transfer);
                }
                else
                {
                    LegacyResource ??= new();
                    LegacyResource.LegacySerialize(transfer);

                    transfer.Move(ref LegacyId);
                }
            }
            if (transfer.Supports.VER_UE4_MATERIAL_INSTANCE_BASE_PROPERTY_OVERRIDES)
            {
                if (!transfer.Supports.VER_UE4_FIX_MATERIAL_PROPERTY_OVERRIDE_SERIALIZE)
                {
                    transfer.Move(ref bOverrideBaseProperties_DEPRECATED);
                    transfer.Move(ref bHasPropertyOverrides);
                    if (bHasPropertyOverrides)
                    {
                        transfer.Move(ref BasePropertyOverrides);
                    }
                }
            }

            return this;
        }

        [Location("void SerializeInlineShaderMaps")]
        private void SerializeInlineShaderMaps(Transfer transfer)
        {
            transfer.Move(ref LoadedResources, (x) => x.SerializeInlineShaderMap(transfer));
        }
    }
}