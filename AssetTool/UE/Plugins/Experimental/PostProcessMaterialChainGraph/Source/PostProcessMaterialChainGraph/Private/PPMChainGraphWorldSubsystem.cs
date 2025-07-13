namespace AssetTool
{
    [JsonAsset("PPMChainGraphWorldSubsystem")]
    public class UPPMChainGraphWorldSubsystem : UTickableWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}