namespace AssetTool
{
    [JsonAsset("PCGSubsystem")]
    public class UPCGSubsystem : UTickableWorldSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}