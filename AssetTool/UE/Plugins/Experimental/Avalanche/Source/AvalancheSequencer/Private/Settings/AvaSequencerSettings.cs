namespace AssetTool
{
    [JsonAsset("AvaSequencerSettings")]
    public class UAvaSequencerSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}