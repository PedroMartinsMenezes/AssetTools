namespace AssetTool
{
    [JsonAsset("BlueprintComponentNodeSpawner")]
    public class UBlueprintComponentNodeSpawner : UBlueprintNodeSpawner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}