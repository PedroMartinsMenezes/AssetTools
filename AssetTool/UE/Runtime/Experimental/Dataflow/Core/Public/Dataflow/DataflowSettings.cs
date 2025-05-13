namespace AssetTool
{
    [JsonAsset("DataflowSettings")]
    public class UDataflowSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}