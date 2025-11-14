namespace AssetTool
{
    [JsonAsset("AvaTransitionRenderingSubsystem")]
    public class UAvaTransitionRenderingSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}