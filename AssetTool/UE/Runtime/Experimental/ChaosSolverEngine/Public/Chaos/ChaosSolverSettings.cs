namespace AssetTool
{
    [JsonAsset("ChaosSolverSettings")]
    public class UChaosSolverSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}