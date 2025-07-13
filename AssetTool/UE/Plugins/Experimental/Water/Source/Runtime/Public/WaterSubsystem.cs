namespace AssetTool
{
    [JsonAsset("WaterSubsystem")]
    public class UWaterSubsystem : UTickableWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}