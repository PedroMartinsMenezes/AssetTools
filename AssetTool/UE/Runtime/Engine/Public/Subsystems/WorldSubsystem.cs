namespace AssetTool
{
    [JsonAsset("WorldSubsystem")]
    public class UWorldSubsystem : USubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TickableWorldSubsystem")]
    public class UTickableWorldSubsystem : UWorldSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}