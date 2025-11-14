namespace AssetTool
{
    [JsonAsset("AvaTransitionSubsystem")]
    public class UAvaTransitionSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}