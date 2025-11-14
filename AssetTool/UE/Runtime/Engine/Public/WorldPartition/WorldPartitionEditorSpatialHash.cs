namespace AssetTool
{
    [JsonAsset("WorldPartitionEditorSpatialHash")]
    public class UWorldPartitionEditorSpatialHash : UWorldPartitionEditorHash
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}