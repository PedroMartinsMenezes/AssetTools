namespace AssetTool
{
    [JsonAsset("SearchProjectSettings")]
    public class USearchProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}