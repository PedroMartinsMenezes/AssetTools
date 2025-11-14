namespace AssetTool
{
    [JsonAsset("WaterSubsystem")]
    public class UWaterSubsystem : UTickableWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}