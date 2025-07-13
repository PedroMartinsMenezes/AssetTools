namespace AssetTool
{
    [JsonAsset("ShallowWaterSubsystem")]
    public class UShallowWaterSubsystem : UTickableWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}