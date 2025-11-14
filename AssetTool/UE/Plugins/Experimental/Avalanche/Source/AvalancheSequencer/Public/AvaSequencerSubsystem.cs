namespace AssetTool
{
    [JsonAsset("AvaSequencerSubsystem")]
    public class UAvaSequencerSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}