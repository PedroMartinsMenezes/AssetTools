namespace AssetTool
{
    [JsonAsset("WorldPartitionSettings")]
    public class UWorldPartitionSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}