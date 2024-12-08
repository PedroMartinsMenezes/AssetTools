namespace AssetTool
{
    [JsonAsset("WorldPartitionEditorSpatialHash")]
    public class UWorldPartitionEditorSpatialHash : UWorldPartitionEditorHash
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}