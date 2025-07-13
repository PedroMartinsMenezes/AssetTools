namespace AssetTool
{
    [JsonAsset("WorldPartitionEditorSettings")]
    public class UWorldPartitionEditorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}