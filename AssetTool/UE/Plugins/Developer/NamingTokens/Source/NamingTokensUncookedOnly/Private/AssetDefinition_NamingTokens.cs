namespace AssetTool
{
    [JsonAsset("AssetDefinition_NamingTokens")]
    public class UAssetDefinition_NamingTokens : UAssetDefinition_Blueprint
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}