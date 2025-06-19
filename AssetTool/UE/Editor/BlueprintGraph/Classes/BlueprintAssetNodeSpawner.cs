namespace AssetTool
{
    [JsonAsset("BlueprintAssetNodeSpawner")]
    public class UBlueprintAssetNodeSpawner : UBlueprintNodeSpawner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}