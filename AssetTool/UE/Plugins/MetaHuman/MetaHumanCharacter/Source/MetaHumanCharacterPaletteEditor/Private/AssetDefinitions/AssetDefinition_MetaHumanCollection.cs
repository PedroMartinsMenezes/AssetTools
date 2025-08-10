namespace AssetTool
{
    [JsonAsset("AssetDefinition_MetaHumanCollection")]
    public class UAssetDefinition_MetaHumanCollection : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}