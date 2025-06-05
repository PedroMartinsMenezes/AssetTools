namespace AssetTool
{
    [JsonAsset("AvaTransitionSubsystem")]
    public class UAvaTransitionSubsystem : UWorldSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}