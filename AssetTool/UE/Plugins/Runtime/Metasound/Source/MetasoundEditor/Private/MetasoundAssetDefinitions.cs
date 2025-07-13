namespace AssetTool
{
    [JsonAsset("AssetDefinition_MetaSoundPatch")]
    public class UAssetDefinition_MetaSoundPatch : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AssetDefinition_MetaSoundSource")]
    public class UAssetDefinition_MetaSoundSource : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}