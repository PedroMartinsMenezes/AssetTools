namespace AssetTool
{
    [JsonAsset("HLODSubsystem")]
    public class UHLODSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}