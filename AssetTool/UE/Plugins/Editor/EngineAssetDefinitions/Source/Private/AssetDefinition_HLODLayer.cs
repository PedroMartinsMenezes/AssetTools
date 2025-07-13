namespace AssetTool
{
    [JsonAsset("AssetDefinition_HLODLayer")]
    public class UAssetDefinition_HLODLayer : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}