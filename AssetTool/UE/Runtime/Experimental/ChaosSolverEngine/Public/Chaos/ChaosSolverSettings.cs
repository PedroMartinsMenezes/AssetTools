namespace AssetTool
{
    [JsonAsset("ChaosSolverSettings")]
    public class UChaosSolverSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}