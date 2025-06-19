namespace AssetTool
{
    [JsonAsset("AssetDefinition_AvaRundown")]
    public class UAssetDefinition_AvaRundown : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}