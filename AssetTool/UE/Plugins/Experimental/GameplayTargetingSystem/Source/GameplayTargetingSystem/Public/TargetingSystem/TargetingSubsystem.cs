namespace AssetTool
{
    [JsonAsset("TargetingSubsystem")]
    public class UTargetingSubsystem : UGameInstanceSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}