namespace AssetTool
{
    [JsonAsset("SearchProjectSettings")]
    public class USearchProjectSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}