namespace AssetTool
{
    [JsonAsset("AvaTransitionRenderingSubsystem")]
    public class UAvaTransitionRenderingSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}