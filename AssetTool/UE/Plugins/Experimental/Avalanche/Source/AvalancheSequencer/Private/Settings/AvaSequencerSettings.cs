namespace AssetTool
{
    [JsonAsset("AvaSequencerSettings")]
    public class UAvaSequencerSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}