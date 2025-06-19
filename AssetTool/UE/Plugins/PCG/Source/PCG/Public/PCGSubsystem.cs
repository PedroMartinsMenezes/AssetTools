namespace AssetTool
{
    [JsonAsset("PCGSubsystem")]
    public class UPCGSubsystem : UTickableWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}