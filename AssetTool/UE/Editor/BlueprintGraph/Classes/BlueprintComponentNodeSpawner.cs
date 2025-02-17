namespace AssetTool
{
    [JsonAsset("BlueprintComponentNodeSpawner")]
    public class UBlueprintComponentNodeSpawner : UBlueprintNodeSpawner
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}