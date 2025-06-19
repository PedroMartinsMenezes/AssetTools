namespace AssetTool
{
    [JsonAsset("AvaSequencerSubsystem")]
    public class UAvaSequencerSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}