namespace AssetTool
{
    [JsonAsset("BlueprintEventNodeSpawner")]
    public class UBlueprintEventNodeSpawner : UBlueprintNodeSpawner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}