namespace AssetTool
{
    [JsonAsset("BasicShallowWaterSubsystem")]
    public class UBasicShallowWaterSubsystem : UShallowWaterSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}