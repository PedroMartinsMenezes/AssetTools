namespace AssetTool
{
    [JsonAsset("AvaCameraSubsystem")]
    public class UAvaCameraSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}