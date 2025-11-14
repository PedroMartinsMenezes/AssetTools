namespace AssetTool
{
    [JsonAsset("WorldPartitionEditorSettings")]
    public class UWorldPartitionEditorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}