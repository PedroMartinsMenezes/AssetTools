namespace AssetTool
{
    [JsonAsset("BlueprintBoundNodeSpawner")]
    public class UBlueprintBoundNodeSpawner : UBlueprintNodeSpawner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}