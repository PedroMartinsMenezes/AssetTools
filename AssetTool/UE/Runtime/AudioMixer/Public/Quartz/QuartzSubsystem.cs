namespace AssetTool
{
    [JsonAsset("QuartzSubsystem")]
    public class UQuartzSubsystem : UTickableWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}