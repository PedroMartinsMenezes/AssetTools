namespace AssetTool
{
    [JsonAsset("WorldPartition")]
    public class UWorldPartition : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}