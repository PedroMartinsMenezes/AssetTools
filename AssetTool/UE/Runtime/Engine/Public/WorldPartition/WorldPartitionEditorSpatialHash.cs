namespace AssetTool
{
    [JsonAsset("WorldPartitionEditorSpatialHash")]
    public class UWorldPartitionEditorSpatialHash : UWorldPartitionEditorHash
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}