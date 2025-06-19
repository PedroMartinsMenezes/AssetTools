namespace AssetTool
{
    [JsonAsset("AvaCameraSubsystem")]
    public class UAvaCameraSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}