namespace AssetTool
{
    [JsonAsset("PCGSubsystem")]
    public class UPCGSubsystem : UTickableWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}