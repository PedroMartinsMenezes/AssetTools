namespace AssetTool
{
    [JsonAsset("DMWorldSubsystem")]
    public class UDMWorldSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}