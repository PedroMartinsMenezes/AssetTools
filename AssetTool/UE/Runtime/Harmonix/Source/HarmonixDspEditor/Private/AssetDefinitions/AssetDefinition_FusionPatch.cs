namespace AssetTool
{
    [JsonAsset("AssetDefinition_FusionPatch")]
    public class UAssetDefinition_FusionPatch : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}