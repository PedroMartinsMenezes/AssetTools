namespace AssetTool
{
    [JsonAsset("BlueprintBoundEventNodeSpawner")]
    public class UBlueprintBoundEventNodeSpawner : UBlueprintEventNodeSpawner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}