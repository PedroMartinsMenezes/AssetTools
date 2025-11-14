namespace AssetTool
{
    [JsonAsset("QuartzSubsystem")]
    public class UQuartzSubsystem : UTickableWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}