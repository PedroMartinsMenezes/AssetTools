namespace AssetTool
{
    [JsonAsset("BlueprintNodeSpawner")]
    public class UBlueprintNodeSpawner : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}