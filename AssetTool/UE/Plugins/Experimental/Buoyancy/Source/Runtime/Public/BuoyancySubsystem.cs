namespace AssetTool
{
    [JsonAsset("BuoyancySubsystem")]
    public class UBuoyancySubsystem : UTickableWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}