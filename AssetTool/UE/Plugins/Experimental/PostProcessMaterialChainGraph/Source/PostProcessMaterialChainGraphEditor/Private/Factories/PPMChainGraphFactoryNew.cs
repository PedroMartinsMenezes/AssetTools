namespace AssetTool
{
    [JsonAsset("PPMChainGraphFactoryNew")]
    public class UPPMChainGraphFactoryNew : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}