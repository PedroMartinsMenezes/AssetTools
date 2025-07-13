namespace AssetTool
{
    [JsonAsset("AssetDefinition_HLODProxy")]
    public class UAssetDefinition_HLODProxy : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}