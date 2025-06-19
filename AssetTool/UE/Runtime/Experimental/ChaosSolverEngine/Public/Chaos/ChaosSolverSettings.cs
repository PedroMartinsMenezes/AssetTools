namespace AssetTool
{
    [JsonAsset("ChaosSolverSettings")]
    public class UChaosSolverSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}