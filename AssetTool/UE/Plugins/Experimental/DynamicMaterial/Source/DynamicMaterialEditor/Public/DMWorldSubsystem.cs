namespace AssetTool
{
    [JsonAsset("DMWorldSubsystem")]
    public class UDMWorldSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}