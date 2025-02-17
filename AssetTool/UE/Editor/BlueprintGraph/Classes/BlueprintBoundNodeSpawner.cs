namespace AssetTool
{
    [JsonAsset("BlueprintBoundNodeSpawner")]
    public class UBlueprintBoundNodeSpawner : UBlueprintNodeSpawner
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}