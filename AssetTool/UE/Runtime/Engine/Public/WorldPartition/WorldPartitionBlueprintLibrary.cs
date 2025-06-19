namespace AssetTool
{
    [JsonAsset("WorldPartitionBlueprintLibrary")]
    public class UWorldPartitionBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}