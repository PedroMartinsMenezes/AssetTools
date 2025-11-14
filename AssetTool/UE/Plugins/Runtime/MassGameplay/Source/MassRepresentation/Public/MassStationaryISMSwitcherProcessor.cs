namespace AssetTool
{
    [JsonAsset("MassStationaryISMSwitcherProcessor")]
    public class UMassStationaryISMSwitcherProcessor : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}