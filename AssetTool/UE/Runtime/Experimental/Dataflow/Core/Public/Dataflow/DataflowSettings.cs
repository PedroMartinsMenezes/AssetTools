namespace AssetTool
{
    [JsonAsset("DataflowSettings")]
    public class UDataflowSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}