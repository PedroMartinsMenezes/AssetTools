namespace AssetTool
{
    [JsonAsset("WorldSubsystem")]
    public class UWorldSubsystem : USubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TickableWorldSubsystem")]
    public class UTickableWorldSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}