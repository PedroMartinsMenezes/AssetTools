namespace AssetTool
{
    [JsonAsset("TargetingSubsystem")]
    public class UTargetingSubsystem : UGameInstanceSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}