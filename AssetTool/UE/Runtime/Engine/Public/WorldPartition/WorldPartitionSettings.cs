namespace AssetTool
{
    [JsonAsset("WorldPartitionSettings")]
    public class UWorldPartitionSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}