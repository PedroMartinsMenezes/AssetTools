namespace AssetTool
{
    [JsonAsset("ShallowWaterSubsystem")]
    public class UShallowWaterSubsystem : UTickableWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}