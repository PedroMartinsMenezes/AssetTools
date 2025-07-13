namespace AssetTool
{
    [JsonAsset("ReplaySubsystem")]
    public class UReplaySubsystem : UGameInstanceSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}