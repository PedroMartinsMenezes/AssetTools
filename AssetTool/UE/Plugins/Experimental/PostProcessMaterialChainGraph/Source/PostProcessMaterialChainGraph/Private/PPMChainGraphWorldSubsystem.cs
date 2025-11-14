namespace AssetTool
{
    [JsonAsset("PPMChainGraphWorldSubsystem")]
    public class UPPMChainGraphWorldSubsystem : UTickableWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}