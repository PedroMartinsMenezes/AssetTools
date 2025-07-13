namespace AssetTool
{
    [JsonAsset("MassSimulationSettings")]
    public class UMassSimulationSettings : UMassModuleSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}