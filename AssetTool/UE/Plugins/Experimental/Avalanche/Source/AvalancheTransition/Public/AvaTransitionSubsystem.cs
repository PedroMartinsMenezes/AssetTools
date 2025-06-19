namespace AssetTool
{
    [JsonAsset("AvaTransitionSubsystem")]
    public class UAvaTransitionSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}