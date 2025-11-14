namespace AssetTool
{
    [JsonAsset("HLODSubsystem")]
    public class UHLODSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}