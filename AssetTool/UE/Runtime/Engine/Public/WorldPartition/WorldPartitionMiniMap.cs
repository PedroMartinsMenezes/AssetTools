namespace AssetTool
{
    [JsonAsset("WorldPartitionMiniMap")]
    public class AWorldPartitionMiniMap : AInfo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}