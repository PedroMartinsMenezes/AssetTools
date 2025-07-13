namespace AssetTool
{
    [JsonAsset("AssetDefinition_GameplayTagAssetBase")]
    public class UAssetDefinition_GameplayTagAssetBase : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}