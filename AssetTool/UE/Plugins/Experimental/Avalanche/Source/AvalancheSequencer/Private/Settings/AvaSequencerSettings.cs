namespace AssetTool
{
    [JsonAsset("AvaSequencerSettings")]
    public class UAvaSequencerSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}