namespace AssetTool
{
    [JsonAsset("AvaSequenceSubsystem")]
    public class UAvaSequenceSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}