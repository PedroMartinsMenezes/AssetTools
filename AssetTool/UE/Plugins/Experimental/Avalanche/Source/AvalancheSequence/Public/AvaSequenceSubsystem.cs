namespace AssetTool
{
    [JsonAsset("AvaSequenceSubsystem")]
    public class UAvaSequenceSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}