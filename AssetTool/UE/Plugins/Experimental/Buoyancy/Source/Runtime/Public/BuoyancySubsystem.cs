namespace AssetTool
{
    [JsonAsset("BuoyancySubsystem")]
    public class UBuoyancySubsystem : UTickableWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}