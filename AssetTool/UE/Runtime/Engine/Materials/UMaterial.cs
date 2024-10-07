namespace AssetTool
{
    [JsonAsset("Material")]
    public class UMaterial : UMaterialInterface
    {
        public const string TypeName = "Material";

        public List<FName> Names;
        public List<ShaderMap> ShaderMaps;
        ///public List<FNameEntrySerialized> Entries;
        ///public List<FMaterialResourceLocOnDisk> Locs;

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
            ShaderMaps = ShaderMaps.Resize(transfer);
            int NumLoadedResources = ShaderMaps.Count;
            if (ShaderMaps.Count == 0) ShaderMaps = null;
            if (NumLoadedResources > 0)
            {
                throw new NotImplementedException();

                ///#region void FMaterialResourceProxyReader::Initialize
                ///Names = Names.Resize(transfer);
                ///Names.ForEach(name => transfer.Move(name));
                ///
                ///Entries = Entries.Resize(transfer);
                ///Entries.ForEach(entry => entry.Move(transfer));
                ///
                ///Locs = Locs.Resize(transfer);
                ///Locs.ForEach(loc => loc.Move(transfer));
                ///#endregion
                ///
                ///for (int ResourceIndex = 0; ResourceIndex < NumLoadedResources; ++ResourceIndex)
                ///{
                ///    SerializeInlineShaderMap(transfer, ShaderMaps[ResourceIndex]);
                ///}
            }
        }

        ///private void SerializeInlineShaderMap(Transfer transfer, ShaderMap shaderMap)
        ///{
        ///    transfer.Move(ref shaderMap.bCooked);
        ///    if (shaderMap.bCooked.Value)
        ///    {
        ///        transfer.Move(ref shaderMap.bValid);
        ///        if (shaderMap.bValid.Value)
        ///        {
        ///            shaderMap.MaterialShaderMap ??= new();
        ///            shaderMap.MaterialShaderMap.Move(transfer);
        ///        }
        ///    }
        ///}
        ///
        public class ShaderMap
        {
            ///public FBool bCooked;
            ///public FBool bValid;
            ///public FMaterialShaderMap MaterialShaderMap;
        }
        ///
        ///public class FMaterialShaderMap
        ///{
        ///    public FMaterialShaderMapId ShaderMapId = new();
        ///
        ///    [Location("bool FMaterialShaderMap::Serialize(FArchive& Ar, bool bInlineShaderResources, bool bLoadedByCookedMaterial, bool bInlineShaderCode)")]
        ///    public void Move(Transfer transfer)
        ///    {
        ///        ShaderMapId.Move(transfer);
        ///        //bool FShaderMapBase::Serialize(FArchive& Ar, bool bInlineShaderResources, bool bLoadedByCookedMaterial, bool bInlineShaderCode)
        ///    }
        ///}
        ///
        ///public class FMaterialShaderMapId
        ///{
        ///    public void Move(Transfer transfer)
        ///    {
        ///        throw new NotImplementedException();
        ///    }
        ///}
        ///
        ///public class FMaterialResourceLocOnDisk
        ///{
        ///    public UInt32 Offset;
        ///    public byte FeatureLevel;
        ///    public byte QualityLevel;
        ///
        ///    public FMaterialResourceLocOnDisk Move(Transfer transfer)
        ///    {
        ///        transfer.Move(ref Offset);
        ///        transfer.Move(ref FeatureLevel);
        ///        transfer.Move(ref QualityLevel);
        ///        return this;
        ///    }
        ///}
    }
}
