namespace AssetTool
{
    [JsonAsset("MassStationaryISMSwitcherProcessor")]
    public class UMassStationaryISMSwitcherProcessor : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}