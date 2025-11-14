namespace AssetTool
{
    [JsonAsset("BasicShallowWaterSubsystem")]
    public class UBasicShallowWaterSubsystem : UShallowWaterSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}