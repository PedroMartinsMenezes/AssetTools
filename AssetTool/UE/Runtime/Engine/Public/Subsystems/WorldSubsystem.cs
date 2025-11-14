namespace AssetTool
{
    [JsonAsset("WorldSubsystem")]
    public class UWorldSubsystem : USubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TickableWorldSubsystem")]
    public class UTickableWorldSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}