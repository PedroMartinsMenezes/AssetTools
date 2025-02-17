namespace AssetTool
{
    [JsonAsset("BlueprintBoundEventNodeSpawner")]
    public class UBlueprintBoundEventNodeSpawner : UBlueprintEventNodeSpawner
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}