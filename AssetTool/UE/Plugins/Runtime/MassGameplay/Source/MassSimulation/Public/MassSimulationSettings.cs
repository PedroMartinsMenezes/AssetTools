namespace AssetTool
{
    [JsonAsset("MassSimulationSettings")]
    public class UMassSimulationSettings : UMassModuleSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}