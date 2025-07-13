namespace AssetTool
{
    [JsonAsset("TakeRecorderChaosCacheSource")]
    public class UTakeRecorderChaosCacheSource : UTakeRecorderSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}