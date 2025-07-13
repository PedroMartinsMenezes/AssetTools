namespace AssetTool
{
    [JsonAsset("AssetDefinition_LensFile")]
    public class UAssetDefinition_LensFile : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}