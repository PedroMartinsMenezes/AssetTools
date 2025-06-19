namespace AssetTool
{
    [JsonAsset("AssetDefinition_PCGSettings")]
    public class UAssetDefinition_PCGSettings : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}