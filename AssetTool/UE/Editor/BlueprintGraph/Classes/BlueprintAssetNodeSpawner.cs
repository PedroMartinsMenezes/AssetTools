namespace AssetTool
{
    [JsonAsset("BlueprintAssetNodeSpawner")]
    public class UBlueprintAssetNodeSpawner : UBlueprintNodeSpawner
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}