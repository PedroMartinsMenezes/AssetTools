namespace AssetTool
{
    [JsonAsset("DataflowSettings")]
    public class UDataflowSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}