namespace AssetTool
{
    [JsonAsset("BlueprintEventNodeSpawner")]
    public class UBlueprintEventNodeSpawner : UBlueprintNodeSpawner
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}